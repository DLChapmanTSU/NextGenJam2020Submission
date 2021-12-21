using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticEnemyController : MonoBehaviour
{
    public float enemySpeed;
    public Rigidbody2D rb;
    public Vector2 target;
    public int pointValue;
    private GameObject player;
    public GameObject soundPrefab;
    public GameObject particle;
    public int health;
    private int currentHealth;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        currentHealth = health;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + target * enemySpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerBullet")
        {
            currentHealth = currentHealth - 1;

            if (currentHealth == 0)
            {
                player.GetComponent<PlayerController>().points = player.GetComponent<PlayerController>().points + pointValue;
                Instantiate(soundPrefab, transform.position, transform.rotation);
                Instantiate(particle, transform.position, transform.rotation);
                currentHealth = health;
                gameObject.SetActive(false);
            }
        }

        //if (collision.gameObject.tag == "Player")
        //{
        //    gameObject.SetActive(false);
        //}
    }
}
