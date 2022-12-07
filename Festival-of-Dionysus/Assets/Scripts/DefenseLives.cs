using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenseLives : MonoBehaviour
{
    [SerializeField]
    DefensePlayer player;
    [SerializeField]
    Text liveText;

    private void OnEnable()
    {
         liveText.text = "Lives: " + player.GetHealth();
    }

    public void UpdateText()
    {
        int i = player.GetHealth();
        liveText.text = "Lives: " + i;
        if(i <= 0)
        {
            liveText.text = "Defeat";
        }
    }
}
