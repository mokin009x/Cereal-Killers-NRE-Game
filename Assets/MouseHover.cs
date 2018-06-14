using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHover : MonoBehaviour
{

    public GameObject glow;

    private void Start()
    {
        glow.SetActive(false);
    }

    void OnMouseOver()
    {
        Debug.Log("Mouse is over GameObject.");
        glow.SetActive(true);
    }

    void OnMouseExit()
    {
        Debug.Log("Mouse is no longer on GameObject.");
        glow.SetActive(false);
    }
}
