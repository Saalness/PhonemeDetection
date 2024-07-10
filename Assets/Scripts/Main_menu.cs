using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mainmenu : MonoBehaviour
{
    [SerializeField] private Canvas main_menu; //whole menu
    [SerializeField] private Canvas reading_menu; //whole menu
    [SerializeField] private Button practice; //reading practice scene
    [SerializeField] private Button settings; //options for volume and music
    [SerializeField] private Button writing; //spelling practice
    [SerializeField] private Button back; //to go back to the menu
    
    void Start()
    {
        practice.onClick.AddListener(ReadMode);
        settings.onClick.AddListener(SettingsPage);
        writing.onClick.AddListener(WritingMode);
        back.onClick.AddListener(BacktoMenu);
        reading_menu.enabled = false;
    }
  
    public void PracticeMode()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");
        Debug.Log("The play button was clicked");
    }
    
    public void ReadMode()
    {
        reading_menu.enabled = true;
        main_menu.enabled = false;
        back.enabled = true;
    }

    public void WritingMode()
    {
        writing.enabled = true;
        main_menu.enabled = false;
        back.enabled = true;
    }

    public void BacktoMenu()
    {
        reading_menu.enabled = false;
        main_menu.enabled = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void SettingsPage()
    {
        practice.enabled = false;
        settings.enabled = true;
        writing.enabled = false;
        main_menu.enabled = false;
    }
}

