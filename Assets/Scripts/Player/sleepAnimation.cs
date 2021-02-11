using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sleepAnimation : MonoBehaviour
{
    Animation animation;
    Animation blinkersAnimation;
    public GameObject blinkers;

    
    public static float actualTime = 0f;
    public static float initialTime = 0f;
    public static string time;

    public static float actualTime2 = 0f;
    public static float initialTime2 = 0f;
    public static string time2;

    void Start()
    {  
        actualTime = initialTime;
        actualTime2 = initialTime2;
        animation = this.gameObject.GetComponent<Animation>(); 
        blinkersAnimation = blinkers.GetComponent<Animation>();
    }

    void Update() 
    {
        if (PlayerRaycasting.sleeping == true) 
        {
            animation.Play("goToSleep");
            CameraMovement.mouseSensibility = 0f;
            actualTime += 1 * Time.deltaTime;
            time = actualTime.ToString("F0");
            actualTime2 += 1 * Time.deltaTime;
            time2 = actualTime2.ToString("F0");
            if (time == "5") 
            {   
                blinkersAnimation.Play("blink");
            }

            if (time == "8") {
                CameraMovement.mouseSensibility = 100f;
                SceneManager.LoadScene("Dream 1");
            }
        }
    }
}