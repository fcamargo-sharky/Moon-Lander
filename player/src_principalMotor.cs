using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class src_principalMotor : MonoBehaviour
{
    public Rigidbody rb;
    public float fuerzaY;
    public bool motorON;
    public string tecla;
    public float combustibleActual, combustibleTotal, combustibleAGastar;
    public ParticleSystem fuego;

    // Start is called before the first frame update
    void Start()
    {
        motorON = false;
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(0f, 18000000, 0f, ForceMode.Impulse);
        combustibleActual = combustibleTotal;
        fuego.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        setMotorON();
        if (motorON && combustibleActual > 0)
        {
            gastarCombustible();
            setForce();
        }else
        {
            fuego.Stop();
        }
        cambiarIntensidad();
    }

    public void setForce()
    {
        rb.AddRelativeForce(0f, fuerzaY, 0f, ForceMode.Force);
    }

    public void setMotorON()
    {
        if (Input.GetButtonDown(tecla))
        {
            motorON = !motorON;
            fuego.Play();
        }
    }

    public void gastarCombustible()
    {
        combustibleActual -= combustibleAGastar;
    }

    public void cambiarIntensidad()
    {
        if (Input.GetKey(KeyCode.UpArrow) && fuerzaY < 5000000)
        {
            fuerzaY += 1000000.0f * Time.deltaTime;
            combustibleAGastar = fuerzaY * 3200 / 5000000;
        }else if(Input.GetKey(KeyCode.DownArrow) && fuerzaY > 0)
        {
            fuerzaY -= 1000000.0f * Time.deltaTime;
            combustibleAGastar = fuerzaY * 3200 / 5000000;
        }
    }
}
