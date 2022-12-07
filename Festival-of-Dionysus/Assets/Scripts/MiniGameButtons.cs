using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameButtons : MonoBehaviour
{
    [SerializeField]
    private GameObject Game1, LaybrinthPlayer, Game2, Game3, DefencePlayer, startGame1, startGame2, startGame3;

    public void StartGame1()
    {
        LaybrinthPlayer.SetActive(true);
        Game1.SetActive(true);
        startGame1.SetActive(false);
    }

    public void StartGame2()
    {
        Game2.SetActive(true);
        startGame2.SetActive(false);
    }

    public void StartGame3()
    {
        DefencePlayer.SetActive(true);
        Game3.SetActive(true);
        startGame3.SetActive(false);
    }
}
