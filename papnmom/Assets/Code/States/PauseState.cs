using Assets.Code.Interfaces;
using System.Collections.Generic;
using UnityEngine;

public class PauseState : IStateBase, IModel {

    private GamePlaySM _gamePlaySM;
    private AudioManager _audioManager;
    private CanvasManager _canvasManager;

   

   public PauseState(GamePlaySM gpsm)
    {
        _gamePlaySM = gpsm;
        Time.timeScale = 0;
    }   
    
    public void Audio()
    {

    }

    public void ShowIt()
    {

    }

    public void StateUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
            {
            _gamePlaySM._StateMachine._HQ.BF.Resume();
            }
    }

    public void RegisterListener(IView listener)
    {
       
    }
    public List<IView> listeners { get { return listeners; } set { listeners = value; } }
}
