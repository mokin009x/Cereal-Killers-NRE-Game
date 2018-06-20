using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheels : MonoBehaviour {

    public float speed;
    
	void Start ()
    {
		
	}
	
	void Update ()
    {
        if (RunPlayer.gameStart)
        {
            transform.Rotate(0, 0, speed);
        }
	}
}
