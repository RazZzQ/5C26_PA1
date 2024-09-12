using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGiroscope : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float verticalInput = Input.gyro.attitude.eulerAngles.y;

        float normalizedInput = Mathf.Clamp((verticalInput - 180f) / 180f, -1f, 1f);
        Vector2 moveDirection = new Vector2(0, normalizedInput).normalized;

        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
