using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinMiniGame : MonoBehaviour
{
    [SerializeField]
    //private GameObject Game, player, enemy;
    public bool win = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            win = true;
            //player.GetComponent<Labyrinth_Player>().ResetPos();
            //enemy.GetComponent<Labyrinth_Enemy>().ResetPos();
            //Game.SetActive(false);
            //Debug.Log("Game Won");
        }
    }
}
