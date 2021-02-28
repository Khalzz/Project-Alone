using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondLightTrigger : MonoBehaviour
{
    public int count;
    public GameObject light;
    public AudioSource audio;

    void OnTriggerEnter(Collider other)
    {
        count = count + 1;
        if (count == 1) 
        {
        audio.Play();
        }
        else
        {
            Debug.Log("you cant repeat the sound");
        }
        light.SetActive(true);
    }
}
