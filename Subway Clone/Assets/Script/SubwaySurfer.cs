using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class SubwaySurfer : MonoBehaviour
{
    //references
    
    //properties
    public float step=4.0f;
    //public float speed = 0f;
    public float jumpHeight= 2.0f;

    public int coin;
    private Rigidbody rb;

    private bool ismiddle,right,left;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetAxis("Horizontal") > 0 && transform.position.x < step ) //transform.Translate(Vector3.right*step);
                                                                                //Vector3.MoveTowards(rb.transform.position, new Vector3(-4, 0, -5.69f), 1);
        { 
            transform.position = Vector3.Lerp(transform.position, new Vector3(-4, 0, -5.69f), 0.1f);
        }
        else if (Input.GetAxis("Horizontal") < 0 && transform.position.x > -step ) //transform.Translate(Vector3.left * step);
                                                                                  //Vector3.MoveTowards(rb.transform.position, new Vector3(-4, 0, -5.69f), 1);
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(4, 0, -5.69f), 0.1f);
            ismiddle = false;
        }
        else if(Mathf.Abs( Input.GetAxis("Horizontal") )>0)
        { 
            ismiddle = true;
            transform.position = Vector3.Lerp(transform.position, new Vector3(0, 0, -5.69f), 0.1f);
        }

        // transform.position = Vector3.Lerp(transform.position, new Vector3(4, 0, -5.69f), 0.1f);

        if (Input.GetButtonDown("Jump"))
        {
           // transform.Translate(Vector3.up*jumpHeight);
           rb.AddForce(Vector3.up * jumpHeight);
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1;
        }
    }

    /*void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Respawn"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }*/



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obs")
        {
            Time.timeScale = 0;
            Debug.Log("dd");
        }
    }

   /* private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Destroy(gameObject);
            coin++;
        }
    }*/
}
