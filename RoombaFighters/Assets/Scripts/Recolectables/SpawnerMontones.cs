using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMontones : MonoBehaviour
{
    public GameObject prefabMonton;

    public Vector2 minMaxRespawnTimes;
 
    private GameObject montonActivo;

    private bool esperandoSpawn = false;


    void Update(){
        if (montonActivo ==null && !esperandoSpawn){
            StartCoroutine("EsperaSpawn");
        }
    }

    private void Spawn(){
        Vector3 rotacion = new Vector3(0,Random.rotation.y, 0);
        montonActivo = Instantiate(prefabMonton, transform.position, Quaternion.Euler(rotacion));
        montonActivo.transform.SetParent(gameObject.transform);
    }

    IEnumerator EsperaSpawn(){
        esperandoSpawn = true;
        yield return new WaitForSeconds(Random.Range(minMaxRespawnTimes.x, minMaxRespawnTimes.y));
        Spawn();
        esperandoSpawn = false;
    }
}
