using UnityEngine;

public class Mission_Mom_State : MonoBehaviour {

    private StateMachine _stateManager;
    private AudioManager _audioManager;
    private CanvasManager _canvasManager;

    public Mission_Mom_State(StateMachine managerRef)
    {
        _stateManager = managerRef;
        _audioManager = _stateManager._AudioManager;
        _canvasManager = _stateManager._CanvasManager;

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

