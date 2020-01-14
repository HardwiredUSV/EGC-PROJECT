using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    public warrior w;

    

   
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    { 
        if(w.are_arma)
            gameObject.GetComponent<Animator>().Play("Cadere");
        else
        {

        }
    }
}
