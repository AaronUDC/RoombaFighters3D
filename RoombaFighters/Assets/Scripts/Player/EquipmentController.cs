using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentController : MonoBehaviour
{   
    public bool isIA;

    public GameObject arma;

    public GameObject powerUp;

    public void ObtenerArma(GameObject arma){
        if(this.arma!=null){
            this.arma.GetComponent<Arma>().DestroyArma();
            this.arma = null;
        }
        this.arma = Instantiate(arma, transform.position, transform.rotation);
        this.arma.transform.SetParent(gameObject.transform);
    }


    public void ObtenerPowerUp(GameObject powerUp){
        if(this.powerUp!=null){
            this.powerUp.GetComponent<PowerUp>().DestroyPowerUp();
            this.powerUp = null;
        }
        this.powerUp = Instantiate(powerUp, transform.position, transform.rotation);
        this.powerUp.transform.SetParent(gameObject.transform);
    }

    public void Atacar(){
        if(arma != null){
            arma.GetComponent<Arma>().Atacar();
        }
    }
    
    /*
	public void Update(){
        if(this.powerUp==null && !isIA){
            this.GetComponent<ThirdPersonController>().boost = 1;
        }
    }
    */
}
