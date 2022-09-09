using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIJuego : MonoBehaviour
{
    public Image imagenCorazon;
    public float vidaMaxima = 100f; 

    public float vidaActual;

    public GameObject menuPausa;

    public GameObject uiJuuego;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vidaActual = PlayerManager.unicaInstanciaVida.vidaJugador;
        imagenCorazon.fillAmount = vidaActual / vidaMaxima;

        if(Input.GetKeyDown(KeyCode.Escape)){
            Pausar();
        }

        
        
    }

    public void Pausar(){
        if(menuPausa.activeInHierarchy){
                menuPausa.SetActive(false);
                uiJuuego.SetActive(true);
                Time.timeScale = 1;
            }else{
                menuPausa.SetActive(true);
                uiJuuego.SetActive(false);
                Time.timeScale = 0;
            }
    }

    public void VolverAlMenu(){
        SceneManager.LoadScene(0);
    }



}
