using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject pipeeditedPrefabs;
    

    

    
   // public int pipesSpawnCount;

    public Vector2 lastEndPoint;

    public void SpawnPipes()
    {
        for (int i = 0; i < 50; i++)
        {
            pipeeditedPrefabs = GameObject.Instantiate(pipeeditedPrefabs,
                new Vector2(lastEndPoint.x, lastEndPoint.y), Quaternion.identity);

            Pipes PipesScript = pipeeditedPrefabs.GetComponent<Pipes>();

            pipeeditedPrefabs.transform.position = lastEndPoint;

            lastEndPoint = PipesScript.ReturnEndPoint();

        }

      //  Invoke("SpawnPipes", 5f);
    }

   

    private void Start()
    {
       SpawnPipes();
    }

    private void Update()
    {
        
    }
    private void FixedUpdate()
    {
        
    }
}
