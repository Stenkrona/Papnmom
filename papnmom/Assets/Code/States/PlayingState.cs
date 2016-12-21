using Assets.Code.Interfaces;
using System.Collections.Generic;
using UnityEngine;

public class PlayingState : IStateBase, IModel {

    private GamePlaySM _gamePlaySM;
    private AudioManager _audioManager;
    private CanvasManager _canvasManager;

    public List<IView> listeners { get { return listeners; } set { listeners = value; } }


    public PlayingState(GamePlaySM gpsm)
    {
        _gamePlaySM = gpsm;

        Time.timeScale = 1;
       

    }

    public void Audio()
    {
           
    }

    public void ShowIt()
    {
      
    }

    public void StateUpdate()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _gamePlaySM._StateMachine._HQ.BF.Pause();
        }
    }

    public void RegisterListener(IView listener)
    {
       
    }
}
