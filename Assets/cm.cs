using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cm : MonoBehaviour
{
    Rigidbody rb;
    public int speed = 1;
    float timer =  0;
    bool once = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >3 && once)
        {
            rb.velocity += transform.forward * speed;
            once = false;
            timer = 0;
        }
        if(timer>0.1 && !once)
        {
            rb.velocity += transform.forward * speed;
            timer = 0;
        }
        
    }
}
