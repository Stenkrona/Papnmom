using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbit : MonoBehaviour {

	public Transform target;

	public float speed = 10;

	float input;

	float offset;

	// Use this for initialization
	void Start () {
		
	}

	void getInput(){
		input = Input.GetAxisRaw ("orbit");
	}

	void setPosition(){
		if (Mathf.Abs (input) > 0.19f) {
			offset += input * Time.deltaTime * speed;
		}

		transform.position = target.position + new Vector3 (Mathf.Cos (offset), Mathf.Sin (offset), 0);
	}
	
	// Update is called once per frame
	void Update () {

		getInput ();
		setPosition ();
		
	}
}
