using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseState : MonoBehaviour
{

    static public int ending = 0;
    
    static public void changeState(){
        PlayerInteractions.phoneMenuState = true;
    }

    public void endingBackgroundWeigh(){
        ending = 1;
        Debug.Log(ending);
    }

    public void endingBackgroundFault(){
        ending = 2;
        Debug.Log(ending);
    }

    public void turnOffEnding(){
        ending = 3;
        Debug.Log(ending);
    }
}
