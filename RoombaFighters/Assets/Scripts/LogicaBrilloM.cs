using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicaBrilloM : MonoBehaviour
{
	public float sliderValue;
	public Image panelBrillo;
	public ControladorOpciones panelOpciones;
	public LogicaBrillo slide;
	
    // Start is called before the first frame update
    void Start()
    {
        panelBrillo.color = new Color(panelBrillo.color.r,panelBrillo.color.g,panelBrillo.color.b,PlayerPrefs.GetFloat("brillo"));
    }

    // Update is called once per frame
    void Update()
    {
        panelOpciones = GameObject.FindGameObjectWithTag("Options").GetComponent<ControladorOpciones>();
        slide = panelOpciones.GetComponent<LogicaBrillo>();
        panelBrillo.color = new Color(panelBrillo.color.r,panelBrillo.color.g,panelBrillo.color.b,PlayerPrefs.GetFloat("brillo"));
    }
    
}
