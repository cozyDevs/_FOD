using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Labyrinth_Player : MonoBehaviour
{
    [SerializeField]
    private int speed;
    [SerializeField]
    private Vector2 StartPos;
    private Rigidbody2D rb;
    private RectTransform UIplace;
    public QuestionHandler questionHandler;
    //private Collider2D collider;
    //private bool colEn = false;
    //private float time;
    //public GameObject player;

    private void Awake()
    {
        //assigns Rigidbody
        rb = GetComponent<Rigidbody2D>();
        UIplace = GetComponent<RectTransform>();
        UIplace.localPosition = StartPos;
        //collider = GetComponent<Collider2D>();
       
    }

    private void FixedUpdate()
    {
        float x = UIplace.position.x;
        float y = UIplace.position.y;
        float newX = 0;
        float newY = 0;
        if (questionHandler.questionAsked == false)
        {
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                newX = speed * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                newX = speed * Time.deltaTime * -1;
            }

            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            {
                newY = speed * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            {
                newY = speed * Time.deltaTime * -1;
            }
            //if (!colEn)
            //{
            //    time += Time.deltaTime;
            //    if (time > 4)
            //    {
            //        collider.enabled = !collider.enabled;
            //        colEn = true;
            //    }
            //}
        }

        if ((newX > 0 || newX < 0) || (newY > 0 || newY < 0))
            rb.AddForce(new Vector2(newX, newY));
        else
            rb.Sleep();
    }

    public void ResetPos()
    {
        UIplace.localPosition = StartPos;
    }
}
