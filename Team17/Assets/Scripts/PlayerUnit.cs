using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit : MonoBehaviour
{
    public int health; //Changes from Mekenzy
    public int averageSkill;
    public int troopCount;
    public int combatPower;
    public GameObject highlightTile;

	// Use this for initialization
	void Start () {
        
	}

    public void MoveOptions()
    {
        Vector2 pos = gameObject.transform.position;
        TileCheck(new Vector2(pos.x + 1, pos.y));
        TileCheck(new Vector2(pos.x - 1, pos.y));
        TileCheck(new Vector2(pos.x, pos.y + 1));
        TileCheck(new Vector2(pos.x, pos.y - 1));
    }

    void TileCheck(Vector2 start)
    {
        RaycastHit2D hit = Physics2D.Raycast(start, start, 0f);
        if (hit.collider != null)
        {
            hit.transform.GetComponent<PlayerMove>().enabled = true;
            hit.transform.GetComponent<PlayerMove>().highlight = Instantiate(highlightTile, hit.transform.position, Quaternion.identity, hit.transform.GetComponent<Transform>());
            GameManager.activeTiles.Add(hit.transform.gameObject);
            hit.transform.GetComponent<PlayerMove>().player = gameObject;
        }
        hit = new RaycastHit2D();
    }
	
	// Update is called once per frame
	void Update() 
    {
        combatPower = averageSkill * troopCount;
	}
}
