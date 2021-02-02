using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform posicionPies; //objeto pies
    Vector3 velocidad; //vector de velocidad
    public CharacterController controller; //llamamos el componente Character controller
    public LayerMask Suelo; //layer que represente el suelo
    
    public float speed; //por defecto esta en 3 
    public float gravedad; //variable gravedad (-9.81f base)(-39.24 recomendado)    
    public float radioPies = 0.4f; //radio de comprobacion pies
    bool estaEnElSuelo; //esta tocando el suelo?

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal"); //input horizontal (teclado y joystick)
        float z = Input.GetAxis("Vertical"); //input vertical (teclado y joystick)

        Vector3 move = transform.right * x + transform.forward * z; // creamos el movimiento

        controller.Move(move * speed * Time.deltaTime);	//ejecutamos el movimiento

            //esta tocando el suelo?
        estaEnElSuelo = Physics.CheckSphere(posicionPies.position, radioPies, Suelo);

        //si esta en el suelo y la velocidad es menor a 0
        if(estaEnElSuelo && velocidad.y < 0)
        {
            //la velocidad del eje y sera -2f
            velocidad.y = -2f;
        }
	
        //ajustar valor de velocidad.y
        velocidad.y += gravedad * Time.deltaTime;
        //ejecutamos la "gravedad" cuando sea necesario
        controller.Move(velocidad * Time.deltaTime);
    }
}