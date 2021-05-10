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

    public GameObject arma;
    public GameObject powerUp;
    
    public GameObject soundDash;
    public GameObject soundFire;    
    public GameObject soundKnife;
    public GameObject soundCube;

    public void OnAcelerar(InputValue context){
        vert = context.Get<float>();
    }

    public void OnGirar(InputValue context){
        horiz = context.Get<float>();
    }

    public void OnDash(){
        rb.AddForce(transform.forward * fuerzaDash, ForceMode.Impulse);
        Destroy(Instantiate(soundDash,new Vector3(0, 5, 0),Quaternion.identity),2f);
    }

    public void OnAtacar(){

        if(arma != null){
            arma.GetComponent<Arma>().Atacar();
            if(arma.name=="Pistola(Clone)"){
            	Destroy(Instantiate(soundFire,new Vector3(0, 5, 0),Quaternion.identity),2f);
        	} else {
				Destroy(Instantiate(soundKnife,new Vector3(0, 5, 0),Quaternion.identity),2f);	
			}
        }
    }

 
    void Start()
    {
        freeLook = cinemachine.GetComponent<CinemachineFreeLook>();
    }

    public void ObtenerArma(GameObject arma){
        if(this.arma!=null){
            this.arma.GetComponent<Arma>().DestroyArma();
            this.arma = null;
        }
        Destroy(Instantiate(soundCube,new Vector3(0, 5, 0),Quaternion.identity),2f);
        this.arma = Instantiate(arma, transform.position, transform.rotation);
        this.arma.transform.SetParent(gameObject.transform);
    }
    
    public void ObtenerPowerUp(GameObject powerUp){
        if(this.powerUp!=null){
            this.powerUp.GetComponent<PowerUp>().DestroyPowerUp();
            this.powerUp = null;
        }
        this.powerUp = Instantiate(powerUp, transform.position, transform.rotation);
        this.powerUp.transform.SetParent(gameObject.transform);
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

        if(rb.velocity.magnitude < maxVel && Mathf.Abs(vert) > 0.1f)
			rb.AddForce(transform.forward * aceleracion * vert * Time.fixedDeltaTime*boost);
        	velocidadActual = rb.velocity.magnitude;
    }

}
