using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public float tiempoArma = 15.0f;
    public float coolDown = 1.5f;
    public bool atacable = true;
    public bool armaActiva = false;
    public GameObject roomba;

    public virtual void Atacar(){}

    public virtual void Duracion(){}

    protected IEnumerator EsperarCoolDown(){
        //Debug.Log("Empieza coolDown");
        atacable = false;
        yield return new WaitForSeconds(coolDown);
        atacable = true;
        //Debug.Log("Termina coolDown");
    }

    protected IEnumerator DuracionArma(){
        Debug.Log("Arma activa");
        armaActiva = true;
        yield return new WaitForSeconds(tiempoArma);
        armaActiva = false;
        Destroy(roomba, 0.5f);
        Debug.Log("Arma inactiva");
    }
}