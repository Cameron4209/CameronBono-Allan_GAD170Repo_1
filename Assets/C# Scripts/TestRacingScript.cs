/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRacingScript : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GainProgress(speed);
        }

        //functions
        public void LapCompleted()
        {
            laps += 1;
            curLapProgress = 0.0f;
            reqLapProgress *= 1.15f;
            Debug.Log("Completed " + laps + " laps.");
        }

        public void CheckProgress(float progress)
        {
            if(progress >= reqLapProgress)
            {
                laps += 1;
                LapCompleted();
                Debug.Log("You reached the required progress!");
            }
        }
        public void GainProgress(float progress)
        {
            curLapProgress += progress;
            Debug.Log("Gained " + progress + " progress.");
            Debug.Log("Total current progress is now: " + curLapProgress + ".");
            CheckProgress(curLapProgress);
        }
    }
}*/
