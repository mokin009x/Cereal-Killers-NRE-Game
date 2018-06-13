using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour {

    public GameObject leftButton;
    public GameObject midButton;
    public GameObject rightButton;

    public GameObject backButton;

    public Animator anim;

    void Start ()
    {
        backButton.SetActive(false);
        anim = GetComponent<Animator>();
        anim.SetInteger("State", 0);
    }
	
	void Update ()
    {
		
	}

    public void Back()
    {
        anim.SetInteger("State", 0);
        backButton.SetActive(false);
        leftButton.SetActive(true);
        midButton.SetActive(true);
        rightButton.SetActive(true);
    }

    public void Left()
    {
        anim.SetInteger("State", 1);
        ButtonDisable();
    }

    public void Middle()
    {
        anim.SetInteger("State", 2);
        ButtonDisable();
    }

    public void Right()
    {
        anim.SetInteger("State", 3);
        ButtonDisable();
    }

    void ButtonDisable()
    {
        backButton.SetActive(true);
        leftButton.SetActive(false);
        midButton.SetActive(false);
        rightButton.SetActive(false);
    }

}