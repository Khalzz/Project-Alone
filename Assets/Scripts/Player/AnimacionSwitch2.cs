using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionSwitch2 : MonoBehaviour
{
    Animation animacion2;

    void Start()
    {
        animacion2 = this.gameObject.GetComponent<Animation>(); 
    }

    void Update()
    {
        //activar animacion de prender la luz 2 cuando esta accion ocurre
        if(Light2.sePrendeLaLuz2 == true)
        {
            animacion2.Play("interruptor2Reverse");    
        }
        //activar animacion de apagar la luz 2 cuando esta accion ocurre
        else if (Light2.sePrendeLaLuz2 == false)
        {
            animacion2.Play("interruptor2");
        }
    }
}