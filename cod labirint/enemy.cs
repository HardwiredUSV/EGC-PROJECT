using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour
{

    public warrior w;
    public int lifeTime = 3;
    private float movement = 0f;
    public Animator animator;

    bool urmareste = true;


    // Update is called once per frame

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "SampleScene2")
            urmareste = false;
    }

    private void Update()
    {
        

        if(urmareste)
        {
            movement = Input.GetAxisRaw("Vertical") * w.moveSpeed;
            animator.SetFloat("Speed", Mathf.Abs(movement));

            transform.LookAt(w.transform);
            transform.position += transform.forward * (w.moveSpeed-30) * Time.deltaTime;
            
        }
        

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            if (w.are_arma)
            {
                w.GetComponent<Animator>().Play("Atac");
                gameObject.GetComponent<Animator>().Play("Cadere");
                urmareste = false;
                w.text3.SetActive(true);
                Destroy(w.text3, lifeTime);
            }

            else
            {
                SceneManager.LoadScene("AI-PIERDUT");
            }
        }
    }

}
