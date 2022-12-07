using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Labyrinth_Enemy : MonoBehaviour
{
    [SerializeField]
    private RectTransform UIplace;
    [SerializeField]
    private Vector2 StartPos;
    public bool lose = false;

    private void Awake()
    {
        //assigns transform
        UIplace = GetComponent<RectTransform>();
        UIplace.localPosition = StartPos;
    }

    public void ResetPos()
    {
        UIplace.localPosition = StartPos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            lose = true;
    }
}
