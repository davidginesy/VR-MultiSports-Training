using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLife : MonoBehaviour {
	public float Timer;
	public float livingTime;

	void Update(){
		Timer += Time.deltaTime;
		if (Timer >= livingTime) {
			Destroy (this.gameObject);
		}
	}
}
