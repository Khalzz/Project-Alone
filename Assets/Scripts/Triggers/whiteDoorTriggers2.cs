using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whiteDoorTriggers2 : MonoBehaviour
{
    public int count;
    public GameObject whiteDoor;
    Animation doorAnimations;
    public AudioSource phoneAudio;
    // Start is called before the first frame update
    void Start()
    {
        doorAnimations = whiteDoor.GetComponent<Animation>();
    }

    void OnTriggerEnter(Collider other)
    {
        count = count + 1;
        if (count == 1) 
        {
        phoneAudio.Play();
        }
        else
        {
            Debug.Log("you cant repeat the sound");
        }
        doorAnimations.Play("openDoor90");
    }
}
