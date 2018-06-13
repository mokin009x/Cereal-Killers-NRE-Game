using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
	public GameObject BuildingNL;
	public GameObject[] tier1NL;

	// Use this for initialization
	void Start () {
		tier1NL = GameObject.FindGameObjectsWithTag("Tier1NL");

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			for (int i = 0; i < tier1NL.Length; i++)
			{
				Instantiate(BuildingNL, tier1NL[i].transform.position, Quaternion.identity);

			}
		}
	}
}
