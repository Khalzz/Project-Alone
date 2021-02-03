using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    //colores
    public Color color = new Color(229,203,153); //base (on)
    public Color color2 = new Color(0,0,0); //base (off)

    //luz 1
    public Material lightMaterial;
    public GameObject light;
    static public bool state;
    static public bool lightTurnsOn;

    void Update()
    {
        if(PlayerRaycasting.touchTheSwitch == true && PlayerRaycasting.itsTouchingTheSwitch == true)
        {
            if (Input.GetButtonDown("Action"))
            {
                if(state == true)
                {
                    lightTurnsOn = false;
                    light.SetActive(false);
                    turnOff();
                    Debug.Log("kitchen light turns off");
                }
                else if (state == false)
                {
                    lightTurnsOn = true;
                    light.SetActive(true);
                    turnOn();
                    Debug.Log("kitchen light turns on");
                }        
            }
        }
    }

    public void turnOff()
    {
        state = false;
        lightMaterial.SetColor("_EmissionColor", color2); //cambiar color de material(emission) cuando se apaga
    }

    public void turnOn()
    {
        state = true;
        lightMaterial.SetColor("_EmissionColor", color); //cambiar color de material(emission) cuando se prende
    }
}