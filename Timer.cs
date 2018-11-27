using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private bool finnished = true;
    string minutes;
    string seconds;
    float t=0;
    //float bestTime = 10000;
    // Use this for initialization
    void Start () {
        // startTime = Time.time;
       

    }
	void Update () {

        if (finnished)
            return;

        t = Time.time - startTime;

        minutes = ((int)t / 60).ToString();
        seconds = (t % 60).ToString("f0");

        timerText.text = minutes + ":" + seconds;
		
	}

    public void Finnish()
    {
        //Debug.Log("Best Score = " + minutes + ":" + seconds);
        finnished = true;
        timerText.color = Color.red;
        
       

    }

    public void StartUp()
    {
        startTime = Time.time;
        finnished = false;
        timerText.color = Color.white;
    }

    
}
