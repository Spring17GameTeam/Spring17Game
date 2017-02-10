using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitTraining : MonoBehaviour {

    

	public void Train()
    {
        if (gameObject.GetComponent<PlayerUnit>() != null)
        {
            gameObject.GetComponent<PlayerUnit>().averageSkill += Random.Range(1, 5);
            GameManager.playerTurn = false;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
