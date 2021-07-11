using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private Rigidbody2D rb;
    private int collision;

    public int maxCollisions = 0;

    public float Speed { get => speed; set => speed = value; }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Propel(Vector2 direction)
    {
        rb.AddForce(direction * speed);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        collision++;
        if (collision >= maxCollisions)
        {
            Destroy(gameObject);
        }
    }
}
