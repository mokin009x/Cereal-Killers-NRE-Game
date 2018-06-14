using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using ProBuilder2.Common;
using UnityEngine;
using UnityEngine.UI;

public class LingoScript : MonoBehaviour
{

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


	// Use this for initialization
	void Start ()
	{
		StartLingo();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			CheckWord();
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
		for (var i = 0; i < theWord.Length; i++) wordLetters.Add(theWord[i]);

		

	}

	 void CheckWord()
	{
		var textVak = invulKansen[currentRow];
		var correct = 0;
		
		for (int i = 0; i < 5; i++)
		{
			var letter = textVak[i].transform.GetChild(2).GetComponent<Text>();

			if (letter.text == theWord[i].ToString())
			{
				letter.color = Color.green;
				correct = correct + 1;
			}
			else
			{
				for (int j = 0; j < theWord.Length; j++)
				{
					if (letter.text == theWord[j].ToString())
					{
						letter.color = Color.yellow;
					}
				}
			}
			textVak[i].GetComponent<InputField>().interactable = false;


		}

		if (correct ==5)
		{
			Debug.Log("Game done");
		}
		currentRow = currentRow + 1;
	}
}
