using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class colenem : MonoBehaviour
{

    public Animator anim;

    public int lifePoints = 100;

    int deathcount = 0;


    // Update is called once per frame
    void Update()
    {
        if (lifePoints <= 0 && deathcount == 0){
            anim.SetBool("isDead",true);
            deathcount++;
            Destroy(gameObject,5);

           
        }


    }

    private void OnTriggerEnter(Collider other) {
        
        if(other.gameObject.tag == "Espada"){
            lifePoints -= 10;
        }
    }

    
}
