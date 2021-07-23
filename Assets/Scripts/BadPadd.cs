using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadPadd : MonoBehaviour
{
    public GameObject ball;
    public float ypos;
    public float diff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        diff= ball.transform.position.y - transform.position.y;
        float newPos = Mathf.Sign(diff) * Time.deltaTime + transform.position.y;
        transform.position = new Vector3(transform.position.x,newPos);
    }
}