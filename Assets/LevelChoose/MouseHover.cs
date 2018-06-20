using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseHover : MonoBehaviour
{

    public GameObject glow;
    public string nextSceneName;

    private void Start()
    {
        glow.SetActive(false);
    }

    void OnMouseOver()
    {
        glow.SetActive(true);
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("LoadMap");
            SceneManager.LoadScene(nextSceneName);
        }
    }

    void OnMouseExit()
    {
        glow.SetActive(false);
    }
}
