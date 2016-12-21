using UnityEngine; //Author: Axel S. Stenkrona
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour {

    private CanvasManager _canvasManager;
    private bool questioningPlayer;
    private bool playerAwnser;
    private bool playerHasAwnserd;

    private int mission;

    public bool debugLog;

    private void Awake()
    {
        _canvasManager = GetComponentInChildren<CanvasManager>();
    }

    public void NewGame()
    {
        _canvasManager.SetActiveMainMenuLayer("steptwo");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void AccessCredits()
    {

    }
    public void Yes()
    {
        SceneManager.LoadScene(mission);
    }
    public void No()
    {
        questioningPlayer = false;
        _canvasManager.SetActiveMainMenuLayer("steptwo");
    }
    public void MissionOnePicked()
    {
        mission = 1;
        questioningPlayer = true;
        _canvasManager.SetActiveMainMenuLayer("areyousure");
    }
    public void MissionTwoPicked()
    {
        mission = 2;
        _canvasManager.SetActiveMainMenuLayer("areyousure");
    }
    
    private void Update()
    {
       
    }
}
