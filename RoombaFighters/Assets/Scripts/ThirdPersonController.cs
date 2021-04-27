using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

public class ThirdPersonController : MonoBehaviour
{
    
    public float aceleracion;

    public float duration = 0;
    public float maxVel;
    public float velocidadActual;
    public float velocidadGiro;
    public float maxTorque;
    public float fuerzaDash;
    public bool powerUp;
    [Space(10)]
    
    //private float tiempoGiro = 0.1f;
    
    [SerializeField] private float vert;
    [SerializeField] private float horiz;

    //[SerializeField] private Vector2 camGiro;

    public Gamepad gamepad = Gamepad.current;

    public Rigidbody rb;

    public PlayerInput playerInput;

    public GameObject cam;

    public GameObject cinemachine;
 
    private CinemachineFreeLook freeLook;

    public GameObject posicionArmas;

    public void OnAcelerar(InputValue context){
        vert = context.Get<float>();
    }

    public void OnGirar(InputValue context){
        horiz = context.Get<float>();
    }

    /*public void OnControlCamara(InputValue context){
        //freeLook.m_XAxis.m_InputAxisValue = -context.Get<Vector2>().x;
        //freeLook.m_YAxis.m_InputAxisValue = -context.Get<Vector2>().y;
    }*/

    public void OnDash(){
        rb.AddForce(transform.forward * fuerzaDash, ForceMode.Impulse);
    }

    public void OnAtaque(){


    }

 
    void Start()
    {
        freeLook = cinemachine.GetComponent<CinemachineFreeLook>();

        
        
    }

    public void ObtenerArma(GameObject arma){
        GameObject clon = Instantiate(arma, posicionArmas.transform.position , transform.rotation);
        clon.transform.SetParent(posicionArmas.transform);
    }
    
    void FixedUpdate()
    {
        Girar();
        Acelerar();
        /*if (horiz > 0.1f || vert > 0.1f){
            float anguloObjetivo = Mathf.Atan2(direction.x,direction.z) * Mathf.Rad2Deg + cam.transform.eulerAngles.y;

            float angulo = Mathf.SmoothDampAngle(transform.eulerAngles.y, anguloObjetivo,ref velocidadGiro, tiempoGiro);

            transform.rotation = Quaternion.Euler(0f, angulo, 0f);
            
            Vector3 moveDir = Quaternion.Euler(0f,anguloObjetivo,0f) * Vector3.forward;
            rb.AddForce(moveDir.normalized * fuerza * Time.fixedDeltaTime, ForceMode.Force);

        }*/

    }

    void Update(){
        
    }
    void Girar(){
        rb.maxAngularVelocity = maxTorque;
        if(Mathf.Abs(horiz) > 0.1){
            //transform.Rotate(new Vector3(0,1,0), velocidadGiro  * horiz * Time.fixedDeltaTime);
            rb.AddTorque(transform.up * velocidadGiro  * horiz * Time.fixedDeltaTime);
        }
    }
    void Acelerar(){

		if (powerUp){
			duration = duration + Time.deltaTime;
			if (duration >= 10) {
				duration = 0;
				powerUp = false;
			}
		
		}
        if(rb.velocity.magnitude < maxVel && Mathf.Abs(vert) > 0.1f && !powerUp)
            rb.AddForce(transform.forward * aceleracion * vert * Time.fixedDeltaTime);
        else if (rb.velocity.magnitude < maxVel && Mathf.Abs(vert) > 0.1f && powerUp)
            rb.AddForce(transform.forward * aceleracion * vert * Time.fixedDeltaTime * 2);
            
        velocidadActual = rb.velocity.magnitude;
    }

}
