using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MedusaGameButtons : MonoBehaviour
{
    [SerializeField]
    private RectTransform Player1, Player2;
    [SerializeField]
    private MedusaLogic medusaLogic;
    [SerializeField]
    private float MovementMin, MovementMax;

    public void MovePlayer1()
    {
        //moves Player 1 forward on an interval
        if (!medusaLogic.GetFreeze())
        {
            Vector3 vector3 = new Vector3(Player1.localPosition.x - Random.Range(MovementMin, MovementMax), Player1.localPosition.y, Player1.localPosition.z);
            Player1.localPosition = vector3;
        }
        else
        {
            //Mean Mode AKA: return to the start if she is looking at you
            //Player1.GetComponent<MedusaPlayer>().ResetPos();
        }
    }

    public void MovePlayer2()
    {
        if (!medusaLogic.GetFreeze())
        {
            //moves Player 1 forward on an interval
            Vector3 vector3 = new Vector3(Player2.localPosition.x - Random.Range(MovementMin, MovementMax), Player2.localPosition.y, Player2.localPosition.z);
            Player2.localPosition = vector3;
        }
        else
        {
            //Mean Mode AKA: return to the start if she is looking at you
            //Player2.GetComponent<MedusaPlayer>().ResetPos();
        }
    }
}
