using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillBuild : MonoBehaviour
{
    public float useRange;
    public GameObject ScarpWood;
    public GameObject LightWood;
    public GameObject HeavyWood;

    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void PlaceScrapWood()
    {
        ScarpWood.SetActive(true);
    }
    public void PlaceLightWood()
    {
        LightWood.SetActive(true);
    }
    public void PlaceHeavyWood()
    {
        HeavyWood.SetActive(true);
    }
    public void Break()
    {
        ScarpWood.SetActive(false);
        LightWood.SetActive(false);
        HeavyWood.SetActive(false);
    }
}
