using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public Transform playerSpawn;
    public GameObject player;

    [Header("Villager")]
    public int villagerSlots;

    [Header("Levels")]
    public int townLevel;
    public int townCurrentLevelPoints;

    [Header("Mats")]
    public int scrapMetel;
    public int metel;
    public int scrapWood;
    public int wood;
    public int screws;
    public int nails;
    void Start()
    {
        BaseConsole console = gameObject.GetComponent<BaseConsole>();
        player.transform.parent = playerSpawn.transform;
    }


    void Update()
    {
        
    }
}
