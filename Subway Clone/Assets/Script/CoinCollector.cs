using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    public int coinValue = 1;
    public Text textsc;
    public int score;
    
    
       
    private void OnTriggerEnter(Collider other)
    { 
        if (other.gameObject.CompareTag("Coin")) 
        {
            Destroy(other.gameObject);
            score++;
            textsc.text = "Score : " + score.ToString();
            Debug.Log(coinValue);
        }
    } 
         
}
