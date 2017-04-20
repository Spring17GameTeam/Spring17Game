using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateStart : MonoBehaviour {
    private object Enemy = new object();

    public void PrepareBattle()
    {
        CreateNewEnemy();
        TurnBasedCombat.currentState = TurnBasedCombat.BattleStates.PLAYERCHOICE;
    }

    private void CreateNewEnemy()
    {
        //Want to create this similar to a Node, rather than, whatever this is.
        string enemyName = "Bad Guy";
        int combatPower = 100;
    }
}
