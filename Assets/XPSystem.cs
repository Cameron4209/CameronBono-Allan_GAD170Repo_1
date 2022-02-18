using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPSystem : MonoBehaviour
{
    public int level; //laps

    public float curXP; //curLapProgress
    public float reqXP; //reqLapProgress

    //stats to betracked and updated upon levelup
    public float health;
    public float defence;
    public float speed;
    public float attack;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //skeletons need to go in here
    }

    //skeletons
    public void InitialStats()
    {
        //Initial stats, level. xp, reqxp etc.
    }

    public void Interaction(int exp)
    {
        //an interaction called by a buttn press x3
    }

    public void GainXP(int amount)
    {
        //increase current xp
    }

    public void LevelUp()
    {
        //increase our level
    }

    public void IncreaseStats()
    {
        //increase our stats
    }
}
