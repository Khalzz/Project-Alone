using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public static float mouseSensibility = 100f; //sensibilidad basica de camara
    public Transform playerBody; //objeto del jugador

    float rotationX = 0f; //cantidad base de rotacion de camara

    void Start()
    {
            Cursor.lockState = CursorLockMode.Locked; //bloquea el cursor mientras se ejecuta
    }

    void Update()
    {
        //input de eje x camara
        float cameraX = Input.GetAxis("Horizontal View") * mouseSensibility * Time.deltaTime; 
        //input de eje y camara
        float cameraY = Input.GetAxis("Vertical View") * mouseSensibility * Time.deltaTime;
        
        rotationX -= cameraY;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f); //rotacion maxima en eje y

        //rotacion del objeto en base a "rotacionX"
        transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);
        playerBody.Rotate(Vector3.up * cameraX); //rotacion de jugador en base a camara x
    }
}