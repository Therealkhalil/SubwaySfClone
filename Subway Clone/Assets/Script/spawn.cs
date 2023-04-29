using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    [SerializeField] private GameObject[] prefab;
    private float time;
    private float score;
    [SerializeField] private float spawnTime;
    [SerializeField] private float spawnPosZ;

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime*2;
        time += Time.deltaTime;
        if (time >= spawnTime)
        {
            time = 0;

            float[] numbers = new float[] { 4f, 0.5f, -4f };
            int randomIndex = Random.Range(0,3);
            float randomFloatFromNumbers = numbers[randomIndex];
            GameObject pref = prefab[Random.Range(0, 3)];
            Instantiate(pref, new Vector3(randomFloatFromNumbers, 1f, spawnPosZ), pref.transform.rotation);
        }

    }
}
