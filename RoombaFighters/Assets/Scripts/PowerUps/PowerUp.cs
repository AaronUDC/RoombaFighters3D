using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float tiempoPowerUp = 15.0f;
    public GameObject roomba;
    public GameObject pickUpEffect;

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

    protected void PickUpPowerUp(){
        Instantiate(pickUpEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    public void OnTriggerEnter(Collider collider){
        if(collider.CompareTag("Player")){
            PickUpPowerUp();
        }
    }
}