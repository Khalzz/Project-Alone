using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchAnimation : MonoBehaviour
{
    Animation animation;

    void Start()
    {
        animation = this.gameObject.GetComponent<Animation>();
    }
 
    void Update()
    {
        if(Light.lightTurnsOn == true)
        {
            animation.Play("switch-1-reverse");    
        }
        else if (Light.lightTurnsOn == false)
        {
            animation.Play("switch-1");
        }
    }
}