using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPassScript : MonoBehaviour
{
    public LogicScript1 logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript1>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 6) //character
        {
             logic.addScore(1);
        }
        
    }
}
