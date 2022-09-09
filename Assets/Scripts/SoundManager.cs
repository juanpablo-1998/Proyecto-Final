using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{   
    public static SoundManager unicaInstancia;
    

    void Awake()
    {
        if(SoundManager.unicaInstancia == null){
            SoundManager.unicaInstancia = this;
            DontDestroyOnLoad(gameObject); 
        }else{
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
