using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;
using Image = UnityEngine.UI.Image;

public class GalgjeScript : MonoBehaviour
{
    public string[] Alphabet = new string[26]
    {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V",
        "W", "X", "Y", "Z"
    };


    public AudioSource hoverSound;
    public AudioSource winningSound;
    public AudioSource losingSound;
    private string[] words = new string[] {"HALLO","WATER","KOELKAST","DRINKEN","RIDDER" };
    public string currentWord; //dit is het woord dat je moet raden
    public List<GameObject> inputButtons;
    public string inputLetter;

    public int sizeWord;
    public InputField theWord;
    public List<char> wordLetters;

    public List<int> wrongLetters;
    public List<Text> textVakken;
    public int textvaknummer = 0;
    public int galgjeNummer=0;

    public List<GameObject> galgje;
    public bool gameDone = false;

    public int amountCorrect = 0;
    public int test = 0;

    public NedTextScript NPC_Refference;
    
    public Button showWordEnd;
    public GameObject showWordEndobj;

    // Use this for initialization
    private void Start()
    {
        NPC_Refference = GameObject.Find("Main Camera").GetComponent<NedTextScript>();
        startingGalgje();
        currentWord = words[Random.Range(0,words.Length)];
        sizeWord = currentWord.Length;
        showWordEnd.GetComponentInChildren<Text>().text += currentWord;
        showWordEndobj.SetActive(false);

        for (var i = 0; i < sizeWord; i++)
        {
            
            wordLetters.Add(currentWord[i]);
            textVakken[i].GetComponentInParent<Image>().enabled = true;
        }
    }


    // Update is called once per frame
    private void Update()
    {
    }


    public void HoverSound()
    {
        hoverSound.Play();
    }

    private void startingGalgje()
    {
        var test2 = GameObject.Find("Canvas/StartGameObject/Buttons");
        NPC_Refference.TurnOffUi();
        for (var i = 0; i < test2.transform.childCount; i++) inputButtons.Add(test2.transform.GetChild(i).gameObject);
        for (int i = 0; i < inputButtons.Count; i++)
        {
            inputButtons[i].transform.GetChild(0).GetComponent<Text>().text = Alphabet[i];
        }
        
    }


    private void CheckWord()
    {
        bool incorrect = false;
        for (int i = 0; i < currentWord.Length; i++)
        {
            if (currentWord[i].ToString() == inputLetter)
            {
                textVakken[i].text = inputLetter;
                Debug.Log(inputLetter);
                Debug.Log(textVakken[i].text);
                amountCorrect = amountCorrect + 1;
            }

            
        }

        if (amountCorrect == 0)
        {
            galgje[galgjeNummer].GetComponent<SpriteRenderer>().enabled = true;
            galgjeNummer = galgjeNummer + 1;
            if (galgjeNummer >= galgje.Count)
            {
               Debug.Log("done");            
            }

        }

        amountCorrect = 0;
        inputLetter = null;
    }

    public void TestingCheck()
    {
        test = 0;
        for (int i = 0; i < sizeWord; i++)
        {
            if (textVakken[i].text == currentWord[i].ToString())
            {
                test = test + 1;
            }
        }
    }

    public void GameEndRight()
    {
        for (int i = 0; i < NPC_Refference.NPC_Begin.Length; i++)
        {
            NPC_Refference.NPC_Begin[i].SetActive(true);

        }
        
            NPC_Refference.gameStart.SetActive(false);

        
        NPC_Refference.string0 = "dankje, maar mijn bae heeft me nog steeds verlaten. Blijkbaar praat ik teveel over voetbal. Hier is mijn huis.";
       NPC_Refference.RestartText();
        Debug.Log("Right"); 
        showWordEndobj.SetActive(true);
        Singleton.Score = Singleton.Score + 10;
        winningSound.Play();


    }

    public void GameEndWrong()
    {
        for (int i = 0; i < NPC_Refference.NPC_Begin.Length; i++)
        {
            NPC_Refference.NPC_Begin[i].SetActive(true);

        }
            NPC_Refference.gameStart.SetActive(false);

        NPC_Refference.string0 = "Ik heb per ongeluk mijn bae vermoord. Nu word ik levend begraven, maar ik word een geest en ga je lastig vallen xoxo. Je hebt een huis verloren. ";
        NPC_Refference.RestartText();
        Debug.Log("Wrong"); 
        showWordEndobj.SetActive(true);
        Singleton.Score = Singleton.Score - 10;
        losingSound.Play();

    }

    public void Buttons(int letter)
    {
        switch (letter)
        {
            case 1:
                inputLetter = "A";
                CheckWord();
                break;
            case 2:
                inputLetter = "B";
                CheckWord();

                break;
            case 3:
                inputLetter = "C";
                CheckWord();
                break;
            case 4:
                inputLetter = "D";
                CheckWord();
                break;
            case 5:
                inputLetter = "E";
                CheckWord();
                break;
            case 6:
                inputLetter = "F";
                CheckWord();
                break;
            case 7:
                inputLetter = "G";
                CheckWord();
                break;
            case
                8:
                inputLetter = "H";
                CheckWord();
                break;
            case 9:
                inputLetter = "I";
                CheckWord();
                break;
            case 10:
                inputLetter = "J";
                CheckWord();
                break;
            case 11:
                inputLetter = "K";
                CheckWord();
                break;
            case 12:
                inputLetter = "L";
                CheckWord();
                break;
            case 13:
                inputLetter = "M";
                CheckWord();
                break;
            case 14:
                inputLetter = "N";
                CheckWord();
                break;
            case 15:
                inputLetter = "O";
                CheckWord();
                break;
            case 16:
                inputLetter = "P";
                CheckWord();
                break;
            case 17:
                inputLetter = "Q";
                CheckWord();
                break;
            case 18:
                inputLetter = "R";
                CheckWord();
                break;
            case 19:
                inputLetter = "S";
                CheckWord();
                break;
            case 20:
                inputLetter = "T";
                CheckWord();
                break;
            case 21:
                inputLetter = "U";
                CheckWord();
                break;
            case 22:
                inputLetter = "V";
                CheckWord();
                break;
            case 23:
                inputLetter = "W";
                CheckWord();
                break;
            case 24:
                inputLetter = "X";
                CheckWord();
                break;
            case 25:
                inputLetter = "Y";
                CheckWord();
                break;
            case 26:
                inputLetter = "Z";
                CheckWord();
                break;
        }

        TestingCheck();
        if (test == sizeWord)
        {
            GameEndRight();
        }

        if (galgjeNummer == galgje.Count)
        {
            GameEndWrong();
        }
        
    }
}