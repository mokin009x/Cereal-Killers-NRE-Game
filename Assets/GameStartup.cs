using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartup : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        StartCoroutine(StartGame());
        
    }

    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(7f);
        SceneManager.LoadScene("LevelSelect");
    }
}
