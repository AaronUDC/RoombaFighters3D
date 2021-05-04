using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinFase : MonoBehaviour
{
	public Text contador;
	private float tiempo = 10f;
    // Start is called before the first frame update
    void Start()
    {
        contador.text = "" + tiempo;
    }

    // Update is called once per frame
    void Update()
    {
        tiempo -= Time.deltaTime;
        contador.text = "" + tiempo.ToString("f0");
        
        if(tiempo <= 0)
        {
			contador.text = "0";
			SceneManager.LoadScene("Victory");
		}
    }
}
