using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
	public static int scoreTotal = 0;

	void Awake ()
	{
		scoreTotal = 0;
	}

	// Update is called once per frame
	void Update () {
		Debug.Log ("s = " + scoreTotal);
	}

}
