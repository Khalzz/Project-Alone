using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    //colores
    public Color color = new Color(229,203,153); //base (on)
    public Color color2 = new Color(0,0,0); //base (off)

    //luz 1
    public Material luzMaterial;
    public GameObject luz;
    static public bool estado;
    static public bool sePrendeLaLuz;
    
    void Start()
    {
    }

    void Update()
    {
        if(PlayerRaycasting.tocaElInterruptor == true && PlayerRaycasting.estaTocandoElSwitch == true)
        {
            //texto iteraccion true
            if (Input.GetButtonDown("Action"))
            {
                Debug.Log("se interactuo con el switch 1");
                if(estado == true)
                {
                    sePrendeLaLuz = false;
                    luz.SetActive(false);
                    apagarLuz();
                }
                else if (estado == false)
                {
                    sePrendeLaLuz = true;
                    luz.SetActive(true);
                    prenderLuz();
                }        
            }
        }
    }

    //[funciones de luz 1]-----------------------------
    public void apagarLuz()
    {
        estado = false;
        luzMaterial.SetColor("_EmissionColor", color2); //cambiar color de material(emission) cuando se apaga
    }

    public void prenderLuz()
    {
        estado = true;
        luzMaterial.SetColor("_EmissionColor", color); //cambiar color de material(emission) cuando se prende
    }
    //-------------------------------------------------
}