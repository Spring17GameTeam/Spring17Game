using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainButton : MonoBehaviour {

    public GameObject player;

    private void OnMouseUp()
    {
        player.GetComponent<UnitTraining>().Train();
        if (!MoveButton.moved)
        {
            MoveButton.moved = true;
        }
    }
}
