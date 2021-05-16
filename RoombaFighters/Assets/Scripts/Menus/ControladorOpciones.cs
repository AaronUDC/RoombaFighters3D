using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorOpciones : MonoBehaviour
{
    public Toggle togleMultijugador;

    public Slider sliderTiempo;

    public Text textoTiempo;

    public Slider sliderVolumen;

    public Slider sliderGraficos;

    public Text textoGraficos;

    public string[] nivelesGraficos;
    
    void Start(){
        CargarConfiguracionPartida();
        UpdateTextoTiempo();  
        CargarOpcionesJuego();
    }
    
    //Opciones de partida

    public void UpdateTextoTiempo(){
        textoTiempo.text = Mathf.RoundToInt(sliderTiempo.value).ToString("00 ") + "mins";
    }

    public void ConfiguracionPorDefectoPartida(){
        OpcionesJuego.GetInstance().tiempoMinutos = 5;
        OpcionesJuego.GetInstance().multijugador = false;

        CargarConfiguracionPartida();
    }
    public void CargarConfiguracionPartida(){
        sliderTiempo.value = OpcionesJuego.GetInstance().tiempoMinutos;
        togleMultijugador.isOn = OpcionesJuego.GetInstance().multijugador;
    }
    public void UpdateOpcionesPartida(){
        OpcionesJuego.GetInstance().tiempoMinutos = Mathf.RoundToInt(sliderTiempo.value);
        OpcionesJuego.GetInstance().multijugador = togleMultijugador.isOn;
    }

    //Opciones del juego
    public void UpdateVolumen(){
        OpcionesJuego.GetInstance().volumen = sliderVolumen.value;
        AudioListener.volume = sliderVolumen.value;
    }

    public void UpdateTextoGraficos(){
        textoGraficos.text = nivelesGraficos[Mathf.RoundToInt(sliderGraficos.value)];
    }

    public void GuardarOpcionesJuego(){
        PlayerPrefs.SetFloat("Volume", sliderVolumen.value);
        PlayerPrefs.SetInt("GraphicsQuality", Mathf.RoundToInt(sliderGraficos.value));
        QualitySettings.SetQualityLevel(Mathf.RoundToInt(sliderGraficos.value));
    }

    public void CargarOpcionesJuego(){
        if (!PlayerPrefs.HasKey("Volume") || !PlayerPrefs.HasKey("GraphicsQuality")){
            PlayerPrefs.SetFloat("Volume", AudioListener.volume);
            PlayerPrefs.SetInt("GraphicsQuality", QualitySettings.GetQualityLevel());
        } 
        
        sliderVolumen.value = PlayerPrefs.GetFloat("Volume");
        AudioListener.volume = sliderVolumen.value;
        sliderGraficos.value = PlayerPrefs.GetInt("GraphicsQuality");
        QualitySettings.SetQualityLevel(Mathf.RoundToInt(sliderGraficos.value));

        UpdateTextoGraficos();
         
        
    }
}
