using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crystals : MonoBehaviour
{

    public GameObject text1, text2, text3;
    static int nr_cristale=0;
    int lifetime = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void OnTriggerEnter(Collider other)
    {
        nr_cristale++;
        if (nr_cristale == 1)
        {
            text1.SetActive(true);
            Destroy(text1, lifetime);
        }
        if (nr_cristale == 2)
        {
            text2.SetActive(true);
            Destroy(text2, lifetime);
        }
        if (nr_cristale == 3)
        {
            text3.SetActive(true);
            Destroy(text3, lifetime);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
        gameObject.SetActive(false);
        
    }
}
