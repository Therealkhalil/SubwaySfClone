using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    [SerializeField]private float speed;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {   
     //transform.Translate(new Vector3(0, 0, -1) * speed * Time.deltaTime); 
     rb.velocity = Vector3.back * speed;
    }

    

    
}
