using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Events;

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
        checkButton.onClick.AddListener(checkButtonClicked);
        stopButton.onClick.AddListener(StopExercise);
    }

    void checkButtonClicked()
    {
        StartCoroutine(Coroutine());
    }

    IEnumerator Coroutine()
    {
        //var waitForButton = new WaitForUIButtons(checkButton);
        //yield return waitForButton.Reset();
       // if(waitForButton.PressedButton)
       // {
            //timer when coroutine function is called
            Debug.Log("Started checking word at timestamp: " + Time.time);

            //yield a new instruction to wait 500 ms
            yield return new WaitForSeconds(1f);

            //after waiting the timestamp is shown
            Debug.Log("The final check was done at timestamp: " + Time.time);
            CheckWord();
       // }
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
        //wait(500);
        if(text.text != "Sending..." && text.text != "Recording..." && text.text != ""){
            if(text.text.ToLower().Contains(wordlist[currentIndex].ToLower()))
            {
                result.enabled = true;
                attempt.enabled = false;
            }
            else
            {
                result.enabled = false;
                attempt.enabled = true;
            }
            Debug.Log("The word that was said was: " + text.text.ToLower());
            Debug.Log("The prompt was: " + wordlist[currentIndex]);
            }
        else {CheckWord();}
  
    }


    void StopExercise()
    {
        //logic to execute when the stop button is pressed
        prompt.text = "Session stopped";
        result.enabled = false;
        attempt.enabled = false;
        //optionally reseting the currentIndex or disable buttons
    }
/**
    public void wait(int milliseconds)
    {
        var timer1 = new System.Windows.Forms.Timer();
        if (milliseconds == 0 || milliseconds < 0) return;

        // Console.WriteLine("start wait timer");
        timer1.Interval = milliseconds;
        timer1.Enabled  = true;
        timer1.Start();

        timer1.Tick += (s, e) =>
        {
            timer1.Enabled = false;
            timer1.Stop();
            // Console.WriteLine("stop wait timer");
        };

        while (timer1.Enabled)
        {
            Application.DoEvents();
        }
    }**/
}
