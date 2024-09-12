using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementTouch : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            float verticalInput = touchPosition.y - transform.position.y;
            Vector2 moveDirection = new Vector2(0, verticalInput).normalized;

            transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
        }
    }
}
