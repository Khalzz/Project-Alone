using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionSwitch2 : MonoBehaviour
{
    Animation animation2;

    void Start()
    {
        animation2 = this.gameObject.GetComponent<Animation>(); 
    }

    void Update()
    {
        //activar animacion de prender la luz 2 cuando esta accion ocurre
        if(Light2.lightTurnsOn2 == true)
        {
            animation2.Play("switch-2");    
        }
        //activar animacion de apagar la luz 2 cuando esta accion ocurre
        else if (Light2.lightTurnsOn2 == false)
        {
            animation2.Play("switch-2-reverse");
        }
    }
}