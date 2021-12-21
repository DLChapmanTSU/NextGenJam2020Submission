using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenuScript : MonoBehaviour
{

    public AudioMixer mixer;
    public AudioSource buttonSound;

    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        mixer.SetFloat("sfxvolume", PlayerPrefs.GetFloat("SFXVolume", 0.0f));
        mixer.SetFloat("musicvolume", PlayerPrefs.GetFloat("MusicVolume", 0.0f));
    }

    public void OnQuitButton()
    {
        print("quit");
        Application.Quit();
    }

    public void ButtonSound()
    {
        buttonSound.Play();
    }
}
