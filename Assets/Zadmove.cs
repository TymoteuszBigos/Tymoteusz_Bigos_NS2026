using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadmove : MonoBehaviour
{
    public float speed = 20f;
    private bool canMove = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            canMove = !canMove;
        }

        if (canMove == true)
        { 
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0, 0, 10f));
        } 
       
        transform.position = new Vector3(transform.position.x + (Input.GetAxis("Horizontal") * speed * Time.deltaTime), transform.position.y + (Input.GetAxis("Vertical") * speed * Time.deltaTime), 0);
        

    }
}
