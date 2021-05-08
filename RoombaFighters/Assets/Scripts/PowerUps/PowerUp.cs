using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float tiempoPowerUp = 10.0f;
    public GameObject roomba;

    protected virtual void Start(){
        roomba = gameObject.transform.parent.gameObject;
        StartCoroutine("EsperarDestruccion");
    }

    public virtual void DestroyPowerUp(){
        roomba.GetComponent<ThirdPersonController>().powerUp = null;
        Destroy(gameObject);
    }

    protected IEnumerator EsperarDestruccion(){
        yield return new WaitForSeconds(tiempoPowerUp);
        DestroyPowerUp();
    }
}