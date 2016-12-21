using UnityEngine;

public class FruitRain : MonoBehaviour {

    public GameObject[] spawnPoints;
    private GameObject[] food;
   


	// Use this for initialization
	void Start () {
        food = Resources.LoadAll<GameObject>("Prefabs/FruitMenuState");
      

        Rain();

        InvokeRepeating("Rain", 1f, 0.3f);
    }
	
	private void Rain()
    {
        Transform transform = spawnPoints[Random.Range(0, 3)].transform;
        GameObject thefood = food[Random.Range(0, 8)];

        Instantiate(thefood, transform);
    }
}
