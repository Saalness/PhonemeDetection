using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SayWords : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text; // User input field
    [SerializeField] private TextMeshProUGUI prompt; // Display current word
    [SerializeField] public Image result; // Success image
    [SerializeField] public Image attempt; // Fail image
    [SerializeField] private Button checkButton; // Check input button (I suggest that you rename it for clarity)
    [SerializeField] private Button promptButton; // Next word button
    [SerializeField] private Button stopButton; // Button to stop the exercise

    static string[] words = { "at", "mad", "sad", "dad", "sat", "mat" };
    private List<string> wordlist = new List<string>(words);
    private int currentIndex = 0; // You need this to keep track of the current word index

    void Start()
    {
        result.enabled = false;
        attempt.enabled = false;
        prompt.text = words[0]; // Start with the first word
        promptButton.onClick.AddListener(NextPrompt);
        checkButton.onClick.AddListener(CheckWord);
        stopButton.onClick.AddListener(StopExercise);
    }

    void NextPrompt()
    {
        if(currentIndex < wordlist.Count - 1)
        {
            currentIndex++;
            prompt.text = words[currentIndex];
            result.enabled = false;
            attempt.enabled = false;
        }
        else
        {
            prompt.text = "well done";
        }
    }

    void CheckWord()
    {
        if(text.text.ToLower() == wordlist[currentIndex].ToLower())
        {
            result.enabled = true;
            attempt.enabled = false;
        }
        else
        {
            result.enabled = false;
            attempt.enabled = true;
        }
    }

    void StopExercise()
    {
        // Here you can see the logic to execute when the stop button is pressed
        prompt.text = "Session stopped";
        result.enabled = false;
        attempt.enabled = false;
        // Hanin, this is for optionally reseting the currentIndex or disable buttons
    }
}
