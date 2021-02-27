using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondLightTrigger : MonoBehaviour
{
    public GameObject light;
    public AudioSource audio;
    
    void OnTriggerEnter(Collider other)
    {
        audio.Play();
        light.SetActive(true);
    }
}
