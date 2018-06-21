using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextEng : MonoBehaviour
{

    public Text dialogueText;
    public float delay;
    private string fullText;

    public string string0;
    public string string1;
    public string string2;
    public string string3;

    public int waitSentence1;
    public int waitSentence2;
    public int waitSentence3;

    public int waitToDestroy;

    public GameObject Canvas;
    public GameObject[] NPC_Begin;
    public GameObject gameStart;
    public GameObject deactivateButton;
    private string currentText = "";
    // Use this for initialization
    void Start()
    {
        fullText = string0;
        StartCoroutine(ShowText());
        StartCoroutine(Text());
        StartCoroutine(Destroy());
    }

    // Update is called once per frame
    void Update()
    {
    }


    IEnumerator ShowText()
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i + 1);
            dialogueText.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);
        }
    }

    IEnumerator Text()
    {
        yield return new WaitForSeconds(waitSentence1);
        fullText = string1;
        StartCoroutine(ShowText());
        yield return new WaitForSeconds(waitSentence2);
        fullText = string2;
        StartCoroutine(ShowText());
        yield return new WaitForSeconds(waitSentence3);
        fullText = string3;
        StartCoroutine(ShowText());
        yield return new WaitForSeconds(waitToDestroy);
        StartCoroutine(ShowText());
        yield return new WaitForSeconds(3);
    }

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(waitSentence3 + waitSentence2 + waitSentence1 + waitToDestroy);
    }

    // Button
    public void BeginGame()
    {
        deactivateButton.SetActive(false);
        for (int i = 0; i < NPC_Begin.Length; i++)
        {
            NPC_Begin[i].SetActive(false);

        }
        gameStart.SetActive(true);
    }

    public void RestartText()
    {
        Start();
    }

    public void SceneSwitch()
    {
        SceneManager.LoadScene("LevelSelect");
    }
}
