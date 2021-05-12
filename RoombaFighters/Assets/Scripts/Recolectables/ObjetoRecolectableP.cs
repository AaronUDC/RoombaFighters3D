using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoRecolectableP : MonoBehaviour
{
    public GameObject[] armas;
    public GameObject[] powerUps;


    private void OnTriggerEnter(Collider col){
		if(col.tag == "Player"){
            int j = Random.Range(0,2);
            if (j == 0){
                int i = Random.Range(0, armas.Length);
			    col.GetComponent<EquipmentController>().ObtenerArma(armas[i]);
            }else{
                int i = Random.Range(0, powerUps.Length);
			    col.GetComponent<EquipmentController>().ObtenerPowerUp(powerUps[i]);
            }
		}
    }

    private void OnTriggerExit(Collider col){
        if(col.tag == "Player"){
            Destroy(gameObject, 0.5f);
        }
        
        
    }
}
