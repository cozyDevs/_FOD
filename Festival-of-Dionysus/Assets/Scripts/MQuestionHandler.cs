using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MQuestionHandler : MonoBehaviour
{
    public RandomQuestion rH;
    public Text A1, B1, C1, D1, question1, A2, B2, C2, D2, question2;
    private int num;
    bool mathQuestion, correctA1, correctB1, correctC1, correctD1, correctA2, correctB2, correctC2, correctD2, assignOne, assignTwo;
    public MedusaGameButtons mGB;
    private bool buttonClicked1, buttonClicked2;
    private float t1, t2;
    // Start is called before the first frame update
    void Start()
    {
        AssignOne();
        AssignTwo();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q) && !buttonClicked1)
        {
            buttonClicked1 = true;
            if (correctA1)
            {
                mGB.MovePlayer1();
                correctA1 = false;
                AssignOne();
            }
        }
        else if (Input.GetKey(KeyCode.W) && !buttonClicked1)
        {
            buttonClicked1 = true;
            if (correctB1) 
            {
            mGB.MovePlayer1();
            correctB1 = false;
            AssignOne();
            }
        }
        else if(Input.GetKey(KeyCode.A) && !buttonClicked1)
        {
            buttonClicked1 = true;
            if (correctC1)
            {
                mGB.MovePlayer1();
                correctC1 = false;
                AssignOne();
            }
        }
        else if(Input.GetKey(KeyCode.S) && !buttonClicked1)
        {
            buttonClicked1 = true;
            if (correctD1)
            {
                mGB.MovePlayer1();
                correctD1 = false;
                AssignOne();
            }
        }

        if (Input.GetKey(KeyCode.I) && !buttonClicked2)
        {
            buttonClicked2 = true;
            {
                mGB.MovePlayer2();
                correctA2 = false;
                AssignTwo();
            }
        }
        else if (Input.GetKey(KeyCode.O) && !buttonClicked2)
        {
            buttonClicked2 = true;
            if (correctB2)
            {
                mGB.MovePlayer2();
                correctB2 = false;
                AssignTwo();
            }
        }
        else if (Input.GetKey(KeyCode.K) && !buttonClicked2)
        {
            buttonClicked2 = true;
            if (correctC2)
            {
                mGB.MovePlayer2();
                correctC2 = false;
                AssignTwo();
            }
        }
        else if (Input.GetKey(KeyCode.L) && !buttonClicked2)
        {
            buttonClicked2 = true;
            if (correctD2)
            {
                mGB.MovePlayer2();
                correctD2 = false;
                AssignTwo();
            }
        }
        if (buttonClicked1)
        {
            t1 += Time.deltaTime;
            if(t1 > 1)
            {
                t1 = 0;
                buttonClicked1 = false;
            }
        }
        if (buttonClicked2)
        {
            t2 += Time.deltaTime;
            if (t2 > 1)
            {
                t2 = 0;
                buttonClicked2 = false;
            }
        }
    }

    void AssignOne()
    {
        assignOne = true;
        RandomCall();
        RandomizeChoice();
        question1.text = rH.question;
        assignOne = false;
        A1.text = "<b>Q:</b> " + A1.text;
        B1.text = "<b>W: </b>" + B1.text;
        C1.text = "<b>A: </b>" + C1.text;
        D1.text = "<b>S: </b>" + D1.text;
    }

    void AssignTwo()
    {
        assignTwo = true;
        RandomCall();
        RandomizeChoice();
        question2.text = rH.question;
        assignTwo = false;
        A2.text = "<b>I: </b>" + A2.text;
        B2.text = "<b>O: </b>" + B2.text;
        C2.text = "<b>K: </b>" + C2.text;
        D2.text = "<b>L: </b>" + D2.text;
    }

    void RandomizeChoice()
    {
        if (assignOne)
        {
            if (mathQuestion)
            {
                num = Random.Range(0, 10);


                if (num == 0)
                {
                    A1.text = rH.z.ToString();
                    B1.text = (rH.z + 1).ToString();
                    C1.text = (rH.x).ToString();
                    D1.text = (Random.Range(0, 150)).ToString();
                    if (D1.text == rH.z.ToString())
                    {
                        D1.text = (rH.z + 4).ToString();
                    }
                    correctA1 = true;
                }
                else if (num == 1)
                {
                    B1.text = rH.z.ToString();
                    A1.text = (rH.z + 1).ToString();
                    C1.text = (rH.x + 2).ToString();
                    D1.text = (Random.Range(0, 150)).ToString();
                    if (D1.text == rH.z.ToString())
                    {
                        D1.text = (rH.z + 4).ToString();
                    }
                    correctB1 = true;
                }
                else if (num == 2)
                {
                    C1.text = rH.z.ToString();
                    B1.text = (rH.z + 1).ToString();
                    A1.text = (rH.x + 2).ToString();
                    D1.text = (Random.Range(0, 150)).ToString();
                    if (D1.text == rH.z.ToString())
                    {
                        D1.text = (rH.z + 4).ToString();
                    }
                    correctC1 = true;
                }
                else if (num == 3)
                {
                    D1.text = rH.z.ToString();
                    B1.text = (rH.z + 1).ToString();
                    C1.text = (rH.x + 2).ToString();
                    A1.text = (Random.Range(0, 150)).ToString();
                    if (A1.text == rH.z.ToString())
                    {
                        A1.text = (rH.z + 4).ToString();
                    }
                    correctD1 = true;
                }
                else if (num == 4)
                {
                    A1.text = rH.z.ToString();
                    C1.text = (rH.z + 1).ToString();
                    B1.text = (rH.x + 2).ToString();
                    D1.text = (Random.Range(0, 150)).ToString();
                    if (D1.text == rH.z.ToString())
                    {
                        D1.text = (rH.z + 4).ToString();
                    }
                    correctA1 = true;
                }
                else if (num == 5)
                {
                    A1.text = rH.z.ToString();
                    D1.text = (rH.z + 1).ToString();
                    C1.text = (rH.x + 2).ToString();
                    B1.text = (Random.Range(0, 150)).ToString();
                    if (B1.text == rH.z.ToString())
                    {
                        B1.text = (rH.z + 4).ToString();
                    }
                    correctA1 = true;
                }
                else if (num == 6)
                {
                    A1.text = rH.z.ToString();
                    B1.text = (rH.z + 1).ToString();
                    D1.text = (rH.x + 2).ToString();
                    C1.text = (Random.Range(0, 150)).ToString();
                    if (C1.text == rH.z.ToString())
                    {
                        C1.text = (rH.z + 4).ToString();
                    }
                    correctA1 = true;
                }
                else if (num == 7)
                {
                    B1.text = rH.z.ToString();
                    C1.text = (rH.z + 1).ToString();
                    D1.text = (rH.x + 2).ToString();
                    A1.text = (Random.Range(0, 150)).ToString();
                    if (A1.text == rH.z.ToString())
                    {
                        A1.text = (rH.z + 4).ToString();
                    }
                    correctB1 = true;
                }
                else if (num == 8)
                {
                    C1.text = rH.z.ToString();
                    D1.text = (rH.z + 1).ToString();
                    A1.text = (rH.x + 2).ToString();
                    B1.text = (Random.Range(0, 150)).ToString();
                    if (B1.text == rH.z.ToString())
                    {
                        B1.text = (rH.z + 4).ToString();
                    }
                    correctC1 = true;
                }
                else if (num == 9)
                {
                    D1.text = rH.z.ToString();
                    A1.text = (rH.z + 1).ToString();
                    B1.text = (rH.x + 2).ToString();
                    C1.text = (Random.Range(0, 150)).ToString();
                    if (C1.text == rH.z.ToString())
                    {
                        C1.text = (rH.z + 4).ToString();
                    }
                    correctD1 = true;
                }
            }
            else
            {
                num = Random.Range(0, 2);
                if(num == 0)
                {
                    A1.text = rH.answer1;
                    B1.text = rH.answer2;
                    C1.text = "";
                    D1.text = "";
                    correctA1 = true;
                }
                else
                {
                    B1.text = rH.answer1;
                    A1.text = rH.answer2;
                    C1.text = "";
                    D1.text = "";
                    correctB1 = true;
                }
                //num = Random.Range(0, 10);
                //if (num == 0)
                //{
                //    A1.text = rH.answer1;
                //    B1.text = rH.answer2;
                //    C1.text = rH.answer3;
                //    D1.text = rH.answer4;
                //    correctA1 = true;
                //}
                //else if (num == 1)
                //{
                //    B1.text = rH.answer1;
                //    A1.text = rH.answer2;
                //    C1.text = rH.answer3;
                //    D1.text = rH.answer4;
                //    correctB1 = true;
                //}
                //else if (num == 2)
                //{
                //    C1.text = rH.answer1;
                //    B1.text = rH.answer2;
                //    A1.text = rH.answer3;
                //    D1.text = rH.answer4;
                //    correctC1 = true;
                //}
                //else if (num == 3)
                //{
                //    D1.text = rH.answer1;
                //    B1.text = rH.answer2;
                //    C1.text = rH.answer3;
                //    A1.text = rH.answer4;
                //    correctD1 = true;
                //}
                //else if (num == 4)
                //{
                //    A1.text = rH.answer1;
                //    C1.text = rH.answer2;
                //    B1.text = rH.answer3;
                //    D1.text = rH.answer4;
                //    correctA1 = true;
                //}
                //else if (num == 5)
                //{
                //    A1.text = rH.answer1;
                //    D1.text = rH.answer2;
                //    C1.text = rH.answer3;
                //    B1.text = rH.answer4;
                //    correctA1 = true;
                //}
                //else if (num == 6)
                //{
                //    A1.text = rH.answer1;
                //    B1.text = rH.answer2;
                //    D1.text = rH.answer3;
                //    C1.text = rH.answer4;
                //    correctA1 = true;
                //}
                //else if (num == 7)
                //{
                //    B1.text = rH.answer1;
                //    C1.text = rH.answer2;
                //    D1.text = rH.answer3;
                //    A1.text = rH.answer4;
                //    correctB1 = true;
                //}
                //else if (num == 8)
                //{
                //    C1.text = rH.answer1;
                //    D1.text = rH.answer2;
                //    A1.text = rH.answer3;
                //    B1.text = rH.answer4;
                //    correctC1 = true;
                //}
                //else if (num == 9)
                //{
                //    D1.text = rH.answer1;
                //    A1.text = rH.answer2;
                //    B1.text = rH.answer3;
                //    C1.text = rH.answer4;
                //    correctD1 = true;
                //}
            }
        }
        if (assignTwo)
        {
            if (mathQuestion)
            {
                num = Random.Range(0, 10);


                if (num == 0)
                {
                    A2.text = rH.z.ToString();
                    B2.text = (rH.z + 1).ToString();
                    C2.text = (rH.x + 2).ToString();
                    D2.text = (Random.Range(0, 150)).ToString();
                    if (D2.text == rH.z.ToString())
                    {
                        D2.text = (rH.z + 4).ToString();
                    }
                    correctA2 = true;
                }
                else if (num == 1)
                {
                    B2.text = rH.z.ToString();
                    A2.text = (rH.z + 1).ToString();
                    C2.text = (rH.x + 2).ToString();
                    D2.text = (Random.Range(0, 150)).ToString();
                    if (D2.text == rH.z.ToString())
                    {
                        D2.text = (rH.z + 4).ToString();
                    }
                    correctB2 = true;
                }
                else if (num == 2)
                {
                    C2.text = rH.z.ToString();
                    B2.text = (rH.z + 1).ToString();
                    A2.text = (rH.x + 2).ToString();
                    D2.text = (Random.Range(0, 150)).ToString();
                    if (D2.text == rH.z.ToString())
                    {
                        D2.text = (rH.z + 4).ToString();
                    }
                    correctC2 = true;
                }
                else if (num == 3)
                {
                    D2.text = rH.z.ToString();
                    B2.text = (rH.z + 1).ToString();
                    C2.text = (rH.x + 2).ToString();
                    A2.text = (Random.Range(0, 150)).ToString();
                    if (A2.text == rH.z.ToString())
                    {
                        A2.text = (rH.z + 4).ToString();
                    }
                    correctD2 = true;
                }
                else if (num == 4)
                {
                    A2.text = rH.z.ToString();
                    C2.text = (rH.z + 1).ToString();
                    B2.text = (rH.x + 2).ToString();
                    D2.text = (Random.Range(0, 150)).ToString();
                    if (D2.text == rH.z.ToString())
                    {
                        D2.text = (rH.z + 4).ToString();
                    }
                    correctA2 = true;
                }
                else if (num == 5)
                {
                    A2.text = rH.z.ToString();
                    D2.text = (rH.z + 1).ToString();
                    C2.text = (rH.x + 2).ToString();
                    B2.text = (Random.Range(0, 150)).ToString();
                    if (B2.text == rH.z.ToString())
                    {
                        B2.text = (rH.z + 4).ToString();
                    }
                    correctA2 = true;
                }
                else if (num == 6)
                {
                    A2.text = rH.z.ToString();
                    B2.text = (rH.z + 1).ToString();
                    D2.text = (rH.x + 2).ToString();
                    C2.text = (Random.Range(0, 150)).ToString();
                    if (C2.text == rH.z.ToString())
                    {
                        C2.text = (rH.z + 4).ToString();
                    }
                    correctA2 = true;
                }
                else if (num == 7)
                {
                    B2.text = rH.z.ToString();
                    C2.text = (rH.z + 1).ToString();
                    D2.text = (rH.x + 2).ToString();
                    A2.text = (Random.Range(0, 150)).ToString();
                    correctB2 = true;
                    if (A2.text == rH.z.ToString())
                    {
                        A2.text = (rH.z + 4).ToString();
                    }
                }
                else if (num == 8)
                {
                    C2.text = rH.z.ToString();
                    D2.text = (rH.z + 1).ToString();
                    A2.text = (rH.x + 2).ToString();
                    B2.text = (Random.Range(0, 150)).ToString();
                    if (B2.text == rH.z.ToString())
                    {
                        B2.text = (rH.z + 4).ToString();
                    }
                    correctC2 = true;
                }
                else if (num == 9)
                {
                    D2.text = rH.z.ToString();
                    A2.text = (rH.z + 1).ToString();
                    B2.text = (rH.x + 2).ToString();
                    C2.text = (Random.Range(0, 150)).ToString();
                    if(C2.text == rH.z.ToString())
                    {
                        C2.text = (rH.z + 4).ToString();
                    }
                    correctD2 = true;
                }
            }
            else
            {
                num = Random.Range(0, 2);
                if (num == 0)
                {
                    A2.text = rH.answer1;
                    B2.text = rH.answer2;
                    C2.text = "";
                    D2.text = "";
                    correctA2 = true;
                }
                else
                {
                    B2.text = rH.answer1;
                    A2.text = rH.answer2;
                    C2.text = "";
                    D2.text = "";
                    correctB2 = true;
                }
                //num = Random.Range(0, 10);
                //if (num == 0)
                //{
                //    A2.text = rH.answer1;
                //    B2.text = rH.answer2;
                //    C2.text = rH.answer3;
                //    D2.text = rH.answer4;
                //    correctA2 = true;
                //}
                //else if (num == 1)
                //{
                //    B2.text = rH.answer1;
                //    A2.text = rH.answer2;
                //    C2.text = rH.answer3;
                //    D2.text = rH.answer4;
                //    correctB2 = true;
                //}
                //else if (num == 2)
                //{
                //    C2.text = rH.answer1;
                //    B2.text = rH.answer2;
                //    A2.text = rH.answer3;
                //    D2.text = rH.answer4;
                //    correctC2 = true;
                //}
                //else if (num == 3)
                //{
                //    D2.text = rH.answer1;
                //    B2.text = rH.answer2;
                //    C2.text = rH.answer3;
                //    A2.text = rH.answer4;
                //    correctD2 = true;
                //}
                //else if (num == 4)
                //{
                //    A2.text = rH.answer1;
                //    C2.text = rH.answer2;
                //    B2.text = rH.answer3;
                //    D2.text = rH.answer4;
                //    correctA2 = true;
                //}
                //else if (num == 5)
                //{
                //    A2.text = rH.answer1;
                //    D2.text = rH.answer2;
                //    C2.text = rH.answer3;
                //    B2.text = rH.answer4;
                //    correctA2 = true;
                //}
                //else if (num == 6)
                //{
                //    A2.text = rH.answer1;
                //    B2.text = rH.answer2;
                //    D2.text = rH.answer3;
                //    C2.text = rH.answer4;
                //    correctA2 = true;
                //}
                //else if (num == 7)
                //{
                //    B2.text = rH.answer1;
                //    C2.text = rH.answer2;
                //    D2.text = rH.answer3;
                //    A2.text = rH.answer4;
                //    correctB2 = true;
                //}
                //else if (num == 8)
                //{
                //    C2.text = rH.answer1;
                //    D2.text = rH.answer2;
                //    A2.text = rH.answer3;
                //    B2.text = rH.answer4;
                //    correctC2 = true;
                //}
                //else if (num == 9)
                //{
                //    D2.text = rH.answer1;
                //    A2.text = rH.answer2;
                //    B2.text = rH.answer3;
                //    C2.text = rH.answer4;
                //    correctD2 = true;
                //}
            }
        }
    }

    void RandomCall()
    {
        num = Random.Range(0, 5);
        switch (num)
        {
            case 4:
                rH.MathAdd();
                mathQuestion = true;
                break;
            case 3:
                rH.MathSubtract();
                mathQuestion = true;
                break;
            case 2:
                rH.MathMultiply();
                mathQuestion = true;
                break;
            case 1:
                rH.MathDivide();
                mathQuestion = true;
                break;
            default:
                rH.GreekQuestion();
                mathQuestion = false;
                break;
        }
    }
}
