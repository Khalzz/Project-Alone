using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionPuertaHabitacion : MonoBehaviour
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
        if (PlayerRaycasting.doorState == 2) 
        {
            Debug.Log("algo paso :o");
            animation.Play("closeDoor");
            actualTime += 1 * Time.deltaTime;
            time = actualTime.ToString("F0");
            if (time == "4") 
            {
                actualTime = 0f;
                PlayerRaycasting.theDoorIsOpen = false;
            }
        }
        
        if (PlayerRaycasting.doorState == 1)
        {
            animation.Play("abrirPuerta");
            actualTime += 1 * Time.deltaTime;
            time = actualTime.ToString("F0");
            if (time == "3") 
            {
                actualTime = 0f;
                PlayerRaycasting.theDoorIsOpen = true;
            }
        }

        
    }
}
