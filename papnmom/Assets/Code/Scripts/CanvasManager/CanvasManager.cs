using UnityEngine;

public class CanvasManager : MonoBehaviour {

    private GameObject splashScreen;
    private GameObject mainMenu;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    public GameObject SplashScreen { get { return splashScreen; } set { splashScreen = value; } }
    public GameObject MainMenu {get{return mainMenu;} set{mainMenu = value;}}
}
