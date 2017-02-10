using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    [HideInInspector] public GameObject player;
    [HideInInspector] public GameObject highlight;
    //public Color color;
    //Color defaultcolor;
    //Renderer rend;

    // Use this for initialization
    void Start () {
        //defaultcolor = gameObject.GetComponent<Renderer>().material.color;
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    private void OnEnable()
    {
        //gameObject.GetComponent<Renderer>().material.color = color;
    }

    void OnMouseUp()
    {
        if (enabled)
        {
            player.transform.position = transform.position;
            GameManager.playerTurn = false;
            MoveButton.moved = true;        
        }
    }

    private void OnDisable()
    {
        player = null;
        Destroy(highlight);
        //gameObject.GetComponent<Renderer>().material.color = defaultcolor;
    } 

}
