using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warrior : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float speedH = 2.0f;
    private float yaw = 0.0f;
    public GameObject text;
    public GameObject text2;
    public GameObject text3;
    public Animator animator;
    private float movement = 0f;
    public bool are_arma = false;
    
    
    

    // Use this for initialization
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void FixedUpdate()
    {
        movement = Input.GetAxisRaw("Vertical") * moveSpeed;
        animator.SetFloat("Speed", Mathf.Abs(movement));

        if (animator.GetFloat("Speed")>0.1)
        {
            text.SetActive(false);
        }
 
        //Moves Forward and back along z axis                           //Up/Down
        transform.Translate(Vector3.forward * Time.fixedDeltaTime * Input.GetAxis("Vertical") * moveSpeed);
        
        //Moves Left and right along x Axis                             //Left/Right
        transform.Translate(Vector3.right * Time.fixedDeltaTime * Input.GetAxis("Horizontal") * moveSpeed);
        

        yaw += speedH * Input.GetAxis("Mouse X");
        transform.eulerAngles = new Vector3(0, yaw, 0);


    }

  
}
