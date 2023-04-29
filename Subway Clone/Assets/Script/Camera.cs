using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;
    public float camdisty=10;
    public float camdistz=10;
   

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(0, camdisty, camdistz);
    }
}
