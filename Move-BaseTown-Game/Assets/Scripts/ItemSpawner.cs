using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public List<GameObject> Spawnpoints;
    public List<GameObject> Spawning;

    void Start()
    {
        foreach (GameObject p in Spawnpoints)
        {
            Instantiate(Spawning[Random.Range(0, Spawning.Count)], p.transform.position, p.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            foreach (GameObject p in Spawnpoints)
            {
                Instantiate(Spawning[Random.Range(0, Spawning.Count)], p.transform.position, p.transform.rotation);
            }
        }
    }
}
