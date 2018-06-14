using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GalgjeScript : MonoBehaviour
{
    public string[] Alphabet = new string[26]
    {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V",
        "W", "X", "Y", "Z"
    };


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

    // Use this for initialization
    private void Start()
    {
      
        startingGalgje();
        currentWord = words[Random.Range(0,words.Length)];
        sizeWord = currentWord.Length;


        for (var i = 0; i < sizeWord; i++) wordLetters.Add(currentWord[i]);
    }


    // Update is called once per frame
    private void Update()
    {
    }

    private void startingGalgje()
    {
        var test2 = GameObject.Find("Canvas/Buttons");

        for (var i = 0; i < test2.transform.childCount; i++) inputButtons.Add(test2.transform.GetChild(i).gameObject);
        for (int i = 0; i < inputButtons.Count; i++)
        {
            inputButtons[i].transform.GetChild(0).GetComponent<Text>().text = Alphabet[i];
        }
    }


    private void CheckWord()
    {
        
        
            
        
      

        if (textVakken[textvaknummer].text == currentWord[textvaknummer].ToString())
        {
            
            if (gameDone != true)
            {
                textvaknummer = textvaknummer + 1;

            }
        }
        else
        {
            if (gameDone != true)
            {
                galgje[galgjeNummer].GetComponent<MeshRenderer>().enabled = true;
                galgjeNummer = galgjeNummer + 1;
                if (galgjeNummer >= galgje.Count)
                {
                    gameDone = true;
                }
            }
           
        }
        
        
        Debug.Log(wrongLetters);
        inputLetter = null;
    }

    public void Buttons(int letter)
    {
        switch (letter)
        {
            case 1:
                textVakken[textvaknummer].text = "A";
                CheckWord();
                break;
            case 2:
                textVakken[textvaknummer].text = "B";
                CheckWord();

                break;
            case 3:
                textVakken[textvaknummer].text = "C";
                CheckWord();
                break;
            case 4:
                textVakken[textvaknummer].text = "D";
                CheckWord();
                break;
            case 5:
                textVakken[textvaknummer].text = "E";
                CheckWord();
                break;
            case 6:
                textVakken[textvaknummer].text = "F";
                CheckWord();
                break;
            case 7:
                textVakken[textvaknummer].text = "G";
                CheckWord();
                break;
            case
                8:
                textVakken[textvaknummer].text = "H";
                CheckWord();
                break;
            case 9:
                textVakken[textvaknummer].text = "I";
                CheckWord();
                break;
            case 10:
                textVakken[textvaknummer].text = "J";
                CheckWord();
                break;
            case 11:
                textVakken[textvaknummer].text = "K";
                CheckWord();
                break;
            case 12:
                textVakken[textvaknummer].text = "L";
                CheckWord();
                break;
            case 13:
                textVakken[textvaknummer].text = "M";
                CheckWord();
                break;
            case 14:
                textVakken[textvaknummer].text = "N";
                CheckWord();
                break;
            case 15:
                textVakken[textvaknummer].text = "O";
                CheckWord();
                break;
            case 16:
                textVakken[textvaknummer].text = "P";
                CheckWord();
                break;
            case 17:
                textVakken[textvaknummer].text = "Q";
                CheckWord();
                break;
            case 18:
                textVakken[textvaknummer].text = "R";
                CheckWord();
                break;
            case 19:
                textVakken[textvaknummer].text = "S";
                CheckWord();
                break;
            case 20:
                textVakken[textvaknummer].text = "T";
                CheckWord();
                break;
            case 21:
                textVakken[textvaknummer].text = "U";
                CheckWord();
                break;
            case 22:
                textVakken[textvaknummer].text = "V";
                CheckWord();
                break;
            case 23:
                textVakken[textvaknummer].text = "W";
                CheckWord();
                break;
            case 24:
                textVakken[textvaknummer].text = "X";
                CheckWord();
                break;
            case 25:
                textVakken[textvaknummer].text = "Y";
                CheckWord();
                break;
            case 26:
                textVakken[textvaknummer].text = "Z";
                CheckWord();
                break;
        }
    }
}