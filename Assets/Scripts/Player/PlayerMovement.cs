using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform footPosition; //objeto pies
    Vector3 velocity; //vector de velocidad
    public CharacterController controller; //llamamos el componente Character controller
    public LayerMask floor; //layer que represente el suelo
    
    public float speed; //por defecto esta en 3 
    public float gravity = -39.24f; //variable gravedad (-9.81f base)(-39.24 recomendado)    
    public float footRadio = 0.4f; //radio de comprobacion pies
    bool itsInTheFloor; //esta tocando el suelo?

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        itsInTheFloor = Physics.CheckSphere(footPosition.position, footRadio, floor);

        if(itsInTheFloor && velocity.y < 0)
        {
            velocity.y = -2f;
        }
	
        velocity.y += gravity = -39.24f * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}