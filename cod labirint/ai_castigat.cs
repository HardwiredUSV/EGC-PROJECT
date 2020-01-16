using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ai_castigat : MonoBehaviour
{
    public GameObject text2;
    void Start()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        text2.SetActive(true);
    }
}
