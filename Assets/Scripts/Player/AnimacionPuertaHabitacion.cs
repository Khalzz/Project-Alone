using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionPuertaHabitacion : MonoBehaviour
{

    Animation animacion;

    void Start()
    {
        animacion = this.gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        //la puerta se abre al seleccionar que hacer con el telefono
        if(EstadoPausa.final == 1)
        {
            Debug.Log("la puerta se abrio (final culpa)");
            animacion.Play("abrirPuerta");
        }
        else if(EstadoPausa.final == 2)
        {
            Debug.Log("la puerta se abrio (final remordimiento)");
            animacion.Play("abrirPuerta");
        }
        else if(EstadoPausa.final == 3)
        {
            Debug.Log("la puerta se abrio (final indiferencia)");
            animacion.Play("abrirPuerta");
        }
    }
}
