using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerRaycasting : MonoBehaviour
{
    static public bool lightState;

    //estados de pausa
    static public bool phoneMenuState = false;
    static public bool pauseMenuState = false;
    //estados de pausa
    
    //objetos de "ui"
    public GameObject pointOfView;
    public GameObject phoneMenu;
    public GameObject eye;
    public GameObject closedEye;
    public TextMeshProUGUI interactionText;
    public TextMeshProUGUI cantSeeText;
    public TextMeshProUGUI closedDoorText;
    public TextMeshProUGUI blockedDoorText;
    public TextMeshProUGUI openDoorText;
    //objetos de "ui"

    //reparacion bug textoInteraccion
    public float startTime = 0f;
    //reparacion bug textoInteraccion

    public float viewDistance = 1f;
    public Transform obectPlayerRadio;
    static public RaycastHit switchLight;
    static public RaycastHit cellPhone;
    static public RaycastHit switchPostItsRc;
    static public RaycastHit fridgePostItRc;
    static public RaycastHit secondPostItsRc;
    static public RaycastHit thirdPostItsRc;
    static public RaycastHit lastPostItsRc;
    static public RaycastHit closedDoorRc;
    static public RaycastHit blockedDoorRc;
    static public RaycastHit openDoorRc;

    //switch 1
    public LayerMask lightSwitch;
    static public bool itsTouchingTheSwitch;
    static public bool touchTheSwitch;

    //switch 2
    public LayerMask lightSwitch2;
    static public bool itsTouchingTheSwitch2;
    static public bool touchTheSwitch2;

    //Celular
    public LayerMask phone;
    static public bool itsTouchingThePhone;
    static public bool touchThePhone;

    //Post-it
    public LayerMask switchPostIts;
    static public bool itsTouchingTheSwitchPostIts;
    static public bool touchTheSwitchPostIts;
    public GameObject switchPostItsMenu;
    static public bool switchPostItMenuState = false;

    public LayerMask fridgePostIt;
    static public bool itsTouchingTheFridgePostIt;
    static public bool touchTheFridgePostIt;
    public GameObject fridgePostItsMenu;
    static public bool fridgePostItMenuState = false;

    public LayerMask secondPostIts;
    static public bool itsTouchingTheSecondPostIts;
    static public bool touchTheSecondPostIts;
    public GameObject secondPostItsMenu;
    static public bool secondPostItMenuState = false;
    
    public LayerMask thirdPostIts;
    static public bool itsTouchingTheThirdPostIts;
    static public bool touchTheThirdPostIts;
    public GameObject thirdPostItsMenu;
    static public bool thirdPostItMenuState = false;
    
    public LayerMask lastPostIts;
    static public bool itsTouchingTheLastPostIts;
    static public bool touchTheLastPostIts;
    public GameObject lastPostItsMenu;
    static public bool lastPostItMenuState = false;

    //doors
    public LayerMask closedDoor;
    static public bool itsTouchingTheClosedDoor;
    static public bool touchTheClosedDoor;

    public LayerMask blockedDoor;
    static public bool itsTouchingTheBlockedDoor;
    static public bool touchTheBlockedDoor;

    public LayerMask openDoor;
    static public bool itsTouchingTheOpenDoor;
    static public bool touchTheOpenDoor;

    void Start()
    { 
        eye.SetActive(false);
        closedEye.SetActive(false);
        cantSeeText.color = new Color32(255,255,255,0);
        closedDoorText.color = new Color32(255,255,255,0);
        blockedDoorText.color = new Color32(255,255,255,0);
        openDoorText.color = new Color32(255,255,255,0);

        switchPostItsMenu.SetActive(false);
        fridgePostItsMenu.SetActive(false);
        secondPostItsMenu.SetActive(false);
        thirdPostItsMenu.SetActive(false);
        lastPostItsMenu.SetActive(false);

        
    }

    void Update()
    {
        Debug.DrawRay(this.transform.position, this.transform.forward * viewDistance, Color.magenta);

        itsTouchingTheSwitch = Physics.CheckSphere(obectPlayerRadio.position, 0.8f, lightSwitch);
        itsTouchingTheSwitch2 = Physics.CheckSphere(obectPlayerRadio.position, 0.8f, lightSwitch2);

        itsTouchingThePhone = Physics.CheckSphere(obectPlayerRadio.position, 1f, phone);

        itsTouchingTheSwitchPostIts = Physics.CheckSphere(obectPlayerRadio.position, 1f, switchPostIts);
        itsTouchingTheFridgePostIt = Physics.CheckSphere(obectPlayerRadio.position, 1f, fridgePostIt);
        itsTouchingTheSecondPostIts = Physics.CheckSphere(obectPlayerRadio.position, 1f, secondPostIts);
        itsTouchingTheThirdPostIts = Physics.CheckSphere(obectPlayerRadio.position, 1f, thirdPostIts);
        itsTouchingTheLastPostIts = Physics.CheckSphere(obectPlayerRadio.position, 1f, lastPostIts);

        itsTouchingTheClosedDoor = Physics.CheckSphere(obectPlayerRadio.position, 1f, closedDoor);
        itsTouchingTheBlockedDoor = Physics.CheckSphere(obectPlayerRadio.position, 1f, blockedDoor);
        itsTouchingTheOpenDoor = Physics.CheckSphere(obectPlayerRadio.position, 1f, openDoor);

        touchTheSwitch = Physics.Raycast(this.transform.position, this.transform.forward, out switchLight, viewDistance,lightSwitch);  
        touchTheSwitch2 = Physics.Raycast(this.transform.position, this.transform.forward, out switchLight, viewDistance,lightSwitch2);  

        touchThePhone = Physics.Raycast(this.transform.position, this.transform.forward, out cellPhone, 2, phone);  

        touchTheSwitchPostIts = Physics.Raycast(this.transform.position, this.transform.forward, out switchPostItsRc, 2, switchPostIts);  
        touchTheFridgePostIt = Physics.Raycast(this.transform.position, this.transform.forward, out fridgePostItRc, 2, fridgePostIt);  
        touchTheSecondPostIts = Physics.Raycast(this.transform.position, this.transform.forward, out secondPostItsRc, 2, secondPostIts);  
        touchTheThirdPostIts = Physics.Raycast(this.transform.position, this.transform.forward, out thirdPostItsRc, 2, thirdPostIts);  
        touchTheLastPostIts = Physics.Raycast(this.transform.position, this.transform.forward, out lastPostItsRc, 2, lastPostIts);  

        touchTheClosedDoor = Physics.Raycast(this.transform.position, this.transform.forward, out closedDoorRc, 2, closedDoor);  
        touchTheBlockedDoor = Physics.Raycast(this.transform.position, this.transform.forward, out blockedDoorRc, 2, blockedDoor);  
        touchTheOpenDoor = Physics.Raycast(this.transform.position, this.transform.forward, out openDoorRc, 2, openDoor);  
        
        //iteractuables
        if(touchTheSwitchPostIts == true && itsTouchingTheSwitchPostIts == true)
        {
            verify();
            if (Input.GetButtonDown("Action") && switchPostItMenuState == false)
            {
                openSwitch();
            }
            
        }
        else if (touchTheFridgePostIt == true && itsTouchingTheFridgePostIt == true) 
        {
            verify();
            if (Input.GetButtonDown("Action") && fridgePostItMenuState == false)
            {
                openFridge();
            }
            
        }
        else if (touchTheSecondPostIts == true && itsTouchingTheSecondPostIts == true) 
        {
            verify();
            if (Input.GetButtonDown("Action") && secondPostItMenuState == false)
            {
                openSecond();
            }
            
        }
        else if (touchTheThirdPostIts == true && itsTouchingTheThirdPostIts == true) 
        {
            verify();
            if (Input.GetButtonDown("Action") && thirdPostItMenuState == false)
            {
                openThird();
            }
            
        }
        else if (touchTheLastPostIts == true && itsTouchingTheLastPostIts == true) 
        {
            verify();
            if (Input.GetButtonDown("Action") && lastPostItMenuState == false)
            {
                openLast();
            }
            
        }
        else
        {
            eye.SetActive(false);
            closedEye.SetActive(false);
            pointOfView.SetActive(true);
            cantSeeText.color = new Color32(255,255,255,0);
        }

        if (touchTheClosedDoor == true && itsTouchingTheClosedDoor == true) 
        {
            closedDoorText.color = new Color32(255,255,255,255);
            blockedDoorText.color = new Color32(255,255,255,0);
            openDoorText.color = new Color32(255,255,255,0);
        }
        else if (touchTheBlockedDoor == true && itsTouchingTheBlockedDoor == true) 
        {
            closedDoorText.color = new Color32(255,255,255,0);
            blockedDoorText.color = new Color32(255,255,255,255);
            openDoorText.color = new Color32(255,255,255,0); 
        }
        else if (touchTheOpenDoor == true && itsTouchingTheOpenDoor == true) 
        {
            closedDoorText.color = new Color32(255,255,255,0);
            blockedDoorText.color = new Color32(255,255,255,0);
            openDoorText.color = new Color32(255,255,255,255); 
        }
        else
        {
            closedDoorText.color = new Color32(255,255,255,0);
            blockedDoorText.color = new Color32(255,255,255,0);
            openDoorText.color = new Color32(255,255,255,0); 
        } 

        if(touchThePhone == true && itsTouchingThePhone == true)
        {
            interactionText.color = new Color32(255,255,255,255);
            if (Input.GetButtonDown("Action") && phoneMenuState == false)
            {
                Time.timeScale = 0f;
                phoneMenu.SetActive(true);
                pointOfView.SetActive(false);
                interactionText.color = new Color32(255,255,255,0);
                Cursor.lockState = CursorLockMode.None;
                phoneMenuState = true;
                //menu celular activado

                //abrir celular, no hace falta hacer otra cosa
                //permitir cambiar de opinion      
            } 
        }
        else if(touchTheSwitch == true && itsTouchingTheSwitch == true)
        {
            interactionText.color = new Color32(255,255,255,255);
        }
        else if(touchTheSwitch2 == true && itsTouchingTheSwitch2 == true)
        {
            interactionText.color = new Color32(255,255,255,255);
        }
        else
        {
            interactionText.color = new Color32(255,255,255,0);
        }
        //interactuables
        
        //cerrar menu celular
        if (Input.GetButtonDown("Escape") && phoneMenuState == true){
            Time.timeScale = 1f;
            phoneMenu.SetActive(false);
            pointOfView.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            phoneMenuState = false;
        }
        //cerrar menu celular
    }

    void openSwitch() 
    {
        Time.timeScale = 0f;
        switchPostItsMenu.SetActive(true);
        pointOfView.SetActive(false);
        eye.SetActive(false);

        cantSeeText.color = new Color32(255,255,255,0);
        closedDoorText.color = new Color32(255,255,255,0);
        blockedDoorText.color = new Color32(255,255,255,0);
        openDoorText.color = new Color32(255,255,255,0); 

        Cursor.lockState = CursorLockMode.None;
        switchPostItMenuState = true;
        pauseMenuState = true;
    }

    void openFridge() 
    {
        Time.timeScale = 0f;
        fridgePostItsMenu.SetActive(true);
        pointOfView.SetActive(false);
        eye.SetActive(false);

        cantSeeText.color = new Color32(255,255,255,0);
        closedDoorText.color = new Color32(255,255,255,0);
        blockedDoorText.color = new Color32(255,255,255,0);
        openDoorText.color = new Color32(255,255,255,0); 

        Cursor.lockState = CursorLockMode.None;
        switchPostItMenuState = true;
        pauseMenuState = true;
    }

    void openSecond() 
    {
        Time.timeScale = 0f;
        secondPostItsMenu.SetActive(true);
        pointOfView.SetActive(false);
        eye.SetActive(false);

        cantSeeText.color = new Color32(255,255,255,0);
        closedDoorText.color = new Color32(255,255,255,0);
        blockedDoorText.color = new Color32(255,255,255,0);
        openDoorText.color = new Color32(255,255,255,0); 

        Cursor.lockState = CursorLockMode.None;
        secondPostItMenuState = true;
        pauseMenuState = true;
    }
    
    void openThird() 
    {
        Time.timeScale = 0f;
        thirdPostItsMenu.SetActive(true);
        pointOfView.SetActive(false);
        eye.SetActive(false);

        cantSeeText.color = new Color32(255,255,255,0);
        closedDoorText.color = new Color32(255,255,255,0);
        blockedDoorText.color = new Color32(255,255,255,0);
        openDoorText.color = new Color32(255,255,255,0); 

        Cursor.lockState = CursorLockMode.None;
        thirdPostItMenuState = true;
        pauseMenuState = true;
    }
    
    void openLast() 
    {
        Time.timeScale = 0f;
        lastPostItsMenu.SetActive(true);
        pointOfView.SetActive(false);
        eye.SetActive(false);

        cantSeeText.color = new Color32(255,255,255,0);
        closedDoorText.color = new Color32(255,255,255,0);
        blockedDoorText.color = new Color32(255,255,255,0);
        openDoorText.color = new Color32(255,255,255,0); 

        Cursor.lockState = CursorLockMode.None;
        lastPostItMenuState = true;
        pauseMenuState = true;
    }

    void menuExit() 
    {
        Time.timeScale = 1f;
        phoneMenu.SetActive(false);
        switchPostItsMenu.SetActive(false);
        fridgePostItsMenu.SetActive(false);
        secondPostItsMenu.SetActive(false);
        thirdPostItsMenu.SetActive(false);
        lastPostItsMenu.SetActive(false);
        pointOfView.SetActive(true); 
        Cursor.lockState = CursorLockMode.Locked;
    }

    void verify() 
    {
        if (Light.state == true) 
        {
            cantSeeText.color = new Color32(255,255,255,0);
            eye.SetActive(true);
            closedEye.SetActive(false);
            pointOfView.SetActive(false);
            if (Input.GetButtonDown("Action") && switchPostItMenuState == false)
            {
                openSwitch();
            }
            if (Input.GetButtonDown("Action") && fridgePostItMenuState == false)
            {
                openFridge();
            }
            if (Input.GetButtonDown("Action") && secondPostItMenuState == false)
            {
                openSecond();
            }
            if (Input.GetButtonDown("Action") && thirdPostItMenuState == false)
            {
                openThird();
            }
            if (Input.GetButtonDown("Action") && lastPostItMenuState == false)
            {
                openLast();
            }
            if (Input.GetButtonDown("Escape") && pauseMenuState == true)
            {
                menuExit();
            }
        }
        else if (Light.state == false) 
        {
            cantSeeText.color = new Color32(255,255,255,255);
            eye.SetActive(false);
            closedEye.SetActive(true);
            pointOfView.SetActive(false);
        }
        
        if (pauseMenuState == true) 
        {
            eye.SetActive(false);
            closedEye.SetActive(false);
            cantSeeText.color = new Color32(255,255,255,0);
            closedDoorText.color = new Color32(255,255,255,0);
            blockedDoorText.color = new Color32(255,255,255,0);
            openDoorText.color = new Color32(255,255,255,0); 
        }
    }
}