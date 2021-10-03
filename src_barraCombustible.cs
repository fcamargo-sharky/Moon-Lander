using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class src_barraCombustible : MonoBehaviour
{
    public Image barraCom;
    public src_principalMotor motor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transformarScale();
    }

    public void transformarScale()
    {
        barraCom.fillAmount = motor.combustibleActual / motor.combustibleTotal;
    }
}
