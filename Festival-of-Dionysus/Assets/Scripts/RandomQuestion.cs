using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomQuestion : MonoBehaviour
{
    public int x, y, z, temp/*, num*/;
    public string question, answer1, answer2, answer3, answer4;/*, answerA, answerB, answerC, answerD;*/
    //public bool correctA, correctB, correctC, correctD, questionAsked;
    //RangeInt rnd = new RangeInt();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void MathAdd()
    {
        x = Random.Range(1, 51);
        y = Random.Range(0, 51);
        Debug.Log(x + " + " + y + " = ");
        z = x + y;
        Debug.Log(z);
        question = "What is " + x + " + " + y;

    }
    public void MathSubtract()
    {
        x = Random.Range(1, 51);
        y = Random.Range(0, 51);
        Debug.Log(x + " - " + y + " = ");
        if (x - y > 0)
        {
            z = x - y;
        }
        else if (x - y < 0)
        {
            temp = x;
            x = y;
            y = temp;
            z = x - y;

        }
        question = "What is " + x + " - " + y;
        Debug.Log(z);

    }
    public void MathMultiply()
    {
        x = Random.Range(0, 10);
        y = Random.Range(1, 10);
        z = x * y;
        Debug.Log(x + " x " + y + " = ");
        Debug.Log(z);
        question = "What is " + x + " x " + y;
    }

    public void MathDivide()
    {
        x = Random.Range(1, 12);
        y = Random.Range(2, 11);
        z = x * y;
        int temp = z;
        z = x;
        x = temp;
        if (z == 0 && x != y)
        {
            MathDivide();
            Debug.Log("rerun");
        }
        Debug.Log(x + " / " + y + " = ");
        Debug.Log(z);
        question = "What is " + x + " / " + y;
    }

    public void GreekQuestion()
    {
        z = Random.Range(0, 19);
        switch (z)
        {
            case 18:
                question = "The Greeks held the olympics in";
                answer1 = "Honor of the Gods";
                answer2 = "Contempt of the Gods";
                answer3 = "Honor of the Titans";
                answer4 = "Honor of Gilgamesh";
                break;
            case 17:
                question = "Who was the king of the gods?";
                answer1 = "Zeus";
                answer2 = "Hades";
                answer3 = "Poseidon";
                answer4 = "No one.";
                break;
            case 16:
                question = "Athen was the goddess of ";
                answer1 = "Both Wisdom and War";
                answer2 = "Wisdom";
                answer3 = "War";
                answer4 = "Neither wisdom nor war";
                break;
            case 15:
                question = "Apollo was the god of";
                answer1 = "Music and the Sun";
                answer2 = "Chaos";
                answer3 = "the Sun";
                answer4 = "Light";
                break;
            case 14:
                question = "Artemis was the god of ";
                answer1 = "The Moon and Hunters";
                answer2 = "The Sun and Music";
                answer3 = "Chastity";
                answer4 = "Hunters";
                break;
            case 13:
                question = "Who did Hades marry?";
                answer1 = "Persephone";
                answer2 = "Hera";
                answer3 = "Hermes";
                answer4 = "Aphrodite";
                break;
            case 12:
                question = "Whose return to the underworld causes winter?";
                answer1 = "Persephone";
                answer2 = "Hades";
                answer3 = "Demeter";
                answer4 = "Zeus";
                break;
            case 11:
                question = "Who was the goddess of the harvest?";
                answer1 = "Demeter";
                answer2 = "Hera";
                answer3 = "Persephone";
                answer4 = "Aphrodite";
                break;
            case 10:
                question = "Ares was the god of ";
                answer1 = "War";
                answer2 = "Tactics";
                answer3 = "The Forge";
                answer4 = "Video Games";
                break;
            case 9:
                question = "Hera was the goddess of ";
                answer1 = "Marriage";
                answer2 = "Love";
                answer3 = "The Forge";
                answer4 = "Jealousy";
                break;
            case 8:
                question = "Who was the god of the sea?";
                answer1 = "Poseidon";
                answer2 = "Zeus";
                answer3 = "Hades";
                answer4 = "Cronus";
                break;
            case 7:
                question = "Who was the god of wine?";
                answer1 = "Dionysus";
                answer2 = "Zeus";
                answer3 = "Hera";
                answer4 = "Poseidon";
                break;
            case 6:
                question = "Who was the messenger of the gods?";
                answer1 = "Hermes";
                answer2 = "Hera";
                answer3 = "Hades";
                answer4 = "Hephaestus";
                break;
            case 5:
                question = "Who was the god of the skies?";
                answer1 = "Zeus";
                answer2 = "Hera";
                answer3 = "Hades";
                answer4 = "Poseidon";
                break;
            case 4:
                question = "Who was the god of the underworld?";
                answer1 = "Hades";
                answer2 = "Zeus";
                answer3 = "Poseidon";
                answer4 = "Apollo";
                break;
            case 3:
                question = "Who is the god of the sun?";
                answer1 = "Apollo";
                answer2 = "Artemis";
                answer3 = "Aphrodite";
                answer4 = "Hephaestus";
                break;
            case 2:
                question = "Who is the god of the forge?";
                answer1 = "Hephaestus";
                answer2 = "Hades";
                answer3 = "Aphrodite";
                answer4 = "Hermes";
                break;
            case 1:
                question = "Who is the godess of love?";
                answer1 = "Aphrodite";
                answer2 = "Athena";
                answer3 = "Apollo";
                answer4 = "Hera";
                break;
            default:
                question = "Who is the son of Zeus?";
                answer1 = "Heracles";
                answer2 = "Hunkules";
                answer3 = "Hercules";
                answer4 = "Harold";
                break;
        }
    }
}