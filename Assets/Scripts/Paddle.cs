using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if  (Input.GetKey("w"))
        {
            transform.position = new Vector2(transform.position.x,transform.position.y + speed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        { 
            transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision);
    }
}
