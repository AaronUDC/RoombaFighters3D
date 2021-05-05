using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorOpciones : MonoBehaviour
{
    public Toggle togleMultijugador;

    public Slider sliderTiempo;

    public Text textoTiempo;

    void Start(){
        CargarConfiguracion();
        UpdateTextoTiempo();  
    }
    public void UpdateTextoTiempo(){
        textoTiempo.text = Mathf.RoundToInt(sliderTiempo.value).ToString("00 ") + "mins";
    }

    public void ConfiguracionPorDefecto(){
        OpcionesJuego.GetInstance().tiempoMinutos = 5;
        OpcionesJuego.GetInstance().multijugador = false;
        CargarConfiguracion();
    }
    public void CargarConfiguracion(){
        sliderTiempo.value = OpcionesJuego.GetInstance().tiempoMinutos;
        togleMultijugador.isOn = OpcionesJuego.GetInstance().multijugador;
    }
    public void UpdateOpciones(){
        OpcionesJuego.GetInstance().tiempoMinutos = Mathf.RoundToInt(sliderTiempo.value);
        OpcionesJuego.GetInstance().multijugador = togleMultijugador.isOn;
    }
}
