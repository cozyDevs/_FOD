using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenseScore : MonoBehaviour
{
    [SerializeField]
    DefensePlayer player;
    [SerializeField]
    Text Score;

    private void OnEnable()
    {
        Score.text = player.GetCorrectAnswers() + "/" + player.GetAnswersToWin()
            +"\nAnswers";
    }

    public void UpdateText()
    {
        int i = player.GetHealth();
        Score.text = player.GetCorrectAnswers() + "/" + player.GetAnswersToWin()
            + "\nAnswers";
        if (i <= 0)
        {
            Score.text = "Defeat";
        }
    }
}
