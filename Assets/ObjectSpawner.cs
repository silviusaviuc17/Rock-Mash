using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject Rock;
    public float spawnRate = 2;
    private float timer = 0;
    
    public float heightOffset = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnRock();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer= timer + Time.deltaTime;
        }
        else
        {
            spawnRock();
            timer = 0;
        }
        

        
    }
    void spawnRock()
    {
    float lowestPoint = transform.position.y - heightOffset;
    float highestPoint = transform.position.y + heightOffset;
    Instantiate(Rock, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Trigger game over
            LogicScript1 logic = FindObjectOfType<LogicScript1>();
            logic.gameOver();
            

            // Optionally, destroy the object here if needed
            Destroy(gameObject);
        }
    }

}


