using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCleaner : MonoBehaviour
{
    public string parentName;
    void Start()
    {
        parentName = transform.name;
        StartCoroutine(DeleteClone());
    }

   IEnumerator DeleteClone()
    {
        yield return new WaitForSeconds(50);
        if (parentName == $"{transform.name}(clone)") ;
        {
            Destroy(gameObject);
        }
    }
}
