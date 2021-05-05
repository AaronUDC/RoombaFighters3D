using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float lifeTime = 10.0f;
    public float force = 10.0f;

    public Vector2Int minMaxBasura;

    public Vector2Int minMaxVeces;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * force, ForceMode.Impulse);
        Destroy(gameObject, lifeTime);
    }

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Player"){

            int veces = Mathf.RoundToInt(Random.Range(minMaxVeces.x,minMaxVeces.y));

            List<int> cuantities = new List<int>();

            for(int i = 0; i<veces;i++){
                cuantities.Add(Random.Range(minMaxBasura.x,minMaxBasura.y));
            }

            collision.gameObject.GetComponent<TrashContainer>().LooseTrash(cuantities);

        }
        Destroy(gameObject);
    }
}
