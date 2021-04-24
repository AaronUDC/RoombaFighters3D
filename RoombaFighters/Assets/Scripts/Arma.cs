using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public float tiempoActivo = 20.0f;
    public float coolDown = 5.0f;
    public bool atacable = true;
    public GameObject roomba;

    public virtual void Atacar(){}

    protected IEnumerator EsperarCoolDown(){
        //Debug.Log("Empieza cooldn");
        atacable = false;
        yield return new WaitForSeconds(coolDown);
        atacable = true;
        //Debug.Log("term cooldn");
    }
}