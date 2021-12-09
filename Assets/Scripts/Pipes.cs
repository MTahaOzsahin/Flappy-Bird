using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pipes : MonoBehaviour
{
    
    public SpriteRenderer Pipespriterenderer;
    public Rigidbody2D Pipesrigidbody2D;
    public float pipesspeed;
    


    public Vector2 ReturnEndPoint()
    {
        Vector2 calculatedEndPoint;

        calculatedEndPoint.x = Pipespriterenderer.bounds.size.x +
            this.transform.position.x + Random.Range(5f, 10f);

        calculatedEndPoint.y = Random.Range(-2f, 2f);



        return calculatedEndPoint;
    }




    /*
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Pipes")
            {
                Destroy(collision.gameObject);
            }
        }

        */




    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("destroy"))
        {
            Destroy(this.gameObject);
        }

        else if (collision.gameObject.CompareTag("birds"))
        {
            SceneManager.LoadScene("End");
        }

      
    }

   



    void pipesmovement()
    {
        Pipesrigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation;
        Pipesrigidbody2D.velocity = new Vector2(-pipesspeed, 0f);
    }

    void Start()
    {
        
        Pipesrigidbody2D = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        pipesmovement();
      
    }

}
