using UnityEngine;

public class Bird : MonoBehaviour
{

    public GameManager gameManager;

    public Rigidbody2D rb;

    public float jumpForce = 200f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpForce * Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }


}
