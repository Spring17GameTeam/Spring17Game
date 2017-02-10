using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecruitMenu : MonoBehaviour
{
    public GameObject input;

    public void OnMouseUp()
    {
        Debug.Log("Click");
        string num = input.GetComponent<InputField>().text;
        GameObject.FindGameObjectWithTag("Player").GetComponent<RecruitBehavior>().RecruitTroops(num);
        Destroy(GameObject.FindGameObjectWithTag("RecruitButton"));
        GameManager.playerTurn = false;
    }
}