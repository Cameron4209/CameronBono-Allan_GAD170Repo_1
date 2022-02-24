using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPSystem_1 : MonoBehaviour
{
    int level = 0;
    float curXP = 0.0f;
    float reqXP = 100.0f;
    float health = 100;
    float defence = 10;
    float speed = 10;
    float attack = 10;

    void Start()
    {

    }

    void Update()
    {
        //Keyboard Inputs
        if (Input.GetKeyDown(KeyCode.E))
        {
            GainXP(10.0f);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            GainXP(15.0f);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GainXP(50.0f);
        }
        else
        {
            Debug.Log("Please perform a valid action using the inputs: 'E', 'R' or 'Q'.");
        }

    }

    //functions:
    public void GainXP(float XP)
    {
        curXP += XP;
        Debug.Log("Gained " + XP + " XP.");
        Debug.Log("Your current XP is " + curXP + ".");
        CheckXP();
    }

    public void CheckXP()
    {
        if (curXP >= reqXP)
        {
            LevelUp();
            Debug.Log("Your attack was successful.");
                Debug.Log("Congratulations, you have leveled up. Your new level is " + level + ". Your new stats are as follows:");
            Debug.Log("Health = " + health + ".");
            Debug.Log("Defence = " + defence + ".");
            Debug.Log("Speed = " + speed + ".");
            Debug.Log("Base Attack = " + attack + ".");
        }
        else
        {
            Debug.Log("Your attack was successful.");
        }

    }

    public void LevelUp()
    {
        //level += 1; in racing script there were two 'laps +=1', if I did that here wouldnt it give 2 levels rather than 1?
        InitializeStats();
        UpgradeStats();
    }

    public void InitializeStats()
    {
        level += 1;
        curXP = 0.0f;
        reqXP *= 1.2f;
    }

    public void UpgradeStats()
    {
        health *= 1.2f;
        defence += 5;
        speed += 5;
        attack += 5;
    }
    
}