using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAcelerometer : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float verticalInput = Input.acceleration.y;
        Vector2 moveDirection = new Vector2(0, verticalInput).normalized;

        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
