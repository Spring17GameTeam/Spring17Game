using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBasedCombat : MonoBehaviour
{

    private bool hasAddedXP = false;
    private BattleStateStart battleStateStartScript = new BattleStateStart();
    public enum BattleStates
    {
        START,
        PLAYERCHOICE,
        ENEMYCHOICE,
        CALCULATEDAMAGE,
        LOSE,
        WIN
    }

    public static BattleStates currentState;

    // Use this for initialization
    void Start()
    {
        hasAddedXP = false;
        currentState = BattleStates.START;

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(currentState);
        switch (currentState)
        {
            case (BattleStates.START):
                battleStateStartScript.PrepareBattle();
                break;
            case (BattleStates.PLAYERCHOICE):
                break;
            case (BattleStates.ENEMYCHOICE):
                break;
            case (BattleStates.CALCULATEDAMAGE):
                break;


            case (BattleStates.LOSE):
                break;
            case (BattleStates.WIN):
                if (!hasAddedXP)
                {
                    //increaseExperience.AddExperience();
                    hasAddedXP = true;
                }
                break;
        }

    }
}

    //private void OnGUI()
    //{
        //if (GUILayout.Button("Next State"))
        //{
            //if (currentState == BattleStates.START)
            //{
                //currentState = BattleStates.PLAYERCHOICE;
            //}
          
        //}
    //}
//}
