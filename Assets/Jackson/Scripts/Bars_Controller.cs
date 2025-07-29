using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Bars_Controller : MonoBehaviour
{
    //Everybar is out of 500
    public int pollution = 250;
    public int traffic = 250;
    public int popularity = 150;
    public int revenue = 0;

    public static int MAX_BAR = 500;

    public Image revenueImg;
    public Image popularityImg;
    public Image trafficImg;
    public Image pollutionImg;



    void Start()
    {
        revenueImg = GameObject.Find("RevenueBar").GetComponent<Image>();
        popularityImg = GameObject.Find("PopularityBar").GetComponent<Image>();
        trafficImg = GameObject.Find("TrafficBar").GetComponent<Image>();
        pollutionImg = GameObject.Find("PollutionBar").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateBars()
    {
        revenueImg.fillAmount = revenue / MAX_BAR;
        pollutionImg.fillAmount = pollution / MAX_BAR;
        trafficImg.fillAmount = traffic / MAX_BAR;
        popularityImg.fillAmount = popularity / MAX_BAR;
    }
}
