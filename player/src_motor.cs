using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class src_motor : MonoBehaviour
{
    public Rigidbody rb;
    public src_principalMotor principalMotor;
    public float velocidad;
    public float fuerza;
    public ParticleSystem motor1, motor2, motor3, motor4;
    public bool motor1ON, motor2ON, motor3ON, motor4ON;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        motor1.Stop();
        motor2.Stop();
        motor3.Stop();
        motor4.Stop();
        motor1ON = false;
        motor2ON = false;
        motor3ON = false;
        motor4ON = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(principalMotor.combustibleActual > 0)
        {
            rotar();
            activarMotores();
            contrarrestar();
        }
    }

    public void rotar()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * velocidad);
        }else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back* Time.deltaTime * velocidad);
        }else if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(Vector3.right * Time.deltaTime * velocidad);
        }else if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(Vector3.left * Time.deltaTime * velocidad);
        }
    }

    public void contrarrestar()
    {
        if (motor2ON)
        {
            rb.AddRelativeForce(fuerza, 0f, 0f, ForceMode.Force);
        }
        else
        {
            motor2.Stop();
        }
        
        if (motor3ON)
        {
            rb.AddRelativeForce(-fuerza, 0f, 0f, ForceMode.Force);
        }
        else
        {
            motor3.Stop();
        }
        
        if (motor1ON)
        {
            rb.AddRelativeForce(0f, 0f, fuerza, ForceMode.Force);
        }
        else
        {
            motor1.Stop();
        }
        
        if (motor4ON)
        {
            rb.AddRelativeForce(0f, 0f, -fuerza, ForceMode.Force);
        }
        else
        {
            motor4.Stop();
        }
    }

    public void activarMotores()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            motor2ON = !motor2ON;
            motor2.Play();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            motor3ON = !motor3ON;
            motor3.Play();
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            motor1ON = !motor1ON;
            motor1.Play();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            motor4ON = !motor4ON;
            motor4.Play();
        }
    }
}
