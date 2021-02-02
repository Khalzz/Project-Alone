using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoPausa : MonoBehaviour
{

    static public int final = 0;
    
    static public void cambiarEstado(){
        PlayerRaycasting.estadoMenuCelular = true;
    }

    public void fondoPantallaCulpa(){
        final = 1; //culpa
        Debug.Log(final);
    }

    public void fondoPantallaRemordimiento(){
        final = 2; //remordimiento
        Debug.Log(final);
    }

    public void apagarPantalla(){
        final = 3; //indiferencia
        Debug.Log(final);
    }
}
