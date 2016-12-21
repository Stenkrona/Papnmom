using UnityEngine;
using System.Collections;

public class locomotion : MonoBehaviour {

	Vector2 direction; //Direction player is facing
	Vector2 velocity; //Current Velocity of player

	public float speed = 10f;

	Vector2 input;
	[Range(0,1)]
	public float sensitivity = 0.2f;

	// Use this for initialization
	void Start () {

	}

	void getInput(){
		input = new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));
	}

	void setDirection(){

		//direction defaults to zero. If input is greater than  sensitivity, the direction vector will be affected.
		direction = Vector2.zero;

		if (Mathf.Abs (input.x) > sensitivity) {
			direction += (int)Mathf.Sign (input.x) * Vector2.right;
		}

		if (Mathf.Abs (input.y) > sensitivity) {
			direction += (int)Mathf.Sign (input.y) * Vector2.up;
		}

		direction = direction.normalized;


	}

	void movement(){
		velocity = Vector2.Lerp (velocity, direction, 0.3f);
		transform.position += new Vector3 (velocity.x,velocity.y,0) * speed * Time.deltaTime;
	}

	void OnFood(){
		print ("hello!");
	}

	// Update is called once per frame
	void Update () {
		getInput ();
		setDirection ();
		movement ();

	}
}
