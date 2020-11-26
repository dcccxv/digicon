using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cshUI : MonoBehaviour
{
    public Text connectionInfoText;
    public Text connectionInfoText2;
    private int score = 0;

    public void Update()
    {
        score = GameObject.Find("Player").GetComponent<ScoreScript>().Score;
        connectionInfoText.GetComponent<Text>().text = score.ToString() + "점";
        connectionInfoText2.GetComponent<Text>().text = score.ToString() + "점";
    }
}
