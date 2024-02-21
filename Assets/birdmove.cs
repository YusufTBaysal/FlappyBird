using UnityEngine;
using UnityEngine.UI;


public class FlappyBirdController : MonoBehaviour
{
    public float jumpForce = 5.5f;
    private Rigidbody2D rb;
    public GameObject deathPanel;
    public Text text;
    public Text yourScore;
    int score = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        text.text = "Score : " + score;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe"))
        {
            DeathScreen();
        }
    }

    void DeathScreen()
    {
        Destroy(gameObject);
        Debug.Log("Öldün");

        yourScore.text = "Your Score : " + score;

        if(deathPanel != null)
        {
            deathPanel.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Skor"))
        {
            score++;
            text.text = "Skor : " + score;
        }
    }

}
