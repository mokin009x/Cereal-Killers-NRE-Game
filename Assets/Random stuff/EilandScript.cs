using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EilandScript : MonoBehaviour
{
	
	public GameObject[] tier1NL;
	// Use this for initialization
	void Start ()
	{
		tier1NL = GameObject.FindGameObjectsWithTag("Tier1NL");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
