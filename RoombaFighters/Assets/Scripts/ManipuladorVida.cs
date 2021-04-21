using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManipuladorVida : MonoBehaviour
{
    Vida playerVida;

    public int cantidad;
    public float damageTime;
    public bool invencible = false;
    public float tiempo_invencible = 1f;
    public float aux;
    float currentDamageTime;

    // Start is called before the first frame update
    void Start()
    {
        playerVida = GameObject.FindWithTag("Player").GetComponent<Vida>();
    }

    private void OnTriggerStay(Collider other)
    {
	if (other.tag == "Player")
	{
	    currentDamageTime += Time.deltaTime;
	    if (currentDamageTime > damageTime && !invencible)
	    {
	    aux = playerVida.vida;
		playerVida.vida += cantidad;
		if (aux < playerVida.vida)
		{
			Destroy(this.gameObject);
	    	Debug.Log("Curado");
		}
		currentDamageTime = 0.0f;
		StartCoroutine(Invulnerabilidad());
	    }
	}
    }

    IEnumerator Invulnerabilidad()
    {
	invencible = true;
	yield return new WaitForSeconds(tiempo_invencible);
	invencible = false;
    }
}
