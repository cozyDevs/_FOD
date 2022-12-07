using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenseButtons : MonoBehaviour
{
    [SerializeField]
    private DefensePlayer player;

    public void submitAnswer()
    {
        player.TryAnswer();
    }
}
