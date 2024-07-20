using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Back_btn : MonoBehaviour
{
    [SerializeField] private Button back; //to go back to the menu scene
    // Start is called before the first frame update
    void Start()
    {
        back.onClick.AddListener(BacktoMenuScene);
    }

      public void BacktoMenuScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
        Debug.Log("The back button was clicked");
    }
}
