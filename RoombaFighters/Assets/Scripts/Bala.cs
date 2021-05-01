using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float lifeTime = 10.0f;
    public float force = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * force, ForceMode.Impulse);
        Destroy(gameObject, lifeTime);
    }

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Player"){
            Destroy(gameObject);
            Debug.Log("Impacto de bala");
        }
        Destroy(gameObject);
    }
}
