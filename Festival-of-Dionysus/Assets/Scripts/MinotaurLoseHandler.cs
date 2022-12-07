using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinotaurLoseHandler : MonoBehaviour
{
    public Labyrinth_Enemy minotaur;
    bool lose;
    public GameObject restart, exit, winlose, game, player, enemy;
    public Text losewin;
    public WinMiniGame wmg;
    [SerializeField]
    private QuestionHandler qh;
    [SerializeField]
    private List<QuestionRooms> qrooms = new List<QuestionRooms>();
    [SerializeField]
    private ThirdPersonCharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (minotaur.lose == true)
        {
            lose = true;
        }
        else if (wmg.win == true)
        {
            enemy.SetActive(false);
            restart.SetActive(true);
            exit.SetActive(true);
            winlose.SetActive(true);
            losewin.text = "You've escaped the Labyrinth!";
        }
        if(lose == true)
        {
            qh.DeactivateButtons();
            player.SetActive(false);
            restart.SetActive(true);
            exit.SetActive(true);
            winlose.SetActive(true);
            losewin.text = "Oh no! The minoataur caught you!";
        }
    }

    public void ExitGame()
    {
        player.GetComponent<Labyrinth_Player>().ResetPos();
        enemy.GetComponent<Labyrinth_Enemy>().ResetPos();
        game.SetActive(false);
        Debug.Log("Exiting Game");
        controller.gameOpen = false;
        ResetGame();

    }

    public void RestartGame()
    {
        ResetGame();
        player.GetComponent<Labyrinth_Player>().ResetPos();
        enemy.GetComponent<Labyrinth_Enemy>().ResetPos();
        Debug.Log("Restarting Game");
    }

    private void ResetGame()
    {
        player.SetActive(true);
        enemy.SetActive(true);
        restart.SetActive(false);
        exit.SetActive(false);
        winlose.SetActive(false);
        minotaur.lose = false;
        lose = false;
        wmg.win = false;
        foreach (QuestionRooms qroom in qrooms)
        {
            qroom.ResetQOne();
        }

    }
}
