using UnityEngine;
using Assets.Code.Interfaces;
using UnityEngine.UI;
using System.Collections;

namespace Assets.Code.States
{
	public class PlayState : IStateBase 
	{
		private StateMachine _stateManager;
        private AudioManager _audioManager;
        private CanvasManager _canvasManager;
		
		public PlayState (StateMachine managerRef)
		{
			_stateManager = managerRef;
            _audioManager = _stateManager._AudioManager;
            _canvasManager = _stateManager._CanvasManager;
			
			Debug.Log("PlayState Constructed");
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
}

