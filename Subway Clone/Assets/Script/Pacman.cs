using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacman : MonoBehaviour
{
    public float step=1.1f;
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Horizontal")) transform.Translate(new Vector3(step * Input.GetAxis("Horizontal") * Time.deltaTime, 0, 0));
        else if (Input.GetButton("Vertical")) transform.Translate(new Vector3(0, 0, step * Input.GetAxis("Vertical") * Time.deltaTime));
    }
}
