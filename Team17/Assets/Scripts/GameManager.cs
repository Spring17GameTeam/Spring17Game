using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;
    [HideInInspector]
    public static bool playerTurn = true;
    BoardManager boardmanager;
    public static int debugcounter = 0;
    public static List<GameObject> activeTiles = new List<GameObject>();

    // Use this for initialization
    void Start () {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
        boardmanager = GetComponent<BoardManager>();

        Init();
	}

    void Init()
    {
        boardmanager.BoardMaker();
    }

	// Update is called once per frame
	void Update () {
        if (playerTurn)
            return;
        else if (activeTiles.Count > 0)
        {
            foreach (GameObject tile in activeTiles)
            {
                tile.GetComponent<PlayerMove>().enabled = false;
            }
            activeTiles.Clear();
        }
        EnemyTurn();
	}

    void EnemyTurn()
    {
        playerTurn = true;
    }
}
