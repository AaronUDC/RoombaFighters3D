using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpRecolectable : MonoBehaviour
{
    public GameObject[] powerUps;

    private void OnTriggerEnter(Collider col){
		if(col.tag == "Player"){
            int i = Random.Range(0, powerUps.Length);
			col.GetComponent<ThirdPersonController>().ObtenerPowerUp(powerUps[i]);
		}
    }

    private void OnTriggerExit(Collider col){
        if(col.tag == "Player"){
            Destroy(gameObject, 0.5f);
        }
    }
}
