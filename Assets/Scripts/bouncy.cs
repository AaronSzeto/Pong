using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncy : MonoBehaviour
{
    public float Vx;
    public float Vy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x + Vx * Time.deltaTime, transform.position.y + Vy * Time.deltaTime);
        if (transform.position.y > 4.5 || transform.position.y < -4.5)
        {
            Vy = -Vy;
        }
        if (transform.position.x > 6 || transform.position.x < -6)
        {
            transform.position = new Vector3(0, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Vx = -Vx;
    }
}