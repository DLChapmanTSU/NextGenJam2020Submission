using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;
    public float sneakSpeed;

    public Rigidbody2D rb;

    private Vector2 movement;

    private bool isSneaking;

    public GameObject bulletPrefab;

    public int lives;
    private int livesMax;

    private bool isHit;
    public bool isDead;

    private float fireTimer;
    public float fireDelay;

    public GameObject fullHealthImage;
    public GameObject twoHealthImage;
    public GameObject oneHealthImage;
    public GameObject noHealthImage;

    public GameObject deathMenu;

    public int points;
    public TMPro.TextMeshProUGUI pointsText;
    public TMPro.TextMeshProUGUI highscoreText;

    public AudioSource deathSound;

    public Animator playerAnimator;
    public Animator cameraAnimator;

    public GameObject deathParticle;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        isSneaking = false;
        isHit = false;
        lives = 3;
        livesMax = lives;
        isDead = false;
        fullHealthImage.SetActive(true);
        twoHealthImage.SetActive(false);
        oneHealthImage.SetActive(false);
        noHealthImage.SetActive(false);
        deathMenu.SetActive(false);

        if (SceneManager.GetActiveScene().name == "EndlessScene")
        {
            highscoreText.text = "Highscore: " + PlayerPrefs.GetInt("EndlessScore", 0).ToString();
        }
        else
        {
            highscoreText.text = "Highscore: " + PlayerPrefs.GetInt("Highscore", 0).ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        fireTimer += Time.deltaTime;

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        movement = movement.normalized;

        if (Input.GetKey(KeyCode.LeftShift) && isDead == false)
        {
            isSneaking = true;
        }
        else
        {
            isSneaking = false;
        }

        if (Input.GetKey(KeyCode.Space) && isHit == false && isDead == false && fireTimer >= fireDelay)
        {
            ObjectPooler.Instance.SpawnFromPool("Bullet", transform.position, transform.rotation);
            fireTimer = 0.0f;
        }

        if (lives < 0)
        {
            lives = 0;
        }
        else if (lives > livesMax)
        {
            lives = livesMax;
        }

        pointsText.text = points.ToString();
        //highscoreText.text = "Highscore: " + PlayerPrefs.GetInt("Highscore", 0).ToString();
    }

    private void FixedUpdate()
    {
        if (isSneaking == true && isDead == false)
        {
            rb.MovePosition(rb.position + movement * sneakSpeed * Time.fixedDeltaTime);
        }
        else if (isSneaking == false && isDead == false)
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (isHit == false)
            {
                StartCoroutine(HitResponse());
            }
        }
    }

    IEnumerator HitResponse()
    {
        deathSound.Play();
        Instantiate(deathParticle, transform.position, transform.rotation);
        cameraAnimator.SetTrigger("Hit");
        lives = lives - 1;
        points = points - 100;
        if (points < 0)
        {
            points = 0;
        }
        isHit = true;
        //this.GetComponent<CircleCollider2D>().enabled = false;
        LivesChange();

        if (lives <= 0)
        {
            print("Player Dead");
            isDead = true;
            Destroy(GetComponent<Rigidbody2D>());
            Destroy(GetComponent<CircleCollider2D>());
            playerAnimator.SetTrigger("Dead");
            yield return new WaitForSeconds(1f);
            DeathMenu();
            if (SceneManager.GetActiveScene().name == "EndlessScene")
            {
                EndlessScoreUpdate();
            }
        }
        else
        {
            AlphaChange();
        }

        yield return new WaitForSeconds(2f);

        if (isDead == false)
        {
            isHit = false;
            //this.GetComponent<CircleCollider2D>().enabled = true;
            AlphaReset();
        }
    }

    void DeathMenu()
    {
        deathMenu.SetActive(true);
        Time.timeScale = 0.0f;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    void EndlessScoreUpdate()
    {
        int temp = PlayerPrefs.GetInt("EndlessScore", 0);
        if (points >= temp)
        {
            PlayerPrefs.SetInt("EndlessScore", points);
        }
    }

    public void LivesChange()
    {
        if (lives == 3)
        {
            fullHealthImage.SetActive(true);
            twoHealthImage.SetActive(false);
            oneHealthImage.SetActive(false);
            noHealthImage.SetActive(false);
        }
        else if (lives == 2)
        {
            fullHealthImage.SetActive(false);
            twoHealthImage.SetActive(true);
            oneHealthImage.SetActive(false);
            noHealthImage.SetActive(false);
        }
        else if (lives == 1)
        {
            fullHealthImage.SetActive(false);
            twoHealthImage.SetActive(false);
            oneHealthImage.SetActive(true);
            noHealthImage.SetActive(false);
        }
        else if (lives <= 0)
        {
            fullHealthImage.SetActive(false);
            twoHealthImage.SetActive(false);
            oneHealthImage.SetActive(false);
            noHealthImage.SetActive(true);
        }
    }

    void AlphaChange()
    {
        var temp = this.GetComponent<SpriteRenderer>().color;
        temp.a = 0.5f;
        this.GetComponent<SpriteRenderer>().color = temp;
    }

    void AlphaReset()
    {
        var temp = this.GetComponent<SpriteRenderer>().color;
        temp.a = 1.0f;
        this.GetComponent<SpriteRenderer>().color = temp;
    }
}
