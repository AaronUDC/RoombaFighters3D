using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public float trashSize = 10;

    private float logSize;
    public float lifeTime = 30;

    // Start is called before the first frame update
    void Start()
    {      
        //Randomizar los tamaños y tiempos de desaparición
        trashSize = Random.Range(6,20);

        lifeTime = Random.Range(20,40);

        logSize = Mathf.Log(trashSize, 10);
        Resize();
        Destroy(gameObject, lifeTime);
    }

    public void Resize(){
        gameObject.transform.localScale = new Vector3(logSize, logSize, logSize);
    }

    void Update(){
        logSize = Mathf.Log10(trashSize);
        Resize();
    }

    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "Player"){
            //Debug.Log("ÑAM");
            col.gameObject.GetComponent<TrashContainer>().AddTrash(trashSize);
            Destroy(gameObject);
        }
    }
}
