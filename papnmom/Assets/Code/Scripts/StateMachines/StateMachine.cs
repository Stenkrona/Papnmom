using Assets.Code.Interfaces;
using Assets.Code.States;
using UnityEngine;


public class StateMachine : MonoBehaviour {

    private IStateBase activeState;
    public AudioManager _audioManager;
    public CanvasManager _canvasManager;



    void Start()
    {
        activeState = new MainMenuState(this);
    }
    void Update()
    {
        if (activeState != null)
            activeState.StateUpdate();

    }
    public void SwitchState(IStateBase newState)
    {
        activeState = newState;
    }
    public AudioManager _AudioManager {get{return _audioManager;} set{_audioManager = value;}}
    public CanvasManager _CanvasManager {get { return _canvasManager; } set { _canvasManager = value; } }
}
