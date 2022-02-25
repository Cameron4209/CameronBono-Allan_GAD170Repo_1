/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPSystem : MonoBehaviour
{
    public int level = 0; //laps

    public float curXP = 0.0f; //curLapProgress
    public float reqXP = 100.0f; //reqLapProgress

    //stats to betracked and updated upon levelup
    public float health = 100;
    public float defence = 10;
    public float speed = 10;
    public float attack = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //skeletons need to go in here
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            InteractionAttack();
        }
        if (Input.GetKeyDown(KeyCode.E));
        {
            InteractionSkill();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            InteractionUltimate();
        }
        else
        {
            Debug.Log("Please activate a valid attack option, either 'Left Mouse Click', 'E' or 'Q'.");
        }

        //Increase level
        public void LevelUp()
        {
            level += 1;
            InitialStats();
        }


        public void InitialStats()
        {
            //Initial stats, level. xp, reqxp etc.
            //Increasing level by 1, resetting current XP to 0 & Increasing required XP by 20%.
            curXP = 0.0f;
            reqXP *= 1.2f;
            Debug.Log("Congratulations, you have leveled up. Your new level is " + level + ".");
        }

        public void InteractionAttack(int exp)
        {
            //an interaction called by a buttn press x3
            curXP + 10.0f;
            Debug.Log("Performed Normal Attack. Gained 10 XP.");
        }
        
        public void InteractionSkill(int exp)
        {
            //an interaction called by a buttn press x3
            curXP + 20.0f;
            Debug.Log("Performed Skill Attack. Gained 20 XP.");
        }

        public void InteractionUltimate(int exp)
        {
            //an interaction called by a buttn press x3
            curXP + 50.0f;
            Debug.Log("Performed Ultimate Attack. Gained 50 XP.");
        }

        public void GainXP(int amount)
        {
            //increase current xp

        }

        public void IncreaseStats()
        {
            //increase our stats
        }

    }

}*/