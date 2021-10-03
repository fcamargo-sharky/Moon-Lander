using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class src_barraMotor : MonoBehaviour
{
    public Image barraMot;
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
        barraMot.fillAmount = motor.fuerzaY / 5000000;
    }
}
