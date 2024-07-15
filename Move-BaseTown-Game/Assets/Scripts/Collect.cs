using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public float pickUpRange;

    [Header("What To Give")]
    public int giveScrapSteel;
    public int giveScrapWood;
    public int giveScrapCopper;

    public int giveSteel;
    public int giveWood;
    public int giveCopper;

    public int giveSteelRod;
    public int giveWoodRod;
    public int giveSteelbeam;
    public int giveCopperWire;
    public int giveSteelPlate;
    public int giveSteelCable;

    public int giveScrews;
    public int giveGear;

    public GameObject mainManager;
    ItemManager ItemManager;
    void Start()
    {
        mainManager = GameObject.Find("MainManager");
        ItemManager = mainManager.GetComponent<ItemManager>();
    }

    public void CollectItem()
    {
        if (ItemManager.scrapSteel < 20)
        {
            ItemManager.scrapSteel += giveScrapSteel;
            Destroy(gameObject);
        }
        if (ItemManager.scrapWood < 20)
        {
            ItemManager.scrapWood += giveScrapWood;
            Destroy(gameObject);
        }
        if (ItemManager.scrapCopper < 20)
        {
            ItemManager.scrapCopper += giveScrapCopper;
            Destroy(gameObject);
        }
        if (ItemManager.steel < 20)
        {
            ItemManager.steel += giveSteel;
            Destroy(gameObject);
        }
        if (ItemManager.wood < 20)
        {
            ItemManager.wood += giveWood;
            Destroy(gameObject);
        }
        if (ItemManager.copper < 20)
        {
            ItemManager.copper += giveCopper;
            Destroy(gameObject);
        }
        if (ItemManager.steelRod < 20)
        {
            ItemManager.steelRod += giveSteelRod;
            Destroy(gameObject);
        }
        if (ItemManager.woodRod < 20)
        {
            ItemManager.woodRod += giveWoodRod;
            Destroy(gameObject);
        }
        if (ItemManager.steelbeam < 20)
        {
            ItemManager.steelbeam += giveSteelbeam;
            Destroy(gameObject);
        }
        if (ItemManager.copperWire < 20)
        {
            ItemManager.copperWire += giveCopperWire;
            Destroy(gameObject);
        }
        if (ItemManager.steelPlate < 20)
        {
            ItemManager.steelPlate += giveSteelPlate;
            Destroy(gameObject);
        }
        if (ItemManager.steelCable < 20)
        {
            ItemManager.steelCable += giveSteelCable;
            Destroy(gameObject);
        }
        if (ItemManager.screws < 20)
        {
            ItemManager.screws += giveScrews;
            Destroy(gameObject);
        }
        if (ItemManager.gear < 20)
        {
            ItemManager.gear += giveGear;
            Destroy(gameObject);
        }
    }
}
