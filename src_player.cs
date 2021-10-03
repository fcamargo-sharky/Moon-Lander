using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class src_player : MonoBehaviour
{
    //private Vector3 positionChangeX;
    public float velocidadX;
    float limiteMayor;
    float limiteMenor;
    public float aumento;
    public float disminuir;
    public bool motorXON;
    public int contador = 0;

    // Start is called before the first frame update
    void Start()
    {
        velocidadX = 0.01f;
        //positionChangeX = new Vector3(0.00f, (velocidad * Time.deltaTime), 0.00f);
        limiteMayor = 50f;
        limiteMenor = 0f;
        aumento = 0f;
        disminuir = 0f;
        motorXON = false;
    }

    // Update is called once per frame
    void Update()
    {
        setMotorXON();
        setVelocidadX();
        movimiento();
        if(Input.GetKeyDown(KeyCode.F)){
            contador++;
        }
    }

    public void movimiento(){
        transform.position += new Vector3(0.00f, (velocidadX * Time.deltaTime), 0.00f);
    }

    public void setVelocidadX(){
        if(motorXON && velocidadX <= limiteMayor){
            //disminuir = 1f;
            velocidadX += 0.01f;
            //aumento += 100f;
        }else if(!motorXON && velocidadX >= limiteMenor){
            //aumento = 1f;
            velocidadX -= 0.01f;
            //disminuir += 100f;
            if(velocidadX < 0f){
                velocidadX = 0f;
            }
        }
    }

    public void setMotorXON(){
        if(Input.GetKeyDown(KeyCode.F)){
            motorXON = !motorXON;
        }
    }

    public void orbita(){

    }
}
