using UnityEngine; //Author: Axel S. Stenkrona


public class ButtonFunctions : MonoBehaviour {

    private CanvasManager _canvasManager;
    private StateMachine _stateManager;
    private AudioManager _audioManager;

    private bool questioningPlayer;
    private bool playerAwnser;
    private bool playerHasAwnserd;

    private int nextState;

    public bool debugLog;

    private void Awake()
    {
        _canvasManager = GetComponentInChildren<CanvasManager>();
        _stateManager = GetComponentInChildren<StateMachine>();
        _audioManager = GetComponentInChildren<AudioManager>();
    }

    //Functions
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
    public void Resume()
    {
        _stateManager._GamePlaySM.SwitchState(new PlayingState(_stateManager._GamePlaySM));
        _audioManager.ResumeSong();
        _canvasManager.SetActivePanel("pause");
    }
    public void Pause()
    {
        _stateManager._GamePlaySM.SwitchState(new PauseState(_stateManager._GamePlaySM));
        _audioManager.PauseSong();
        _canvasManager.SetActivePanel("hud");
        

    }
    public void Yes()
    {
        if (nextState == 1)
            _stateManager.SwitchState(new Mission_One(_stateManager));
    }
    public void No()
    {
        questioningPlayer = false;
        _canvasManager.SetActiveMainMenuLayer("steptwo");
    }
    public void MissionOnePicked()
    {
        nextState = 1;
        questioningPlayer = true;
        _canvasManager.SetActiveMainMenuLayer("areyousure");
    }
    public void MissionTwoPicked()
    {
        nextState = 2;
        questioningPlayer = true;
        _canvasManager.SetActiveMainMenuLayer("areyousure");
    }

    private void Update()
    {

    }
   
}
