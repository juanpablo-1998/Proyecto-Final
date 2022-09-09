
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIMenuPrincipal : MonoBehaviour
{
    public GameObject MenuPrincipal;

    public GameObject MenuCreditos;

    public GameObject MenuControles;

    public void Jugar(){
        SceneManager.LoadScene(1);
    }

    public void Salir(){
        Application.Quit();
    }

    public void Creditos(){

        if(MenuPrincipal.activeInHierarchy == true){
            MenuPrincipal.SetActive(false);
            MenuCreditos.SetActive(true);
        }else{
            MenuPrincipal.SetActive(true);
            MenuCreditos.SetActive(false);
        }

    }

    public void Controles(){

        if(MenuPrincipal.activeInHierarchy == true){
            MenuPrincipal.SetActive(false);
            MenuControles.SetActive(true);
        }else{
            MenuPrincipal.SetActive(true);
            MenuControles.SetActive(false);
        }

    }

    
}
