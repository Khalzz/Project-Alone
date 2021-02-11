using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionSwitch : MonoBehaviour
{
    Animation animation;

    void Start()
    {
        animation = this.gameObject.GetComponent<Animation>();
    }
 
    void Update()
    {
        //activar animacion de prender la luza cuando esta accion ocurre
        if(Light.lightTurnsOn == true)
        {
            animation.Play("switch-1-reverse");    
        }
        //activar animacion de apagar la luz cuando esta accion ocurre
        else if (Light.lightTurnsOn == false)
        {
            animation.Play("switch-1");
        }
    }
}