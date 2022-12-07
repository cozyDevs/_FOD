using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefensePlayer : MonoBehaviour
{
    [SerializeField]
    int answersToWin, correctAnswers, startHealth, health;
    [SerializeField]
    private Text answer, winLoseDesc;
    [SerializeField]
    DefenseSpawner Spawner;
    [SerializeField]
    GameObject game;
    [SerializeField]
    private DefenseLives lives;
    [SerializeField]
    private DefenseScore score;
    [SerializeField]
    bool win, lose, spawnsStoped;
    [SerializeField]
    float endGameTimer, endGameTimeLimit;
    [SerializeField]
    private GameObject exit, restart, winLose;
    [SerializeField]
    private ThirdPersonCharacterController controller;

    public int GetHealth()
    {
        return health;
    }

    public int GetAnswersToWin()
    {
        return answersToWin;
    }

    public int GetCorrectAnswers()
    {
        return correctAnswers;
    }


    private void OnEnable()
    {
        endGameTimer = 0;
        correctAnswers = 0;
        health = startHealth;
        win = false;
        lose = false;
        spawnsStoped = false;
        score.UpdateText();
        lives.UpdateText();
    }

    private void FixedUpdate()
    {

        if (win)
        {
            if (!spawnsStoped)
            {
                Spawner.StopSpawns();
                spawnsStoped = true;
            }
            winLoseDesc.text = "You successully defended Greece!";
            LoadWinLose();
            //endGameTimer += Time.deltaTime;
            ////display win stuff
            //if (endGameTimer > endGameTimeLimit)
            //{
            //    endGameTimer = 0;
            //    game.SetActive(false);
            //}
        }
        else if (lose)
        {
            LoadWinLose();
            winLoseDesc.text = "Oh no, Greece was defeated!";
            //endGameTimer += Time.deltaTime;
            ////dipaly lose stuff
            //if (endGameTimer > endGameTimeLimit)
            //{
            //    endGameTimer = 0;
            //    game.SetActive(false);
            //}
        }
    }

    public void TryAnswer()
    {
        if (!win && !lose)
        {
            if (Spawner.checkAnswers(int.Parse(answer.text)))
            {
                answer.text = "";
                //Debug.Log("Correct");
                correctAnswers++;
                score.UpdateText();
                if (correctAnswers >= answersToWin)
                {
                    //Win game
                    Debug.Log("Win game");
                    win = true;
                }
            }
            answer.text = "";
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Hit");
        if (collision.gameObject.CompareTag("Enemy"))
        {
            health--;
            lives.UpdateText();
            if (health <= 0)
            {
                //Lose game
                Debug.Log("Lose game");
                score.UpdateText();
                lose = true;
                return;
            }
            collision.gameObject.GetComponent<DefenseEnemy>().HitBase();
        }
    }

    public void Reset()
    {
        winLose.SetActive(false);
        exit.SetActive(false);
        restart.SetActive(false);
        game.SetActive(false);
        game.SetActive(true);
        ////Spawner.StopSpawns();
        //endGameTimer = 0;
        //correctAnswers = 0;
        //health = startHealth;
        //win = false;
        //lose = false;
        //spawnsStoped = false;
        //score.UpdateText();
        //lives.UpdateText();
        //Spawner.StartSpawns();
    }

    private void LoadWinLose()
    {
        winLose.SetActive(true);
        exit.SetActive(true);
        restart.SetActive(true);
    }

    public void Exit()
    {
        Reset();
        controller.gameOpen = false;
        game.SetActive(false);
    }
}