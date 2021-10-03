using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class src_jugador : MonoBehaviour
{
    public Rigidbody rb;
    float gravity = -1.6f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        setGravity();
    }

    public void setGravity()
    {
        rb.AddForce(0, gravity, 0, ForceMode.Acceleration);
    }

    
}
