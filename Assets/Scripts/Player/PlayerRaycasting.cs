using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerRaycasting : MonoBehaviour
{

    //estados de pausa
    static public bool phoneMenuState = false;
    //estados de pausa
    
    //objetos de "ui"
    public GameObject pointOfView;
    public GameObject phoneMenu;
    public TextMeshProUGUI interactionText;
    //objetos de "ui"

    //reparacion bug textoInteraccion
    public float startTime = 0f;
    //reparacion bug textoInteraccion

    public float viewDistance = 1f;
    public Transform obectPlayerRadio;
    static public RaycastHit switchLight;
    static public RaycastHit cellPhone;
    static public RaycastHit switchPostItsRc;


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

    void Start()
    { 
    }

    void Update()
    {
        itsTouchingTheSwitch = Physics.CheckSphere(obectPlayerRadio.position, 0.8f, lightSwitch);
        itsTouchingTheSwitch2 = Physics.CheckSphere(obectPlayerRadio.position, 0.8f, lightSwitch2);
        itsTouchingThePhone = Physics.CheckSphere(obectPlayerRadio.position, 1f, phone);
        itsTouchingTheSwitchPostIts = Physics.CheckSphere(obectPlayerRadio.position, 1f, switchPostIts);

        Debug.DrawRay(this.transform.position, this.transform.forward * viewDistance, Color.magenta);

        touchTheSwitch = Physics.Raycast(this.transform.position, this.transform.forward, out switchLight, viewDistance,lightSwitch);  
        touchTheSwitch2 = Physics.Raycast(this.transform.position, this.transform.forward, out switchLight, viewDistance,lightSwitch2);  
        touchThePhone = Physics.Raycast(this.transform.position, this.transform.forward, out cellPhone, 2, phone);  
        touchTheSwitchPostIts = Physics.Raycast(this.transform.position, this.transform.forward, out switchPostItsRc, 2, switchPostIts);  
        
        //iteractuables
        if(touchTheSwitchPostIts == true && itsTouchingTheSwitchPostIts == true)
        {
            Debug.Log("you are touching the switch post its");
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
}