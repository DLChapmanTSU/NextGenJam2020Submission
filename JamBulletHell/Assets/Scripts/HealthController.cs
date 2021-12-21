using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{

    private GameObject player;

    public Rigidbody2D rb;
    public Vector2 target;
    public float speed;
    public GameObject healthParticle;
    public GameObject healthNoise;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Destroy(gameObject, 6.0f);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + target * speed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.GetComponent<PlayerController>().lives = player.GetComponent<PlayerController>().lives + 1;
            player.GetComponent<PlayerController>().LivesChange();
            Instantiate(healthParticle, transform.position, transform.rotation);
            Instantiate(healthNoise, transform.position, transform.rotation);
            Destroy(gameObject, 0.001f);
        }
    }
}
