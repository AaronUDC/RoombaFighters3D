using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public float tiempoArma = 15.0f;
    public float coolDown = 1.5f;
    public bool atacable = true;
    public GameObject roomba;

    protected virtual void Start(){
        roomba = gameObject.transform.parent.gameObject;
        StartCoroutine("EsperarDestruccion");
    }

    public virtual void Atacar(){}

    public virtual void DestroyArma(){
        roomba.GetComponent<EquipmentController>().arma = null;
        Destroy(gameObject);
    }

    protected IEnumerator EsperarCoolDown(){
        //Debug.Log("Empieza coolDown");
        atacable = false;
        yield return new WaitForSeconds(coolDown);
        atacable = true;
        //Debug.Log("Termina coolDown");
    }

    protected IEnumerator EsperarDestruccion(){
        yield return new WaitForSeconds(tiempoArma);
        DestroyArma();
    }
}