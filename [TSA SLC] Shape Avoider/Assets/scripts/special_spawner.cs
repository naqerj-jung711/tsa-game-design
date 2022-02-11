using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class special_spawner : MonoBehaviour
{
    public float spawnRate = 1f;
    public GameObject[] prefabs;
    private float nextTimeToSpawn = 0f;
    public float score = 0f;
    private int randomPrefab;
    // Update is called once per frame
    void Update()
    {
        randomPrefab = Random.Range(0, prefabs.Length);
        if (Time.time >= nextTimeToSpawn)
        {
            Instantiate(prefabs[randomPrefab], Vector3.zero, Quaternion.identity);
            nextTimeToSpawn = Time.time + 1f / spawnRate;
            score += 1;
        }
        

    }
}
