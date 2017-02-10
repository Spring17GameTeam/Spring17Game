using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecruitButton : MonoBehaviour 
{

    public GameObject recruitMenu;
    GameObject current;

    private void OnMouseUp()
    {
        if (current == null)
        {
            current = Instantiate(recruitMenu);
            current.transform.SetParent(FindObjectOfType<Canvas>().transform, false);
        }       
    }

    private void OnDestroy()
    {
        Destroy(current);
    }
}
