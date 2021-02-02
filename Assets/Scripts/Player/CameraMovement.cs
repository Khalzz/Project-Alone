using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float sensibilidadMouse = 100f; //sensibilidad basica de camara
    public Transform cuerpoJugador; //objeto del jugador

    float rotacionX = 0f; //cantidad base de rotacion de camara

    void Start()
    {
            Cursor.lockState = CursorLockMode.Locked; //bloquea el cursor mientras se ejecuta
    }

    void Update()
    {
        //input de eje x camara
        float camaraX = Input.GetAxis("Horizontal View") * sensibilidadMouse * Time.deltaTime; 
        //input de eje y camara
        float camaraY = Input.GetAxis("Vertical View") * sensibilidadMouse * Time.deltaTime;
        
        rotacionX -= camaraY;
        rotacionX = Mathf.Clamp(rotacionX, -90f, 90f); //rotacion maxima en eje y

        //rotacion del objeto en base a "rotacionX"
        transform.localRotation = Quaternion.Euler(rotacionX, 0f, 0f);
        cuerpoJugador.Rotate(Vector3.up * camaraX); //rotacion de jugador en base a camara x
    }
}