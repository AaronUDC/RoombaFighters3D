using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

public class ThirdPersonController : MonoBehaviour
{
    public float fuerza;

    public float velocidadGiro;
    private float tiempoGiro = 0.1f;
    
    [SerializeField] private Vector2 movimiento;

    [SerializeField] private Vector2 camGiro;

    public Gamepad gamepad = Gamepad.current;

    public Rigidbody rb;

    public PlayerInput playerInput;

    public GameObject cam;

    public GameObject cinemachine;
 
    private CinemachineFreeLook freeLook;
    void Awake(){
    }
    public void OnMovimiento(InputValue context){
        movimiento = context.Get<Vector2>();
    }

    public void OnControlCamara(InputValue context){
        freeLook.m_XAxis.m_InputAxisValue = -context.Get<Vector2>().x;
        freeLook.m_YAxis.m_InputAxisValue = -context.Get<Vector2>().y;
    }

 
    void Start()
    {
        freeLook = cinemachine.GetComponent<CinemachineFreeLook>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 direction = new Vector3(movimiento.x,0,movimiento.y).normalized;
        if (direction.magnitude > 0.1f){
            float anguloObjetivo = Mathf.Atan2(direction.x,direction.z) * Mathf.Rad2Deg + cam.transform.eulerAngles.y;

            float angulo = Mathf.SmoothDampAngle(transform.eulerAngles.y, anguloObjetivo,ref velocidadGiro, tiempoGiro);

            transform.rotation = Quaternion.Euler(0f, angulo, 0f);
            
            Vector3 moveDir = Quaternion.Euler(0f,anguloObjetivo,0f) * Vector3.forward;
            rb.AddForce(moveDir.normalized * fuerza * Time.fixedDeltaTime, ForceMode.Force);
        }
    }
}
