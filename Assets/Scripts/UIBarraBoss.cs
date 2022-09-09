using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBarraBoss : MonoBehaviour
{
     public float vidaMaximaBoss = 250f;
    public float vidaActualBoss = 250f;
    public Image barraVidaBoss;

    public GameObject barraCompleta,mensajeFinal,corazonVida;

    private void Update() {

        vidaActualBoss = Boss.unicaInstanciaBoss.vidaBoss; 
        barraVidaBoss.fillAmount = vidaActualBoss / vidaMaximaBoss;

        if( vidaActualBoss <= 0){
            barraCompleta.SetActive(false);
            corazonVida.SetActive(false);
            mensajeFinal.SetActive(true);
            Time.timeScale = 0.5f;
        }

    }
}
