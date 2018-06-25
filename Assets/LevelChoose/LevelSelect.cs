using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour {

    public Material[] islandTextures = new Material[1];
    public GameObject[] houses = new GameObject[8];

    public GameObject island;

    public GameObject leftButton;
    public GameObject midButton;
    public GameObject rightButton;

    public GameObject backButton;

    public GameObject glow;

    public Animator anim;

    void Start ()
    {
        glow.SetActive(false);
        backButton.SetActive(false);
        anim = GetComponent<Animator>();
        anim.SetInteger("State", 0);
    }
	
	void Update ()
    {
        Debug.Log(Singleton.Score);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Singleton.Score = Singleton.Score + 10;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Singleton.Score = Singleton.Score - 10;
        }
        if (Singleton.Score < 30)
        {
            island.GetComponent<MeshRenderer>().material = islandTextures[0];
        }
        if (Singleton.Score > 29 && Singleton.Score < 60)
        {
            island.GetComponent<MeshRenderer>().material = islandTextures[1];
        }
        if (Singleton.Score > 59 && Singleton.Score < 88)
        {
            island.GetComponent<MeshRenderer>().material = islandTextures[2];
        }
        if (Singleton.Score > 89)
        {
            island.GetComponent<MeshRenderer>().material = islandTextures[3];
        }

        if (Singleton.Score > 9)
        {
            houses[0].SetActive(true);
            if (Singleton.Score > 19)
            {
                houses[1].SetActive(true);
                if (Singleton.Score > 29)
                {
                    houses[2].SetActive(true);
                    if (Singleton.Score > 39)
                    {
                        houses[3].SetActive(true);
                        if (Singleton.Score > 49)
                        {
                            houses[4].SetActive(true);
                            if (Singleton.Score > 59)
                            {
                                houses[5].SetActive(true);
                                if (Singleton.Score > 69)
                                {
                                    houses[6].SetActive(true);
                                    if (Singleton.Score > 79)
                                    {
                                        houses[7].SetActive(true);
                                        if (Singleton.Score > 89)
                                        {
                                            houses[8].SetActive(true);
                                        }
                                        else
                                        {
                                            houses[8].SetActive(false);
                                        }
                                    }
                                    else
                                    {
                                        houses[7].SetActive(false);
                                    }
                                }
                                else
                                {
                                    houses[6].SetActive(false);
                                }
                            }
                            else
                            {
                                houses[5].SetActive(false);
                            }
                        }
                        else
                        {
                            houses[4].SetActive(false);
                        }
                    }
                    else
                    {
                        houses[3].SetActive(false);
                    }
                }
                else
                {
                    houses[2].SetActive(false);
                }
            }
            else
            {
                houses[1].SetActive(false);
            }
        }
        else
        {
            houses[0].SetActive(false);
        }
    }

    public void Back()
    {
        anim.SetInteger("State", 0);
        glow.SetActive(false);
        backButton.SetActive(false);
        leftButton.SetActive(true);
        midButton.SetActive(true);
        rightButton.SetActive(true);
    }

    public void Left()
    {
        anim.SetInteger("State", 1);
        glow.SetActive(true);
        ButtonDisable();
    }

    public void Middle()
    {
        anim.SetInteger("State", 2);
        glow.SetActive(true);
        ButtonDisable();
    }

    public void Right()
    {
        anim.SetInteger("State", 3);
        glow.SetActive(true);
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