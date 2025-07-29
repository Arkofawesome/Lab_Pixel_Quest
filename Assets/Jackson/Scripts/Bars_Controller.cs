using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Threading;

public class Bars_Controller : MonoBehaviour
{
    //Everybar is out of 500
    public float pollution = 250f;
    public float traffic = 250f;
    public float popularity = 150f;
    public float revenue = 0f;

    public static float MAX_BAR = 500f;

    //public TextMeshPro textMeshPro;
    public TextMeshProUGUI dateText;

    public int month = 7;
    public int year = 2025;


    public float currentTime = 10f;
    public float timer = 10f;

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
        updateBars();
        dateText = GameObject.Find("DateText").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime < 0)
        {
            Debug.Log("Its been 10 secs");
            currentTime = timer;
            if (month == 12)
            {
                month = 1;
                year++;
            }
            else
            {
                month++;
            }

            updateDate(month, year);
        }
        
    }

    public void updateDate(int month, int year)
    {
        this.month = month;
        this.year = year;
        dateText.text = "" + month + " / " + year;
    }
    public void updateBars()
    {
        revenueImg.fillAmount = revenue / MAX_BAR;
        pollutionImg.fillAmount = pollution / MAX_BAR;
        trafficImg.fillAmount = traffic / MAX_BAR;
        popularityImg.fillAmount = popularity / MAX_BAR;
    }
}
