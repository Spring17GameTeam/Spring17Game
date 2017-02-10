using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillageBehavior : MonoBehaviour {

    public LayerMask characterLayer;
    public GameObject recruitButton;
    GameObject activeButton;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit2D hit = Physics2D.Raycast(gameObject.transform.position, gameObject.transform.position, 0f, characterLayer);
        if (hit.transform != null)
        {
            if (activeButton == null)
            {
                activeButton = Instantiate(recruitButton, gameObject.GetComponent<Transform>());
            }
        }
        else
        {
            if (activeButton != null)
            { 
                Destroy(activeButton);
            }
            
        }
	}
}
