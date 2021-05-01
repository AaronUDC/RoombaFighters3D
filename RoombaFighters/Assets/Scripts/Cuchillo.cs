using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuchillo : Arma
{
    public Animator animator;
    // Start is called before the first frame update
    void Start(){
        animator = gameObject.GetComponent<Animator>();
        roomba = gameObject.GetComponentInParent<Transform>().gameObject;
        Duracion();
    }

    public override void Atacar(){
        if(atacable){
            animator.SetTrigger("Atacar");
            StartCoroutine("EsperarCoolDown");
        }
    }

    public override void Duracion(){
        if(!armaActiva){
            StartCoroutine("DuracionArma");
        }
    }

    void OnTriggerEnter(Collider collider){
        if(collider.gameObject.tag == "Player" && collider.gameObject != roomba){
            Debug.Log("Atacado");
        }
    }
}