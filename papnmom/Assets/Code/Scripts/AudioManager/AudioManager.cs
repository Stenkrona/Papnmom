using Assets.Code.Interfaces;
using System.Collections.Generic;
using UnityEngine;

enum MusicTracks { MainMenu = 1, Mission_One = 2, Mission_2 = 3}

public class AudioManager : MonoBehaviour, IView {

    private AudioSource musicSpeaker;
    private StateMachine _stateMachine;

    private Dictionary<string, AudioClip> music;
    private IStateBase activeState;

    public bool debugLog;

    void Start() {
        if (debugLog) Debug.Log("Constructing AudioManager...");
        musicSpeaker = transform.GetChild(0).GetComponent<AudioSource>();

        music = new Dictionary<string, AudioClip>();
        music.Add("Mission_One", Resources.Load<AudioClip>("Music/Supermarket"));
        if (debugLog) Debug.Log("AudioManager Constructed!");
    }

    public void PlaySong()
    {
        if (debugLog) Debug.Log("Exicuting PlaySong...");
        musicSpeaker.clip = music[MusicTracks.Mission_One.ToString()];
        musicSpeaker.Play();
        if (debugLog) Debug.Log("PlaySong Done!");
    }
    public void PauseSong()
    {
        musicSpeaker.Pause();
    }
    public void ResumeSong()
    {
        musicSpeaker.UnPause();
    }
    public void ReceiveUpdate()
    {
        if (debugLog) Debug.Log("AudioManager Recieving Update...");

        activeState = _stateMachine.ActiveState;
        PlaySong();

        if (debugLog) Debug.Log("AudioManager Updated!");
    }
    public IModel model { get { return model; } set { model = value; } }
    public IController controller { get { return controller; } set { controller = value; } }
}
