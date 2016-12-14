using Assets.Code.Interfaces;
using UnityEngine;

namespace Assets.Code.States
{
    public class Mission_Pap_State : IStateBase 
	{
		private StateMachine _stateManager;
        private AudioManager _audioManager;
        private CanvasManager _canvasManager;
		
		public Mission_Pap_State (StateMachine managerRef)
		{
			_stateManager = managerRef;
            _audioManager = _stateManager._AudioManager;
            _canvasManager = _stateManager._CanvasManager;
            _audioManager.PlaySong("supermarket");
			
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

