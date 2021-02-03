using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light2 : MonoBehaviour
{
    //colores
    public Color color = new Color(228,203,153); //base (on)
    public Color color2 = new Color(0,0,0); //base (off)

    //luz 2
    public Material lightMaterial2;
    public GameObject light2;
    static public bool state2;
    static public bool lightTurnsOn2;

    void Start()
    {
        state2 = true;
    }

    void Update()
    {
        if(PlayerRaycasting.touchTheSwitch2 == true && PlayerRaycasting.itsTouchingTheSwitch2 == true)
        {
            if (Input.GetButtonDown("Action"))
            {
                Debug.Log("se interactuo con el switch 2");
                if (state2 == false)
                {
                    lightTurnsOn2 = false;
                    light2.SetActive(true);
                    turnOn();
                } 
                else if(state2 == true)
                {
                    lightTurnsOn2 = true;
                    light2.SetActive(false);
                    turnOff();
                }        
            }
        }
    }

    public void turnOff()
    {
        state2 = false;
        lightMaterial2.SetColor("_EmissionColor", color2); //cambiar color de material(emission) cuando se apaga
    }

    public void turnOn()
    {
        state2 = true;
        lightMaterial2.SetColor("_EmissionColor", color); //cambiar color de material(emission) cuando se prende
    }
}