using Assets.Code.Interfaces;
using UnityEngine;

public class GamePlaySM : MonoBehaviour {

    private AudioManager _audioManager;
    private StateMachine _stateMachine;
    private CanvasManager _canvasManager;

    private IStateBase activeState;

	// Use this for initialization
	void Start () {

        activeState = new PlayingState(this);
        _stateMachine = GetComponent<StateMachine>();
        _audioManager = GetComponent<AudioManager>();
        _canvasManager = GetComponent<CanvasManager>();

		
	}
	
	// Update is called once per frame
	void Update () {
        activeState.StateUpdate();
	}
    public void SwitchState(IStateBase newState)
    {
        activeState = newState;
    }
    public AudioManager _AudioManager { get { return _audioManager; } set { _audioManager = value; } }
    public CanvasManager _CanvasManager { get { return _canvasManager; } set { _canvasManager = value; } }
    public StateMachine _StateMachine { get { return _stateMachine; } set { _stateMachine = value; } }
}
