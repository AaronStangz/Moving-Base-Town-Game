using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public float pickUpRange;

    [Header("What To Give")]
    public int giveScrapMetal;
    public int giveMetal;

    public GameObject mainManager;
    ItemManager ItemManager;
    void Start()
    {
        ItemManager = mainManager.GetComponent<ItemManager>();
    }

    public void CollectItem()
    {
        if (ItemManager.scrapMetel < 1)
        {
            ItemManager.scrapMetel += giveScrapMetal;
            Destroy(gameObject);
        }
        if (ItemManager.metel < 1)
        {
            ItemManager.metel += giveMetal;
            Destroy(gameObject);
        }
    }
}
