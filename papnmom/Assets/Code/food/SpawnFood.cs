using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour {


	public int amount;
	public int maxAmount;

	public GameObject food;
	public Sprite[] sprites;
	Vector2 screenSize;

	Transform[] foodTransforms;
	Vector2[] spawnPos;
	Vector3[] velocity;


	void initializeFood() {
		foodTransforms = new Transform[maxAmount];
		spawnPos = new Vector2[maxAmount];
		velocity = new Vector3[maxAmount];


		for (int i = 0; i < maxAmount; i++) {
			foodTransforms [i] = (Instantiate (food, new Vector3(100,100,0),Quaternion.identity) as GameObject).transform;
		}

		for (int i = 0; i < amount; i++) {
			spawnFood (i);
		}
	}

	void spawnFood(int index){
		float temp = Random.value;
		if (temp < 0.25f) {
			spawnPos [index] = new Vector2 ((screenSize.x + 1f) / 2, Random.Range (-(screenSize.y) / 2, screenSize.y / 2));
			velocity [index] = -(Vector3.right) * Random.Range (0.9f, 1.1f);
		} else if (temp < 0.5f) {
			spawnPos [index] = new Vector2 (-(screenSize.x + 1f) / 2, Random.Range (-(screenSize.y) / 2, screenSize.y / 2));
			velocity [index] = (Vector3.right) * Random.Range (0.9f, 1.1f);
		} else if (temp < 0.75f) {
			spawnPos [index] = new Vector2 (Random.Range (-(screenSize.x), screenSize.x),(screenSize.y + 1f) / 2);
			velocity [index] = -(Vector3.up) * Random.Range (0.9f, 1.1f);
		} else {
			spawnPos [index] = new Vector2 (Random.Range (-(screenSize.x), screenSize.x),-(screenSize.y + 1f) / 2);
			velocity [index] = (Vector3.up) * Random.Range (0.9f, 1.1f);

		}


		foodTransforms[index].position = spawnPos[index];

		foodTransforms[index].GetComponent<SpriteRenderer>().sprite = sprites[(int)(Random.value * sprites.Length)];

	}

	void moveFood (int index) {
		foodTransforms[index].position += velocity[index] * Time.deltaTime;
	}

	void getScreenSize(){
		Vector3 temp = Camera.main.ViewportToWorldPoint (new Vector3(1.2f,1.2f,0));
		screenSize = new Vector2 (temp.x,temp.y);
	}

	// Use this for initialization
	void Start () {
		getScreenSize ();
		initializeFood ();
			
	}
	
	// Update is called once per frame
	void Update () {

		for (int i = 0; i < amount; i++) {
			moveFood (i);
			if (Mathf.Abs(velocity[i].x) > Mathf.Abs(velocity[i].y)) {

				if (Mathf.Abs (foodTransforms [i].position.x - spawnPos [i].x) > screenSize.x * 2f) {

					spawnFood (i);
				}

			} else {
				if (Mathf.Abs (foodTransforms [i].position.y - spawnPos [i].y) > screenSize.y * 2f) {

					spawnFood (i);
				}
			}
		}
		
	}
}
