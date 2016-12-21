using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBehaviour : MonoBehaviour {

	public int price = 40;

	// Use this for initialization
	void Start () {
		
	}


	void OnTriggerEnter2D(Collider2D other){
		other.SendMessage ("OnFood",price,SendMessageOptions.DontRequireReceiver);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
