using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MedusaFinishline : MonoBehaviour
{
    [SerializeField]
    private GameObject Game, Player1, Player2, winner, retry, exit;
    private bool playerwin;
    public Text winnerText;
    [SerializeField]
    private ThirdPersonCharacterController controller;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player1"))
        {
            playerwin = true;
            winnerText.text = "Player 1 wins!";
            //Player1.GetComponent<MedusaPlayer>().ResetPos();
            //Player2.GetComponent<MedusaPlayer>().ResetPos();
            //Game.SetActive(false);
            //Debug.Log("Game Won");
        }
        else if (other.CompareTag("Player2"))
        {
            playerwin = true;
            winnerText.text = "Player 2 wins!";
        }
        if(playerwin == true)
        {
            winner.SetActive(true);
            retry.SetActive(true);
            exit.SetActive(true);
            Player1.SetActive(false);
            Player2.SetActive(false);
        }
    }

    public void Retry()
    {
        Reset();
    }

    public void Exit()
    {
        Reset();
        controller.gameOpen = false;
        Game.SetActive(false);
    }

    private void Reset()
    {
        Player1.SetActive(true);
        Player2.SetActive(true);
        Player1.GetComponent<MedusaPlayer>().ResetPos();
        Player2.GetComponent<MedusaPlayer>().ResetPos();
        playerwin = false;
        winner.SetActive(false);
        retry.SetActive(false);
        exit.SetActive(false);
    }
}
