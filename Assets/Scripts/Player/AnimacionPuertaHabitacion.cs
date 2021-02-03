using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionPuertaHabitacion : MonoBehaviour
{

    Animation animation;

    void Start()
    {
        animation = this.gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        //la puerta se abre al seleccionar que hacer con el telefono
        if(EstadoPausa.ending == 1)
        {
            Debug.Log("la puerta se abrio (final culpa)");
            animation.Play("abrirPuerta");
        }
        else if(EstadoPausa.ending == 2)
        {
            Debug.Log("la puerta se abrio (final remordimiento)");
            animation.Play("abrirPuerta");
        }
        else if(EstadoPausa.ending == 3)
        {
            Debug.Log("la puerta se abrio (final indiferencia)");
            animation.Play("abrirPuerta");
        }
    }
}
