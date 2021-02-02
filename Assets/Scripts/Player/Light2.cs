using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light2 : MonoBehaviour
{
    //colores
    public Color color = new Color(228,203,153); //base (on)
    public Color color2 = new Color(0,0,0); //base (off)

    //luz 2
    public Material luzMaterial2;
    public GameObject luz2;
    static public bool estado2;
    static public bool sePrendeLaLuz2;

    void Start()
    {
        estado2 = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerRaycasting.tocaElInterruptor2 == true && PlayerRaycasting.estaTocandoElSwitch2 == true)
        {
            //texto iteraccion true
            if (Input.GetButtonDown("Action"))
            {
                Debug.Log("se interactuo con el switch 2");
                if (estado2 == false)
                {
                    sePrendeLaLuz2 = false;
                    luz2.SetActive(true);
                    prenderLuz2();
                } 

                else if(estado2 == true)
                {
                    sePrendeLaLuz2 = true;
                    luz2.SetActive(false);
                    apagarLuz2();
                }        
            }
        }
    }
    //[funciones de luz 2]-----------------------------
    public void apagarLuz2()
    {
        estado2 = false;
        luzMaterial2.SetColor("_EmissionColor", color2); //cambiar color de material(emission) cuando se apaga
    }

    public void prenderLuz2()
    {
        estado2 = true;
        luzMaterial2.SetColor("_EmissionColor", color); //cambiar color de material(emission) cuando se prende
    }
    //-------------------------------------------------
}