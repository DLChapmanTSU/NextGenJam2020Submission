using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float bulletSpeed;
    public Rigidbody2D rb;
    public Vector2 target;

    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + target * bulletSpeed * Time.fixedDeltaTime);
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Enemy")
    //    {
    //        gameObject.SetActive(false);
    //    }

    //    if (collision.gameObject.tag == "InvisibleWall")
    //    {
    //        gameObject.SetActive(false);
    //    }
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == "InvisibleWall")
        {
            gameObject.SetActive(false);
        }
    }
}
