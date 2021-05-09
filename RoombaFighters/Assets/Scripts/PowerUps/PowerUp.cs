using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float tiempoPowerUp = 15.0f;
    public float coolDown = 1.5f;
    public bool atacable = true;
    public float boost = 2f;
    public GameObject roomba;

    protected virtual void Start(){
        roomba = gameObject.transform.parent.gameObject;
        StartCoroutine("EsperarDestruccion");
    }
    
    public virtual float Aumento(){
		return boost;
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
