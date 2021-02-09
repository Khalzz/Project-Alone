using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sleepAnimation : MonoBehaviour
{
    Animation animation;

    void Start()
    {  
        animation = this.gameObject.GetComponent<Animation>(); 
    }

    void Update() 
    {
        if (PlayerRaycasting.sleeping == true) 
        {
            Debug.Log("its sleeping");
            animation.Play("goToSleep");
            CameraMovement.mouseSensibility = 0f;
        }
    }
}