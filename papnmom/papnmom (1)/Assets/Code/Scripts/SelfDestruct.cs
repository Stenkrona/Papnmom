using UnityEngine;

public class SelfDestruct : MonoBehaviour {


	// Use this for initialization
	void Start () {

        Invoke("DestroySelf", 3f);
		
	}
	
	

    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}

