using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("ChallengeObj Game Object")]
    public GameObject challengeObject;
    [Header("Default spawn delay time")]
    public float spawnDelay = 1f;
    [Header("Default spawn time")]
    public float spawnTime = 2f;
void Start()
{
    InvokeRepeating("InstantiateObjects", spawnDelay, spawnTime);
}
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
transform.position = new Vector3(15, -2.75f, 0);
    }
    void InstantiateObjects()
    {
        Instantiate(challengeObject, transform.position, transform.rotation);

    }
}
