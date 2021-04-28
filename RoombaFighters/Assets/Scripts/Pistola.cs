using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistola : Arma
{
    public GameObject bala;
    public GameObject canon;
    // Start is called before the first frame update
    void Start(){
        roomba = gameObject.GetComponentInParent<Transform>().gameObject;
        Duracion();
    }

    public override void Atacar(){
        if(atacable){
            GameObject clon = Instantiate(bala, canon.transform.position, canon.transform.rotation);
            StartCoroutine("EsperarCoolDown");
        }
    }

    public override void Duracion(){
        if(!armaActiva){
            StartCoroutine("DuracionArma");
        }
    }
}