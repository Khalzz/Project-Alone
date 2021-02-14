using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch2Animation : MonoBehaviour
{
    Animation animation2;

    void Start()
    {
        animation2 = this.gameObject.GetComponent<Animation>(); 
    }

    void Update()
    {
        if(Light2.lightTurnsOn2 == true)
        {
            animation2.Play("switch-2");    
        }
        else if (Light2.lightTurnsOn2 == false)
        {
            animation2.Play("switch-2-reverse");
        }
    }
}