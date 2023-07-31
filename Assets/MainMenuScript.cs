using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    public AudioSource playAgainAudio;
    public AudioSource exitAudio;
    public AudioClip audioClip;

    public void playAudio()
    {

        playAgainAudio.clip = audioClip;
        exitAudio.clip = audioClip;

        playAgainAudio.Play();
        exitAudio.Play();
    }

    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitApp()
    {
        Application.Quit();
        Debug.Log("Application has been quit.");
    }
}
