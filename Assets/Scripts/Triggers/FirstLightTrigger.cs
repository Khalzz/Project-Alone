using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstLightTrigger : MonoBehaviour
{
    public GameObject light;
    public AudioSource audio;

    void OnTriggerEnter(Collider other)
    {
        audio.Play();
        light.SetActive(true);
    }
}
