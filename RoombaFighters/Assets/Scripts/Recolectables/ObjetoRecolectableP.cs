using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoRecolectableP : MonoBehaviour
{
    public GameObject[] armas;

    private void OnTriggerEnter(Collider col){
		if(col.tag == "Player"){
            int i = Random.Range(0, armas.Length);
			col.GetComponent<EquipmentController>().ObtenerPowerUp(armas[i]);
		}
    }

    private void OnTriggerExit(Collider col){
        if(col.tag == "Player"){
            Destroy(gameObject, 0.5f);
        }
        
        
    }
}
