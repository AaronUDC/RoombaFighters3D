using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ThirdPersonController : MonoBehaviour
{
    public float velocidad;
    public float direccionHorizontal;
    
    public Gamepad gamepad = Gamepad.current;

    public Rigidbody rigidbody = null;

    public void Horizontal(InputAction.CallbackContext context){
        Debug.Log("AAAAAAA");
    }

    // Update is called once per frame
    void Update()
    {
        
        rigidbody.AddForce(transform.forward * direccionHorizontal * velocidad *  Time.deltaTime);
        
    }
}
