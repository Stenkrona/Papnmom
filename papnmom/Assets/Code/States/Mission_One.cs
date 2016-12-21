using Assets.Code.Interfaces;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mission_One : IStateBase {

    private StateMachine _stateManager;
    private AudioManager _audioManager;
    private CanvasManager _canvasManager;

    public Mission_One(StateMachine managerRef)
    {
        SceneManager.LoadScene(1);
        _stateManager = managerRef;
        _audioManager = _stateManager._AudioManager;
        _canvasManager = _stateManager._CanvasManager;

        _stateManager.CreateSubStateMachine();

        _audioManager.PlaySong();

        Debug.Log("Mission_Mom_State Constructed");
    }
    public void StateUpdate()
    {

    }
    public void ShowIt()
    {

    }
    public void Audio()
    {

    }




}

