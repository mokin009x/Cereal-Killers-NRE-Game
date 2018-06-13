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

    // Use this for initialization
    private void Start()
    {
      
        startingGalgje();
        currentWord = "ABAB";
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
            textvaknummer = textvaknummer + 1;
            
           
        }
        else
        {
            galgje[galgjeNummer].GetComponent<MeshRenderer>().enabled = true;
            galgjeNummer = galgjeNummer + 1;
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
                theWord.text = theWord.text + "F";
                CheckWord();
                break;
            case 7:
                theWord.text = theWord.text + "G";
                CheckWord();
                break;
            case
                8:
                theWord.text = theWord.text + "H";
                CheckWord();
                break;
            case 9:
                theWord.text = theWord.text + "I";
                CheckWord();
                break;
            case 10:
                theWord.text = theWord.text + "J";
                CheckWord();
                break;
            case 11:
                theWord.text = theWord.text + "K";
                CheckWord();
                break;
            case 12:
                theWord.text = theWord.text + "L";
                CheckWord();
                break;
            case 13:
                theWord.text = theWord.text + "M";
                CheckWord();
                break;
            case 14:
                theWord.text = theWord.text + "N";
                CheckWord();
                break;
            case 15:
                theWord.text = theWord.text + "O";
                CheckWord();
                break;
            case 16:
                theWord.text = theWord.text + "P";
                CheckWord();
                break;
            case 17:
                theWord.text = theWord.text + "Q";
                CheckWord();
                break;
            case 18:
                theWord.text = theWord.text + "R";
                CheckWord();
                break;
            case 19:
                theWord.text = theWord.text + "S";
                CheckWord();
                break;
            case 20:
                theWord.text = theWord.text + "T";
                CheckWord();
                break;
            case 21:
                theWord.text = theWord.text + "U";
                CheckWord();
                break;
            case 22:
                theWord.text = theWord.text + "V";
                CheckWord();
                break;
            case 23:
                theWord.text = theWord.text + "W";
                CheckWord();
                break;
            case 24:
                theWord.text = theWord.text + "X";
                CheckWord();
                break;
            case 25:
                theWord.text = theWord.text + "Y";
                CheckWord();
                break;
            case 26:
                theWord.text = theWord.text + "Z";
                CheckWord();
                break;
        }
    }
}