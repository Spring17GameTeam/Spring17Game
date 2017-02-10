using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecruitBehavior : MonoBehaviour {

	// Takes a string of new troops
	public void RecruitTroops(string num)
    {
        int newTroops = int.Parse(num);
        if (gameObject.name == "Player")
        {
            int cp = gameObject.GetComponent<PlayerUnit>().combatPower;
            gameObject.GetComponent<PlayerUnit>().averageSkill = (cp + 30 * newTroops) / (gameObject.GetComponent<PlayerUnit>().troopCount += newTroops);
        }
    }
}
