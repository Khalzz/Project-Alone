using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionPuertaHabitacion : MonoBehaviour
{

    Animation animation;

    void Start()
    {
        animation = this.gameObject.GetComponent<Animation>(); 
    }

    void Update() 
    {
        if (PlayerRaycasting.theDoorIsClosed == false)
        {
            animation.Play("abrirPuerta");
        }
    }
}
