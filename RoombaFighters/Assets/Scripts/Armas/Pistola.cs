using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistola : Arma
{
    public GameObject bala;
    public GameObject canon;

    public GameObject sonidoAtaque;
    // Start is called before the first frame update
    protected override void Start(){
        base.Start();
    }

    public override void Atacar(){
        if(atacable){
            GameObject clon = Instantiate(bala, canon.transform.position, canon.transform.rotation);
            Destroy(Instantiate(sonidoAtaque,transform.position,transform.rotation), 2.0f);
            StartCoroutine("EsperarCoolDown");
        }
    }
}