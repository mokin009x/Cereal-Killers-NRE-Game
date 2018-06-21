using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UI;

public class LingoScript : MonoBehaviour
{
	public bool gameDone = false;
	public List<GameObject> invulVakkenKans1 = new List<GameObject>();
	public List<GameObject> invulVakkenKans2 = new List<GameObject>();
	public List<GameObject> invulVakkenKans3 = new List<GameObject>();
	public List<GameObject> invulVakkenKans4 = new List<GameObject>();
	public List<GameObject> invulVakkenKans5 = new List<GameObject>();

	public List<List<GameObject>> invulKansen = new List<List<GameObject>>();
	
	private string[] words = new string[] {"about","above","exact","globe","mayor","round","usage"};
	public string theWord;
	public List<char> wordLetters;
	public int currentRow= 0;
	public int amountCorrect;
	public List<string> correctLetters;
	public TextEng NPC_Refference;
	public Button showWordEnd;
	public GameObject showWordEndobj;

	// Use this for initialization
	void Start ()
	{
		NPC_Refference = GameObject.Find("Main Camera").GetComponent<TextEng>();
		StartLingo();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void CheckButton()
	{
		if (gameDone != true)
		{
			CheckWord();

			for (int i = 0; i < 5; i++)
			{
				invulKansen[currentRow][i].GetComponent<InputField>().interactable= true;

			}
		}

	}

	void StartLingo()
	{
		invulKansen.Add(invulVakkenKans1);
		invulKansen.Add(invulVakkenKans2);
		invulKansen.Add(invulVakkenKans3);
		invulKansen.Add(invulVakkenKans4);
		invulKansen.Add(invulVakkenKans5);
		Debug.Log(invulKansen.Count);
		theWord = words[Random.Range(0, words.Length)];
		
		showWordEnd.GetComponentInChildren<Text>().text += theWord;
		showWordEndobj.SetActive(false);

		for (var i = 0; i < theWord.Length; i++) wordLetters.Add(theWord[i]);

		invulKansen[currentRow][0].GetComponent<InputField>().text = theWord[0].ToString();

	}

	 void CheckWord()
	{
		if (currentRow == 4)
		{
			GameOverWrong();
		}


		if (gameDone != true)
		{
			var textVak = invulKansen[currentRow];
			amountCorrect = 0;		
			for (int i = 0; i < 5; i++)
			{
				var letter = textVak[i].transform.GetChild(1).GetComponent<Text>();

				if (letter.text == theWord[i].ToString())
				{
					letter.color = Color.green;
					amountCorrect = amountCorrect + 1;
					correctLetters.Add(letter.text);
				}
				else
				{
					for (int j = 0; j < 5; j++)
					{
						if (letter.text == theWord[j].ToString())
						{
							letter.color = Color.yellow;
						}
					}
				}
				textVak[i].GetComponent<InputField>().interactable = false;


			}

			if (amountCorrect ==5)
			{
				GameOverRight();
			}


			
			
			currentRow = currentRow + 1;

			

			for (int i = 0; i < correctLetters.Count; i++)
			{
				for (int j = 0; j < theWord.Length; j++)
				{
					if (correctLetters[i] == theWord[j].ToString())
					{
						invulKansen[currentRow][j].GetComponent<InputField>().text = correctLetters[i];
					}
				}
			}	
		}

		
		
	}
	void GameOverWrong()
	{
		gameDone = true;
		for (int i = 0; i < NPC_Refference.NPC_Begin.Length; i++)
		{
			NPC_Refference.NPC_Begin[i].SetActive(true);

		}
		NPC_Refference.gameStart.SetActive(false);
		NPC_Refference.string0 = "Jesus, never help people again. You suck. You lost a house. Bye, Felicia!";
		NPC_Refference.RestartText();
		Debug.Log("Game Done Wrong");
		showWordEndobj.SetActive(true);
	
	}

	void GameOverRight()
	{
		gameDone = true;
		for (int i = 0; i < NPC_Refference.NPC_Begin.Length; i++)
		{
			NPC_Refference.NPC_Begin[i].SetActive(true);

		}
		NPC_Refference.gameStart.SetActive(false);
		NPC_Refference.string0 = "Yes, the government will give me my 5 wives back! Thanks, bro! I’ll give you my house!";
		NPC_Refference.RestartText();
		Debug.Log("Game Done Right");
		showWordEndobj.SetActive(true);

	
	}
}
