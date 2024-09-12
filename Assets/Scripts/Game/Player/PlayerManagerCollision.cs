using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PlayerManagerCollision : MonoBehaviour
{
    public event Action OnCollisionCandy;
    public event Action OnCollisionEnemy;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Candy")) {
            OnCollisionCandy?.Invoke();
            collision.gameObject.SetActive(false);
        }
        if (collision.CompareTag("Enemy")) {
            OnCollisionEnemy?.Invoke();
            collision.gameObject.SetActive(false);
        }
    }
}
