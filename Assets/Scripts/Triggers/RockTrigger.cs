using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockTrigger : MonoBehaviour
{
    public GameObject rock;
    Animation rockAnimation;
    // Start is called before the first frame update
    void Start()
    {
        rockAnimation = rock.GetComponent<Animation>();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("the rock has fallen");
        rockAnimation.Play("giantRock");
    }
}
