using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BirdsMovement : MonoBehaviour
{
    public float JumpForce;
    public Rigidbody2D Birdrigidbody2D;
    public static int playerscore = 0;
    public Text Scoretext;
    


    private void Awake()
    {
        Birdrigidbody2D = GetComponent<Rigidbody2D>();
    }

    void HandleJump()
    {
        Birdrigidbody2D.position = new Vector2(0f, Birdrigidbody2D.position.y);
        Birdrigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation;
        if (Input.GetKey(KeyCode.Space))
        {
            Birdrigidbody2D.velocity = new Vector2(0f, JumpForce);
        }

        else if (Birdrigidbody2D.transform.position.y <= -20)
        {
            SceneManager.LoadScene("End");
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("scorepoint"))
        {
            playerscore++;
        }
    }

   

    void Start()
    {
        playerscore = 0;
    }

   
    void Update()
    {
        HandleJump();
        Scoretext.text ="Score: " + playerscore.ToString();
    }
}
