using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scriptTimer : MonoBehaviour
{
	
	public Text contador;
	public Text fin;
	private float tiempo = 100f;
	
    // Start is called before the first frame update
    void Start()
    {
        contador.text = " " + tiempo;
        fin.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
    	tiempo = tiempo - Time.deltaTime;
    	contador.text = " " + tiempo.ToString("f0");
    	
    	if(tiempo <= 0)
    	{
    		contador.enabled = false;
    		fin.enabled = true;
    		SceneManager.LoadScene("testerCarlos");
		}
        
    }
}
