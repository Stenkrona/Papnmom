using UnityEngine;


public class Txt_Blink : MonoBehaviour {

    public float duration;
        
	void Start () {

        Switch();
	}
	
	private void Switch()
    {
        if(gameObject.active)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }

        Invoke("Switch", duration);
    }
}
