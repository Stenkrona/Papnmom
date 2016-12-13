using Assets.Code.Interfaces;
using UnityEngine;

namespace Assets.Code.States
{
    public class MainMenuState : IStateBase
	{
		private StateMachine _stateManager;
        private AudioManager _audioManager;
        private CanvasManager _canvasManager;
        private bool splashScreen;

		

		public MainMenuState (StateMachine managerRef)
		{
            _stateManager = managerRef;
            _audioManager = _stateManager._AudioManager;
            _canvasManager = _stateManager._CanvasManager;

			
			Debug.Log("MainMenuState Constructed");
		}
		public void StateUpdate()
		{
			if(Input.anyKeyDown)
                {
                 _canvasManager.SplashScreen.SetActive(false);
                 _canvasManager.MainMenu.SetActive(true);
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

