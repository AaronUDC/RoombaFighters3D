using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrashContainer : MonoBehaviour
{
    public int trashLevel;

    public GameObject trashPrefab;

    public float invulnerabilityTime = 5;

    public bool isVulnerable = true;

    public float spawnRadius;
    public float spawnHeight;

    public Vector2 MinMaxExplosionForce;

    
    public AnimationClip invulnerabilityAnim;

    public Text textUI;
    public Image trashMeterUI;


    void Update(){
        UpdateUI();
    }



    public void AddTrash(int trashSize){
        trashLevel += trashSize;
        UpdateUI();
    }

    IEnumerator Invulnerability(){
        isVulnerable = false;
        
        Animation anim = gameObject.GetComponent<Animation>();
        anim.AddClip(invulnerabilityAnim,"Invulnerability");
        anim.Play();

        yield return new WaitForSeconds(invulnerabilityTime);

        anim.RemoveClip(invulnerabilityAnim);
        isVulnerable = true;
    }

    public void LooseTrash(List<int> cuantities){
        if(isVulnerable){
            //SpawnTrash(cuantity);
            foreach(int cuantity in cuantities){
                int loss;
                if(trashLevel > cuantity){
                    trashLevel -= cuantity;
                    loss = cuantity;
                }else{
                    loss = trashLevel;
                    trashLevel = 0;
                }
                if(loss>0){
                    SpawnTrash(loss);
                }
            }
            UpdateUI();
            StartCoroutine("Invulnerability");
        }
    }

    private void SpawnTrash(int cuantity){
        //Spawn de una unidad de basura que se lanza en una dirección aleatoria
        float angle = Random.Range(0,360);
        Vector3 spawnPos = new Vector3();
        spawnPos.x = transform.position.x + spawnRadius * Mathf.Sin(angle * Mathf.Deg2Rad);
        spawnPos.z = transform.position.z + spawnRadius * Mathf.Cos(angle * Mathf.Deg2Rad);
        spawnPos.y = transform.position.y + spawnHeight;


        GameObject clone = Instantiate(trashPrefab,spawnPos, Random.rotation);
        
        clone.GetComponent<Trash>().trashSize = cuantity;
        clone.GetComponent<Trash>().Resize();
        
        clone.GetComponent<Rigidbody>().AddExplosionForce(Random.Range(MinMaxExplosionForce.x,MinMaxExplosionForce.y), transform.position, spawnRadius*2, -spawnHeight, ForceMode.Impulse);
    }

    void UpdateUI(){
        float logSize = Mathf.Log(1+ trashLevel,2);
        textUI.text = trashLevel + "";
        trashMeterUI.transform.localScale = new Vector3(logSize, logSize, logSize);
    }
}
