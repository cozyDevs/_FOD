using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenseEnemy : MonoBehaviour
{
    [SerializeField]
    private RectTransform pos;
    [SerializeField]
    private float speed, answer;
    [SerializeField]
    private Text problem;
    [SerializeField]
    private RandomQuestion questions;
    [SerializeField]
    private bool dying;
    private int i;

    public void setSpeed(float x)
    {
        speed = x;
    }

    public void setQuestions(RandomQuestion x)
    {
        questions = x;
    }

    void Start()
    {
        //assigns varibles
        pos = GetComponent<RectTransform>();
        problem = GetComponentInChildren<Text>();
        //makes question if the question
        if (questions != null)
        {
            i = Random.Range(0, 10);
            if (i == 0 || i == 4)
            {
                questions.MathDivide();
                if(speed < -2 || speed == null)
                {
                    speed += 2;
                }
            }
            else if (i == 1 || i == 5)
            {
                questions.MathMultiply();
                if (speed < -5 || speed == null)
                {
                    speed += 5;
                }
            }
            else if (i == 2 || i == 3 || i == 6)
            {
                questions.MathSubtract();
            }
            else
            {
                questions.MathAdd();
            }
            problem.text = questions.question.Substring(8);
        }
        dying = false;
        if(questions != null)
            answer = questions.z;
    }

    void FixedUpdate()
    {
        //makes question if the question has not been made yet
        if (questions != null && problem.text == "")
        {
            i = Random.Range(0, 4);
            if (i == 0)
            {
                questions.MathDivide();
                if (speed < -2 || speed == null)
                {
                    speed = -2;
                }
            }
            else if (i == 1)
            {
                questions.MathMultiply();
                if (speed < -5 || speed == null)
                {
                    speed = -5;
                }
            }
            else if (i == 2)
            {
                questions.MathSubtract();
            }
            else
            {
                questions.MathAdd();
            }
            problem.text = questions.question.Substring(8);
        }

        if (!dying)
        {
            //moves the Enemy Forward
            pos.Translate(new Vector3((speed * Time.deltaTime), 0, 0));
        }
        else
        {
            //moves the Enemy to die off screen
            pos.Translate(new Vector3((400 * Time.deltaTime), (500 * Time.deltaTime), 0));
        }
    }

    public bool Answer(int ans)
    {
        //checks if answer is right
        if(ans == answer)
        {
            //begins dying sequence if is dying
            dying = true;
            Destroy(this.gameObject, 1f);
            return true;
        }
        return false;
    }

    public bool HitBase()
    {
        dying = true;
        Destroy(this.gameObject, 1f);
        return true;
    }

    public bool Die()
    {
        Destroy(this.gameObject);
        return true;
    }
}
