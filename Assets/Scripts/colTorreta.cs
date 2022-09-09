using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colTorreta : MonoBehaviour
{

    public int lifePoints = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        chequearSiVive();
    }

    private void OnTriggerEnter(Collider other) {
        
        if(other.gameObject.tag == "Espada"){
            lifePoints -= 20;
        }
    }

    void chequearSiVive(){
        if(lifePoints<=0){
            Destroy(gameObject);
        }
    }

}
