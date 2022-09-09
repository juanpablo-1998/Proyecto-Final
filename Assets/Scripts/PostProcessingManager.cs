using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessingManager : MonoBehaviour
{
    public static PostProcessingManager unicaInstancia;

    void Awake()
    {
        if(PostProcessingManager.unicaInstancia == null){
            PostProcessingManager.unicaInstancia = this;
            DontDestroyOnLoad(gameObject); 
        }else{
            Destroy(gameObject);
        }
    }
    public PostProcessVolume volumen; 

    ChromaticAberration chromAberrat; 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        blurrearSegunVida();
    }

    void blurrearSegunVida(){
        volumen.profile.TryGetSettings(out chromAberrat);
        if(PlayerManager.unicaInstanciaVida.vidaJugador < 30){
        chromAberrat.intensity.value = 1;
        }else if(PlayerManager.unicaInstanciaVida.vidaJugador < 50){
            chromAberrat.intensity.value = 0.5f;
        }else{
            chromAberrat.intensity.value = 0;
        }
    }
}
