using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class CandyController : MonoBehaviour
{
    public float speed = 3f;
    public string Candy;
    public CandyController candy;
    void Start()
    {
        candy = GetComponent<CandyController>();
    }
    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Limit"))
        {
            gameObject.SetActive(false);
        }
    }
}
