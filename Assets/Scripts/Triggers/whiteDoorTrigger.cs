using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whiteDoorTrigger : MonoBehaviour
{
    public GameObject whiteDoor;
    Animation doorAnimations;
    // Start is called before the first frame update
    void Start()
    {
        doorAnimations = whiteDoor.GetComponent<Animation>();
    }

    void OnTriggerEnter(Collider other)
    {
        doorAnimations.Play("openDoor");
    }
}
