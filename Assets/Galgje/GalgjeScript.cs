using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
    private string[] words = new string[] {"HALLO","WATER","KOELKAST","DRINKEN","RIDDER","AUTO","OVEN", };
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
                amountCorrect = amountCorrect + 1;
            }

            
        }

        if (amountCorrect == 0)
        {
            galgje[galgjeNummer].GetComponent<SpriteRenderer>().enabled = true;
            galgjeNummer = galgjeNummer + 1;
           

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
                inputButtons[0].GetComponent<Button>().interactable = false;
                ;
                break;
            case 2:
                inputLetter = "B";
                CheckWord();
                inputButtons[1].GetComponent<Button>().interactable = false;

                break;
            case 3:
                inputLetter = "C";
                CheckWord();
                inputButtons[2].GetComponent<Button>().interactable = false;

                break;
            case 4:
                inputLetter = "D";
                CheckWord();
                inputButtons[3].GetComponent<Button>().interactable = false;

                break;
            case 5:
                inputLetter = "E";
                CheckWord();
                inputButtons[4].GetComponent<Button>().interactable = false;

                break;
            case 6:
                inputLetter = "F";
                CheckWord();
                inputButtons[5].GetComponent<Button>().interactable = false;

                break;
            case 7:
                inputLetter = "G";
                CheckWord();
                inputButtons[6].GetComponent<Button>().interactable = false;

                break;
            case
                8:
                inputLetter = "H";
                CheckWord();
                inputButtons[7].GetComponent<Button>().interactable = false;

                break;
            case 9:
                inputLetter = "I";
                CheckWord();
                inputButtons[8].GetComponent<Button>().interactable = false;

                break;
            case 10:
                inputLetter = "J";
                CheckWord();
                inputButtons[9].GetComponent<Button>().interactable = false;

                break;
            case 11:
                inputLetter = "K";
                CheckWord();
                inputButtons[10].GetComponent<Button>().interactable = false;

                break;
            case 12:
                inputLetter = "L";
                CheckWord();
                inputButtons[11].GetComponent<Button>().interactable = false;

                break;
            case 13:
                inputLetter = "M";
                CheckWord();
                inputButtons[12].GetComponent<Button>().interactable = false;

                break;
            case 14:
                inputLetter = "N";
                CheckWord();
                inputButtons[13].GetComponent<Button>().interactable = false;

                break;
            case 15:
                inputLetter = "O";
                CheckWord();
                inputButtons[14].GetComponent<Button>().interactable = false;

                break;
            case 16:
                inputLetter = "P";
                CheckWord();
                inputButtons[15].GetComponent<Button>().interactable = false;

                break;
            case 17:
                inputLetter = "Q";
                CheckWord();
                inputButtons[16].GetComponent<Button>().interactable = false;

                break;
            case 18:
                inputLetter = "R";
                CheckWord();
                inputButtons[17].GetComponent<Button>().interactable = false;

                break;
            case 19:
                inputLetter = "S";
                CheckWord();
                inputButtons[18].GetComponent<Button>().interactable = false;

                break;
            case 20:
                inputLetter = "T";
                CheckWord();
                inputButtons[19].GetComponent<Button>().interactable = false;

                break;
            case 21:
                inputLetter = "U";
                CheckWord();
                inputButtons[20].GetComponent<Button>().interactable = false;

                break;
            case 22:
                inputLetter = "V";
                CheckWord();
                inputButtons[21].GetComponent<Button>().interactable = false;

                break;
            case 23:
                inputLetter = "W";
                CheckWord();
                inputButtons[22].GetComponent<Button>().interactable = false;

                break;
            case 24:
                inputLetter = "X";
                CheckWord();
                inputButtons[23].GetComponent<Button>().interactable = false;

                break;
            case 25:
                inputLetter = "Y";
                CheckWord();
                inputButtons[24].GetComponent<Button>().interactable = false;

                break;
            case 26:
                inputLetter = "Z";
                CheckWord();
                inputButtons[25].GetComponent<Button>().interactable = false;

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