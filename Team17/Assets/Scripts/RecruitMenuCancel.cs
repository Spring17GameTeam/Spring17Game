using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecruitMenuCancel : MonoBehaviour
{

    private void OnMouseUp()
    {
        Debug.Log("1");
        Destroy(GameObject.FindGameObjectWithTag("RecruitButton"));
        Debug.Log("2");
    }
}
