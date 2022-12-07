using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionRooms : MonoBehaviour
{
    [SerializeField]
    private bool QuestionOnce = true;
    public QuestionHandler questionHandler;

    private void Awake()
    {
        QuestionOnce = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && QuestionOnce)
        {
            QuestionOnce = false;
            RunQuestion();
        }
    }

    private void RunQuestion()
    {
        questionHandler.CallRandom();
    }

    public void ResetQOne()
    {
        QuestionOnce = true;
    }
}