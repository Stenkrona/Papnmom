using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    private AudioSource musicSpeaker;

    private Dictionary<string, AudioClip> music;

	// Use this for initialization
	void Start () {
        musicSpeaker = transform.GetChild(0).GetComponent<AudioSource>();

        music = new Dictionary<string, AudioClip>();
        music.Add("supermarket", Resources.Load<AudioClip>("Music/Supermarket"));
	}

    public void PlaySong(string s)
    {
        musicSpeaker.clip = music[s];
        musicSpeaker.Play();
    }
	
}
