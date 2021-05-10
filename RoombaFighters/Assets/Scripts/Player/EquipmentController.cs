using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentController : MonoBehaviour
{   
    public bool isIA;

    public GameObject arma;

    public GameObject powerUp;
    
    public GameObject soundFire;    
    public GameObject soundKnife;
    public GameObject soundShield;    
    public GameObject soundBoost;

    public void ObtenerArma(GameObject arma){
        if(this.arma!=null){
            this.arma.GetComponent<Arma>().DestroyArma();
            this.arma = null;
        }
        this.arma = Instantiate(arma, transform.position, transform.rotation);
        this.arma.transform.SetParent(gameObject.transform);
    }
    
    public void OnAtacar(){

        if(arma != null){
            arma.GetComponent<Arma>().Atacar();
            if(arma.name=="Pistola(Clone)"){
            	Destroy(Instantiate(soundFire,new Vector3(0, 5, 0),Quaternion.identity),2f);
        	} else {
				Destroy(Instantiate(soundKnife,new Vector3(0, 5, 0),Quaternion.identity),2f);	
			}
        }
    }
    
    public void ObtenerPowerUp(GameObject powerUp){
        if(this.powerUp!=null){
            this.powerUp.GetComponent<PowerUp>().DestroyPowerUp();
            this.powerUp = null;
        }
        this.powerUp = Instantiate(powerUp, transform.position, transform.rotation);
        this.powerUp.transform.SetParent(gameObject.transform);
        if(this.powerUp.GetComponent<PowerUp>().name == "Escudo(Clone)"){
            Destroy(Instantiate(soundShield,new Vector3(0, 5, 0),Quaternion.identity),2f);
        	this.GetComponent<TrashContainer>().isVulnerable = false;
    	} else {
			if(isIA){
		        Destroy(Instantiate(soundBoost,new Vector3(0, 5, 0),Quaternion.identity),2f);
				Debug.Log(this.powerUp.GetComponent<PowerUp>().name);
			} else{
			    Destroy(Instantiate(soundBoost,new Vector3(0, 5, 0),Quaternion.identity),2f);
				this.GetComponent<ThirdPersonController>().boost = 2;
			}
		}
    }
    
	public void Update(){
        if(this.powerUp==null && !isIA){
            this.GetComponent<ThirdPersonController>().boost = 1;
        }
    }
    
}
