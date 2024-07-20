using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Mainmenu : MonoBehaviour
{
    [SerializeField] private Canvas main_menu; //whole menu
    [SerializeField] private Canvas reading_menu; //reading menu
    [SerializeField] private Canvas games_menu; //writing menu
    [SerializeField] private Canvas open_settings; //settings pages
    [SerializeField] private Button practice; //reading practice scene
    [SerializeField] private Button settings; //options for volume and music
    [SerializeField] private Button play; //pronunciation practice
    [SerializeField] private Button back; //to go back to the menu
    public AudioMixer audioMixer;
    
    void Start()
    {
        practice.onClick.AddListener(ReadMode);
        settings.onClick.AddListener(SettingsPage);
        play.onClick.AddListener(PlayMode);
        back.onClick.AddListener(BacktoMenu);
        reading_menu.enabled = false;
        games_menu.enabled = false;
        open_settings.enabled = false;
    }
  
    public void PracticeMode()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");
        Debug.Log("The play button was clicked");
    }
    public void SoundBoard()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SoundsScene");
        Debug.Log("The sounds button was clicked");
    }
        public void MatchingGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MatchingGame");
        Debug.Log("The matching game button was clicked");
    }

        public void ConnectGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("ConnectGame");
        Debug.Log("The connect game button was clicked");
    }
    
    public void ReadMode()
    {
        reading_menu.enabled = true;
        main_menu.enabled = false;
        back.enabled = true;
    }

    public void PlayMode()
    {
        games_menu.enabled = true;
        main_menu.enabled = false;
        back.enabled = true;
    }

    public void BacktoMenu()
    {
        reading_menu.enabled = false;
        games_menu.enabled = false;
        open_settings.enabled = false;
        main_menu.enabled = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void SettingsPage()
    {
        reading_menu.enabled = false;
        open_settings.enabled = true;
        games_menu.enabled = false;
        main_menu.enabled = false;
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
        //Debug.Log(volume);
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}

