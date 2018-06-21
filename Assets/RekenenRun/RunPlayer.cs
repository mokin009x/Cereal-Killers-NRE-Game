using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RunPlayer : MonoBehaviour {

    public static bool gameStart = false;

    public float speed;
    public Text timer;
    int countdown = 10;

    public Text question;
    bool nextQuestion = false;
    public InputField inputAnswer;

    [Header("Endings")]
    public GameObject win;
    public GameObject lose;
    public static bool lost = false;

    [Header("Answer")]
    public int answer;
    private string answerString;
    
	void Start ()
    {
        lost = false;
        gameStart = false;
        timer.text = countdown.ToString();
        StartCoroutine(StartGame());
	}
	
	void Update ()
    {
        if (gameStart)
        {

            transform.Translate(Vector3.right * speed * Time.deltaTime);
            answerString = answer.ToString();

            if (nextQuestion)
            {
                nextQuestion = false;
                GenerateQuestion();
            }

            if (inputAnswer.text == answerString )
            {
                StartCoroutine(SpeedGain());
                inputAnswer.text = null;
                GenerateQuestion();
            }
        }

        if (lost == true)
        {
            lose.SetActive(true);
            gameStart = false;
            Singleton.Score = Singleton.Score - 10;
            lost = false;
            StartCoroutine(BackToMenu());
        }
	}

    void GenerateQuestion()
    {
        int firstNumber;
        int secondNumber;
        int whatQuestion;
        
        whatQuestion = Random.Range(1, 4);

        if (whatQuestion == 1)
        {
            firstNumber = Random.Range(1, 100);
            secondNumber = Random.Range(1, 100);
            question.text = firstNumber + " + " + secondNumber;
            answer = firstNumber + secondNumber;
        }

        if (whatQuestion == 2)
        {
            firstNumber = Random.Range(1, 100);
            secondNumber = Random.Range(1, 100);
            question.text = firstNumber + " - " + secondNumber;
            answer = firstNumber - secondNumber;
        }

        if (whatQuestion == 3)
        {
            firstNumber = Random.Range(1, 11);
            secondNumber = Random.Range(1, 11);
            question.text = firstNumber + " X " + secondNumber;
            answer = firstNumber * secondNumber;
        }

    }

    IEnumerator SpeedGain()
    {
        speed = speed * 3.5f;
        yield return new WaitForSeconds(1f);
        speed = 1;
    }

    IEnumerator StartGame()
    {
        for (int i = 1; i < 12; i++)
        {
            yield return new WaitForSeconds(1);
            if (i < 10)
            {
                countdown = countdown - 1;
                timer.text = countdown.ToString();
            }
            if (i == 10)
            {
                timer.text = "Go!";
            }
            if (i == 11)
            {
                Destroy(timer);
                nextQuestion = true;
                gameStart = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "finish")
        {
            win.SetActive(true);
            gameStart = false;
            Singleton.Score = Singleton.Score + 10;
            StartCoroutine(BackToMenu());
        }

    }

    IEnumerator BackToMenu()
    {
        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene("LevelSelect");
    }

}
