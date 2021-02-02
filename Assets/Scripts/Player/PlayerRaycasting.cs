using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerRaycasting : MonoBehaviour
{

    //estados de pausa
    static public bool estadoMenuCelular = false;
    //estados de pausa
    
    //objetos de "ui"
    public GameObject uiPrincipal;
    public GameObject menuCelular;
    public TextMeshProUGUI textoInteraccion;
    //objetos de "ui"

    //reparacion bug textoInteraccion
    public float tiempoInicio = 0f;
    //reparacion bug textoInteraccion

    public float distanciaParaVer;
    public Transform objetoRadioJugador;
    static public RaycastHit interruptor;
    static public RaycastHit telefono;

    //switch 1
    public LayerMask switchLuz;
    static public bool estaTocandoElSwitch;
    static public bool tocaElInterruptor;
    

    //switch 2
    public LayerMask switchLuz2;
    static public bool estaTocandoElSwitch2;
    static public bool tocaElInterruptor2;

    //Celular
    public LayerMask celular;
    static public bool estaTocandoElCelular;
    static public bool tocaElCelular;

    void Start()
    { 
    }

    void Update()
    {
        estaTocandoElSwitch = Physics.CheckSphere(objetoRadioJugador.position, 0.8f, switchLuz);
        estaTocandoElSwitch2 = Physics.CheckSphere(objetoRadioJugador.position, 0.8f, switchLuz2);
        estaTocandoElCelular = Physics.CheckSphere(objetoRadioJugador.position, 1f, celular);

        Debug.DrawRay(this.transform.position, this.transform.forward * distanciaParaVer, Color.magenta);

        tocaElInterruptor = Physics.Raycast(this.transform.position, this.transform.forward, out interruptor, distanciaParaVer,switchLuz);  
        tocaElInterruptor2 = Physics.Raycast(this.transform.position, this.transform.forward, out interruptor, distanciaParaVer,switchLuz2);  
        tocaElCelular = Physics.Raycast(this.transform.position, this.transform.forward, out telefono, 2, celular);  
        
        //iteractuables
        if(tocaElCelular == true && estaTocandoElCelular == true)
        {
            textoInteraccion.color = new Color32(255,255,255,255);
            if (Input.GetButtonDown("Action") && estadoMenuCelular == false)
            {
                Time.timeScale = 0f;
                menuCelular.SetActive(true);
                uiPrincipal.SetActive(false);
                textoInteraccion.color = new Color32(255,255,255,0);
                Cursor.lockState = CursorLockMode.None;
                estadoMenuCelular = true;
                //menu celular activado

                //abrir celular, no hace falta hacer otra cosa
                //permitir cambiar de opinion      
            } 
        }
        else if(tocaElInterruptor == true && estaTocandoElSwitch == true)
        {
            textoInteraccion.color = new Color32(255,255,255,255);
        }
        else if(tocaElInterruptor2 == true && estaTocandoElSwitch2 == true)
        {
            textoInteraccion.color = new Color32(255,255,255,255);
        }
        else
        {
            textoInteraccion.color = new Color32(255,255,255,0);
        }
        //interactuables
        
        //cerrar menu celular
        if (Input.GetButtonDown("Escape") && estadoMenuCelular == true){
            Time.timeScale = 1f;
            menuCelular.SetActive(false);
            uiPrincipal.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            estadoMenuCelular = false;
        }
        //cerrar menu celular

        //menu de pausa
        //.............
        //codigo aqui
        //.............
        //menu de pausa

        //cerrar menu de pausa
        //....................
        //codigo aqui
        //....................
        //cerrar menu de pausa
    }
}