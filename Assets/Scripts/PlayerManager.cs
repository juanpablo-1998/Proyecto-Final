using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class PlayerManager : MonoBehaviour
{
 public static PlayerManager unicaInstanciaVida;

 [SerializeField] UnityEvent onPlayersDeath;
    
    public float vidaJugador = 100;
    void Awake()
    {
        if(PlayerManager.unicaInstanciaVida == null){
            PlayerManager.unicaInstanciaVida = this;
            DontDestroyOnLoad(gameObject); 
        }else{
            Destroy(gameObject);
        }
    }
   
    void Update()
    {
        if(vidaJugador <= 0){

            onPlayersDeath?.Invoke();
        }
    }
}
