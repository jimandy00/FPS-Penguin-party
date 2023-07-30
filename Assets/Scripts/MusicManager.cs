using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{

    GameObject backgroundMusic;
    public AudioSource audio;
    public AudioSource penguinAudio;

    public static MusicManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        backgroundMusic = GameObject.Find("Background");
        audio = backgroundMusic.GetComponent<AudioSource>();

        backgroundMusic = GameObject.Find("Player");
        penguinAudio = backgroundMusic.GetComponent<AudioSource>();

        if (audio.isPlaying) return;
        else
        {
            audio.Play();
            DontDestroyOnLoad(backgroundMusic);
        }
    }

    public void PlayMusic()
    {
        audio.Play();
    }

    public void StopMusic()
    {
        audio.Pause();
    }

    public void DiePenguin()
    {
        penguinAudio.volume = 1.0f;
        penguinAudio.Play();
    }
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Instance.gState == GameState.Pause)
        {

        }
        else
        {

        }
    }
}
