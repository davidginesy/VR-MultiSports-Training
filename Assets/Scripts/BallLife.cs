using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLife : MonoBehaviour {
	public float Timer;
	public float livingTime;
	public AudioSource audio;

	void Update(){
		Timer += Time.deltaTime;
		if (Timer >= livingTime) {
			//Destroy (this.gameObject);
		}
	}

	void OnCollisionEnter(Collision other){
		Debug.Log ("collision");
		audio.Play ();
		if (other.transform.tag.Equals("Decor")){
			
			audio.Play();
		}
	}
}
