using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandSpawner : MonoBehaviour
{
    public float spawntimer;
    public float SpawnArea = 10;
    public float SpawnHight = 10;
    public List<GameObject> Spawnpoints;
    public List<GameObject> Spawning;

    public void Start()
    {

        foreach (GameObject p in Spawnpoints)
        {
            Vector3 spawnPoint = new Vector3(Random.Range(-SpawnArea, SpawnArea), Random.Range(-SpawnHight, SpawnHight), Random.Range(-SpawnArea, SpawnArea));
            Instantiate(Spawning[Random.Range(0, Spawning.Count)], p.transform.position + spawnPoint, p.transform.rotation);
        }
        foreach (GameObject p in Spawnpoints)
        {
            Vector3 spawnPoint = new Vector3(Random.Range(-SpawnArea, SpawnArea), Random.Range(-SpawnHight, SpawnHight), Random.Range(-SpawnArea, SpawnArea));
            Instantiate(Spawning[Random.Range(0, Spawning.Count)], p.transform.position + spawnPoint, p.transform.rotation);
        }
        foreach (GameObject p in Spawnpoints)
        {
            Vector3 spawnPoint = new Vector3(Random.Range(-SpawnArea, SpawnArea), Random.Range(-SpawnHight, SpawnHight), Random.Range(-SpawnArea, SpawnArea));
            Instantiate(Spawning[Random.Range(0, Spawning.Count)], p.transform.position + spawnPoint, p.transform.rotation);
        }
        foreach (GameObject p in Spawnpoints)
        {
            Vector3 spawnPoint = new Vector3(Random.Range(-SpawnArea, SpawnArea), Random.Range(-SpawnHight, SpawnHight), Random.Range(-SpawnArea, SpawnArea));
            Instantiate(Spawning[Random.Range(0, Spawning.Count)], p.transform.position + spawnPoint, p.transform.rotation);
        }
    }
}
