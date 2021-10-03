using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class src_move : MonoBehaviour
{
    public Rigidbody rb;
    public float fuerza;
    public Vector3 posicionInicial;

    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = transform.position;
        rb = GetComponent<Rigidbody>();
        setForce();
    }

    // Update is called once per frame
    void Update()
    {
        volverPosicion();
    }

    public void setForce()
    {
        rb.AddRelativeForce(0.0f, fuerza, 0.0f);
    }

    public void volverPosicion()
    {
        if (transform.position.x >= 80)
        {
            transform.position = posicionInicial;
        }
    }
}
