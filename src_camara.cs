using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class src_camara : MonoBehaviour
{
    public float velocidadH;
    public float velocidadV;
    public float velocidadMover;
    public float velocidadAcercar;
    float yaw;
    float pitch;
    float movimientoX;
    float movimientoY;
    public Rigidbody rb;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rotar();
        mover();
        acercar();
        positionPlayer();
    }

    public void rotar()
    {
        if (Input.GetMouseButton(1))
        {
            yaw += velocidadH * Input.GetAxis("Mouse X");
            pitch += velocidadV * Input.GetAxis("Mouse Y");
            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }
    }

    public void mover()
    {
        if (Input.GetMouseButton(2))
        {
            movimientoX = velocidadMover * Time.deltaTime * Input.GetAxis("Mouse X");
            movimientoY = velocidadMover * Time.deltaTime * Input.GetAxis("Mouse Y");
            transform.position += new Vector3(movimientoX, movimientoY, 0.0f);
        }
    }

    public void acercar()
    {
        if(Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            transform.position += new Vector3(0f, 0f, velocidadAcercar * Time.deltaTime);
        }else if(Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            transform.position += new Vector3(0f, 0f, -(velocidadAcercar * Time.deltaTime));
        }
    }

    public void positionPlayer()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            transform.position = player.transform.position;
        }
    }
}
