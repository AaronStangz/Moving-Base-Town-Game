using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public float pickUpRange;

    [Header("What To Give")]
    public int giveScrapMetal;
    public int giveLightMetal;
    public int giveHeavyMetal;
    public int giveScrapWood;
    public int giveLightWood;
    public int giveHeavyWood;

    public GameObject mainManager;
    ItemManager ItemManager;
    void Start()
    {
        mainManager = GameObject.Find("MainManager");
        ItemManager = mainManager.GetComponent<ItemManager>();
    }

    public void CollectItem()
    {
        if (ItemManager.scrapMetel < 20)
        {
            ItemManager.scrapMetel += giveScrapMetal;
            Destroy(gameObject);
        }
        if (ItemManager.lightMetel < 20)
        {
            ItemManager.lightMetel += giveLightMetal;
            Destroy(gameObject);
        }
        if (ItemManager.heavyMetel < 20)
        {
            ItemManager.heavyMetel += giveHeavyMetal;
            Destroy(gameObject);
        }
        if (ItemManager.scrapWood < 20)
        {
            ItemManager.scrapWood += giveScrapWood;
            Destroy(gameObject);
        }
        if (ItemManager.lightWood < 20)
        {
            ItemManager.lightWood += giveLightWood;
            Destroy(gameObject);
        }
        if (ItemManager.heavyWood < 20)
        {
            ItemManager.heavyWood += giveHeavyWood;
            Destroy(gameObject);
        }
    }
}
