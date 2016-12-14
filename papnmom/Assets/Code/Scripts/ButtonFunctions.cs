using UnityEngine; //Author: Axel S. Stenkrona
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour {

    private CanvasManager _canvasManager;
    private bool questioningPlayer;
    private bool playerAwnser;
    private bool missionPaps;
    private bool playerHasAwnserd;

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
        playerHasAwnserd = true;
    }
    public void No()
    {
        playerAwnser = false;
    }
    public void MissionPapsPicked()
    {
        missionPaps = true;
        questioningPlayer = true;
        _canvasManager.SetActiveMainMenuLayer("areyousure");
    }
    public void MissionMomsPicked()
    {
        missionPaps = false;
        _canvasManager.SetActiveMainMenuLayer("areyousure");
    }
    
    private void Update()
    {
        if(questioningPlayer)
        {
            if (debugLog) Debug.Log("Questioning Player");
            if(playerAwnser && playerHasAwnserd)
            {
                if (missionPaps)
                    SceneManager.LoadScene(1);
                else
                    SceneManager.LoadScene(2);
            }
            else if(!playerAwnser && playerHasAwnserd)
            {
                questioningPlayer = false;
                _canvasManager.SetActiveMainMenuLayer("steptwo");
            }        

        }
    }
}
