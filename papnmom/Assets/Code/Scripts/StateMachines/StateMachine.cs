using Assets.Code.Interfaces;
using Assets.Code.States;
using UnityEngine;


public class StateMachine : MonoBehaviour {

    private IStateBase activeState;
    private HQ _hq;
    private GamePlaySM _gamePlaySM;
    public AudioManager _audioManager;
    public CanvasManager _canvasManager;



    void Start()
    {
        _hq = GetComponentInParent<HQ>();
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
    public void CreateSubStateMachine()
    {
       _gamePlaySM = gameObject.AddComponent<GamePlaySM>();
    }

    public AudioManager _AudioManager { get { return _audioManager; } set { _audioManager = value; } }
    public CanvasManager _CanvasManager { get { return _canvasManager; } set { _canvasManager = value; } }
    public IStateBase ActiveState { get { return activeState; } set { activeState = value; } }
    public HQ _HQ { get { return _hq; } set { _hq = value; } }
    public GamePlaySM _GamePlaySM {get{return _gamePlaySM;} set{_gamePlaySM = value;}}
   
}
