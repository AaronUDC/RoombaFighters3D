using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistola : Arma
{
    public GameObject bala;
    public GameObject canon;
    // Start is called before the first frame update
    protected override void Start(){
        base.Start();
    }

    public override void Atacar(){
        if(atacable){
            GameObject clon = Instantiate(bala, canon.transform.position, canon.transform.rotation);
            StartCoroutine("EsperarCoolDown");
        }
    }
}