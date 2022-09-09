using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlNiveles : MonoBehaviour
{
    public GameObject gameOver;
    public static ControlNiveles unicaInstancia;


    void Awake()
    {
        if(ControlNiveles.unicaInstancia == null){
            ControlNiveles.unicaInstancia = this;
            DontDestroyOnLoad(gameObject); 
        }else{
            Destroy(gameObject);
        }
    }

    public void Level1to2(){
        SceneManager.LoadScene(2);

    }

     public void Level2to3(){
        SceneManager.LoadScene(3);
     }

    


}
