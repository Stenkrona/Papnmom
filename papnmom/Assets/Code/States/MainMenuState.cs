using Assets.Code.Interfaces;
using UnityEngine;

namespace Assets.Code.States
{
    public class MainMenuState : IStateBase
	{
		private StateMachine _stateManager;
        private AudioManager _audioManager;
        private CanvasManager _canvasManager;
        private bool anykeypressed;

		public MainMenuState (StateMachine managerRef)
		{
            _stateManager = managerRef;
            _audioManager = _stateManager._AudioManager;
            _canvasManager = _stateManager._CanvasManager;

            _canvasManager.SetActivePanel("splashscreen");
			
			Debug.Log("MainMenuState Constructed");
		}
		public void StateUpdate()
		{
			if(Input.anyKeyDown && !anykeypressed)
                {
                _canvasManager.SetActivePanel("mainmenu");
                _canvasManager.SetActiveMainMenuLayer("stepone");
                anykeypressed = true;
                }
			

		}
		public void ShowIt()
		{
			
		}
        public void Audio()
        {

        }
	}
}

