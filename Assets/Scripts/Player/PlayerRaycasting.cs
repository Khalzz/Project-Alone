using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerRaycasting : MonoBehaviour
{
    static public bool lightState;

    //estados de pausa
    static public bool phoneMenuState = false;
    //estados de pausa
    
    //objetos de "ui"
    public GameObject pointOfView;
    public GameObject phoneMenu;
    public GameObject eye;
    public GameObject closedEye;
    public TextMeshProUGUI interactionText;
    public TextMeshProUGUI cantSeeText;
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

    public LayerMask fridgePostIt;
    static public bool itsTouchingTheFridgePostIt;
    static public bool touchTheFridgePostIt;

    public LayerMask secondPostIts;
    static public bool itsTouchingTheSecondPostIts;
    static public bool touchTheSecondPostIts;
    
    public LayerMask thirdPostIts;
    static public bool itsTouchingTheThirdPostIts;
    static public bool touchTheThirdPostIts;
    
    public LayerMask lastPostIts;
    static public bool itsTouchingTheLastPostIts;
    static public bool touchTheLastPostIts;

    void Start()
    { 
        eye.SetActive(false);
        cantSeeText.color = new Color32(255,255,255,0);
    }

    void Update()
    {
        itsTouchingTheSwitch = Physics.CheckSphere(obectPlayerRadio.position, 0.8f, lightSwitch);
        itsTouchingTheSwitch2 = Physics.CheckSphere(obectPlayerRadio.position, 0.8f, lightSwitch2);
        itsTouchingThePhone = Physics.CheckSphere(obectPlayerRadio.position, 1f, phone);
        itsTouchingTheSwitchPostIts = Physics.CheckSphere(obectPlayerRadio.position, 1f, switchPostIts);
        itsTouchingTheFridgePostIt = Physics.CheckSphere(obectPlayerRadio.position, 1f, fridgePostIt);
        itsTouchingTheSecondPostIts = Physics.CheckSphere(obectPlayerRadio.position, 1f, secondPostIts);
        itsTouchingTheThirdPostIts = Physics.CheckSphere(obectPlayerRadio.position, 1f, thirdPostIts);
        itsTouchingTheLastPostIts = Physics.CheckSphere(obectPlayerRadio.position, 1f, lastPostIts);

        Debug.DrawRay(this.transform.position, this.transform.forward * viewDistance, Color.magenta);

        touchTheSwitch = Physics.Raycast(this.transform.position, this.transform.forward, out switchLight, viewDistance,lightSwitch);  
        touchTheSwitch2 = Physics.Raycast(this.transform.position, this.transform.forward, out switchLight, viewDistance,lightSwitch2);  
        touchThePhone = Physics.Raycast(this.transform.position, this.transform.forward, out cellPhone, 2, phone);  
        touchTheSwitchPostIts = Physics.Raycast(this.transform.position, this.transform.forward, out switchPostItsRc, 2, switchPostIts);  
        touchTheFridgePostIt = Physics.Raycast(this.transform.position, this.transform.forward, out fridgePostItRc, 2, fridgePostIt);  
        touchTheSecondPostIts = Physics.Raycast(this.transform.position, this.transform.forward, out secondPostItsRc, 2, secondPostIts);  
        touchTheThirdPostIts = Physics.Raycast(this.transform.position, this.transform.forward, out thirdPostItsRc, 2, thirdPostIts);  
        touchTheLastPostIts = Physics.Raycast(this.transform.position, this.transform.forward, out lastPostItsRc, 2, lastPostIts);  
        
        //iteractuables
        if(touchTheSwitchPostIts == true && itsTouchingTheSwitchPostIts == true)
        {
            verify();

        }
        else if (touchTheFridgePostIt == true && itsTouchingTheFridgePostIt == true) 
        {
            verify();

        }
        else if (touchTheSecondPostIts == true && itsTouchingTheSecondPostIts == true) 
        {
            verify();

        }
        else if (touchTheThirdPostIts == true && itsTouchingTheThirdPostIts == true) 
        {
            verify();

        }
        else if (touchTheLastPostIts == true && itsTouchingTheLastPostIts == true) 
        {
            verify();
        }
        else
        {
            eye.SetActive(false);
            closedEye.SetActive(false);
            pointOfView.SetActive(true);
            cantSeeText.color = new Color32(255,255,255,0);
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

    void verify() 
    {
        if (Light.state == true) 
            {
                cantSeeText.color = new Color32(255,255,255,0);
                eye.SetActive(true);
                closedEye.SetActive(false);
                pointOfView.SetActive(false);
            }
            else if (Light.state == false) 
            {
                cantSeeText.color = new Color32(255,255,255,255);
                eye.SetActive(false);
                closedEye.SetActive(true);
                pointOfView.SetActive(false);
            }
    }
}