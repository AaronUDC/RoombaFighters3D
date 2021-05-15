using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

public class ThirdPersonController : MonoBehaviour
{
    
    public float aceleracion;

    public float maxVel;
    public float velocidadActual;
    public float velocidadGiro;
    public float maxTorque;
    public float fuerzaDash;
    public float boost = 1f;
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

    private bool canDash = true;  
    public float dashCooldown = 2.0f;  
    public GameObject soundDash;
    public GameObject soundCube;

    public MenuPausa pausa;

    public void OnAcelerar(InputValue context){
        vert = context.Get<float>();
    }

    public void OnGirar(InputValue context){
        horiz = context.Get<float>();
    }

    public void OnDash(){
        if(canDash){
            rb.AddForce(transform.forward * fuerzaDash, ForceMode.Impulse);
            Destroy(Instantiate(soundDash,new Vector3(0, 5, 0),Quaternion.identity),2f);
            StartCoroutine("DashCooldown");
        }
    }

    public void OnPausa(){
        if(pausa.getEstadoPausa())
            pausa.Reanudar();
        else
            pausa.Pausar();
    }

    private IEnumerator DashCooldown(){
        canDash= false;
        yield return new WaitForSeconds(dashCooldown);
        canDash= true;

    } 

    public void OnAtacar(){
        GetComponent<EquipmentController>().Atacar();
    }

 
    void Start()
    {
        freeLook = cinemachine.GetComponent<CinemachineFreeLook>();
    }

    
    void FixedUpdate()
    {

        Girar();
        Acelerar();
    }

    void Update(){
        GameObject powerUp;
        if((powerUp = GetComponent<EquipmentController>().powerUp)!=null){
            Velocidad velocidadPowerUp;
            powerUp.TryGetComponent<Velocidad>(out velocidadPowerUp);

            if (velocidadPowerUp != null)
                boost = velocidadPowerUp.aumento;
            }else{
                boost = 1.0f;
            }
            
    }
    void Girar(){
        rb.maxAngularVelocity = maxTorque;
        if(Mathf.Abs(horiz) > 0.1){
            //transform.Rotate(new Vector3(0,1,0), velocidadGiro  * horiz * Time.fixedDeltaTime);
            rb.AddTorque(transform.up * velocidadGiro  * horiz * Time.fixedDeltaTime);
        }
    }
    void Acelerar(){

        if(rb.velocity.magnitude < maxVel && Mathf.Abs(vert) > 0.1f)
			rb.AddForce(transform.forward * aceleracion * vert * Time.fixedDeltaTime*boost);
        	velocidadActual = rb.velocity.magnitude;
    }

}
