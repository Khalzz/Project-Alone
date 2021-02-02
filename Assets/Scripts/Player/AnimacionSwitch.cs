using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionSwitch : MonoBehaviour
{
    Animation animacion;

    void Start()
    {
        animacion = this.gameObject.GetComponent<Animation>();
    }

    void Update()
    {
        //activar animacion de prender la luza cuando esta accion ocurre
        if(Light.sePrendeLaLuz == true)
        {
            animacion.Play("interruptor");    
        }
        //activar animacion de apagar la luz cuando esta accion ocurre
        else if (Light.sePrendeLaLuz == false)
        {
            animacion.Play("interruptorReversa");
        }
    }
}