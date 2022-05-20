using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float currentTime;
    public float startingTime = 20f;

    [SerializeField] Text countdownText;
    void Start()
    {
        currentTime = startingTime;
    }
    void Update()
    {
        currentTime -= Time.deltaTime;

        //countdownText.text = currentTime.ToString("");
        countdownText.text = currentTime.ToString("00");

        if (currentTime <= 0)
        {
            currentTime = 0;
            // Your Code Here
        }

       
    }
}

