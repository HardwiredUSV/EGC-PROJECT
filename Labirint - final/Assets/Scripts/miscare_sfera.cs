using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miscare_sfera : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float speedH = 2.0f;
    private float yaw = 0.0f;
    public GameObject text;
    // Use this for initialization
    void Start()
    {
         
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            text.SetActive(false);
        }

        //Moves Forward and back along z axis                           //Up/Down
        transform.Translate(Vector3.forward * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
        //Moves Left and right along x Axis                               //Left/Right
        transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);

        yaw += speedH * Input.GetAxis("Mouse X");
        transform.eulerAngles = new Vector3(0, yaw, 0);

        
    }
}

