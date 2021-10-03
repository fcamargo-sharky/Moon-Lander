using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class src_seguirJugador : MonoBehaviour
{
    public GameObject jugador;
    public float velocidadH;
    public float velocidadV;

    float yaw;
    float pitch;

    Quaternion guardarRotacion = new Quaternion();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotacion();
        movimiento();
    }

    public void rotacion()
    {
        if (Input.GetMouseButton(1))
        {
            yaw += velocidadH * Input.GetAxis("Mouse X");
            pitch -= velocidadV * Input.GetAxis("Mouse Y");

            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }

    }

    public void movimiento()
    {
        if (Input.GetKey(KeyCode.F))
        {
            guardarRotacion = transform.rotation;
            transform.position = new Vector3(jugador.transform.position.x, jugador.transform.position.y + 4, jugador.transform.position.z);
            transform.rotation = guardarRotacion;
        }
    }
}
