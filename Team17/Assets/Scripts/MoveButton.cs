using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButton : MonoBehaviour {

    public GameObject player;
    [HideInInspector] public static bool moved;

    private void Awake()
    {
        moved = true;
    }

    private void OnMouseUp()
    {
        if (moved)
        {
            player.GetComponent<PlayerUnit>().MoveOptions();
        }
        else
        {
            foreach (GameObject tile in GameManager.activeTiles)
            {
                tile.GetComponent<PlayerMove>().enabled = false;
            }
            GameManager.activeTiles.Clear();
        }
        moved = !moved;

    }
}
