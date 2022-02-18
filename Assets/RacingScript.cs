using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacingScript : MonoBehaviour
{
    int laps = 0;
    float curLapProgress = 0.0f;
    float reqLapProgress = 100.0f;
    float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) //accessing input libary
        {
            GainProgress(speed);
        }
    }

    //functions:
    public void GainProgress(float progress)
    {
        curLapProgress += progress; //same as 'curLapProgress = curLapProgres + progress, += means add then set
        Debug.Log("Gained " + progress + " progress.");
        Debug.Log("Total current progress is now: " + curLapProgress + ".");
        CheckProgress(curLapProgress);
    }

    public void CheckProgress(float progress)
    {
        if(progress >= reqLapProgress)
        {
            //Completing a lap
            laps++;
            LapCompleted();
            Debug.Log("You reached the required progress!");
        }
    }

    public void LapCompleted()
    {
        //update laps
        //update curProgress
        //update reqProgress
        //update speed
        laps += 1;
        curLapProgress = 0.0f;
        reqLapProgress *= 1.15f; //every lap will require 15% more lapProgress
        Debug.Log("Completed " + laps + " laps.");
    }
}