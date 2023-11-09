using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed)* Time.deltaTime;
        if(transform.position.x < deadZone)
        {
        
         Destroy (gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision){

    Debug.Log("Collision detected with: " + collision.gameObject.name);

    if (collision.gameObject.CompareTag("Player"))
    {
        
        LogicScript1 logic = FindObjectOfType<LogicScript1>();
        logic.gameOver();

    
        Destroy(gameObject);
    }
    }
}
   
