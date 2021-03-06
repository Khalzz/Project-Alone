﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1Animation : MonoBehaviour
{

    Animation animation;
    public static float actualTime = 0f;
    public static float initialTime = 0f;
    public static string time;

    void Start()
    {
        actualTime = initialTime;  
        animation = this.gameObject.GetComponent<Animation>(); 
    }

    void Update() 
    {
        if (PlayerInteractions.doorState == 2) 
        {
            animation.Play("closeDoor");
            actualTime += 1 * Time.deltaTime;
            time = actualTime.ToString("F0");
            if (time == "4") 
            {
                actualTime = 0f;
                PlayerInteractions.theDoorIsOpen = false;
            }
        }
        
        if (PlayerInteractions.doorState == 1)
        {
            animation.Play("openDoor");
            actualTime += 1 * Time.deltaTime;
            time = actualTime.ToString("F0");
            if (time == "3") 
            {
                actualTime = 0f;
                PlayerInteractions.theDoorIsOpen = true;
            }
        }

        
    }
}
