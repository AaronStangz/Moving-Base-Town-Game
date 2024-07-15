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
    public int MaxMats;
    [Space]
    public int scrapSteel;
    public int scrapWood;
    public int scrapCopper;

    public int steel;
    public int wood;
    public int copper;

    public int steelRod;
    public int woodRod;
    public int steelbeam;
    public int copperWire;
    public int steelPlate;
    public int steelCable;

    public int screws;
    public int gear;


    void Start()
    {
        BaseConsole console = gameObject.GetComponent<BaseConsole>();
        player.transform.parent = playerSpawn.transform;
    }


    void Update()
    {
        
    }
}
