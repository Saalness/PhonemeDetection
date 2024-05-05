using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.IO;

public class SayWords : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private TextMeshProUGUI prompt;
    [SerializeField] public Image result;
    [SerializeField] public Image attempt;
    [SerializeField] private Button checkbutton;
    [SerializeField] private Button promptbutton;
    static string[] words = { "at", "mad", "sad", "dad", "sat", "mat" };
    public List<string> wordlist = new List<string>(words);
    string word;
    int i;

    // Start is called before the first frame update
    void Start()
    {
        //result = GetComponent<UnityEngine.UI.Image>();
        result.enabled = false;
        attempt.enabled = false;
        prompt.text = words[0];
        //CheckList(0);
        promptbutton.onClick.AddListener(CheckList);
        //checkbutton.onClick.AddListener(CheckWord);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void CheckList()
    {
        result.enabled = false;
        attempt.enabled = false;
        word = wordlist[i];
        prompt.text = word;
        if(text.text != "Sending..." || text.text != "Recording...") { CheckWord(); }
        if (i < wordlist.Count) { CheckList(); }
        
        /**for (int i = 0; i < wordlist.Count; i++)
        {
            word = wordlist[i];
            prompt.text = word;
            button.onClick.AddListener(CheckWord);

            //CheckWord();
        }**/
        prompt.text = "well done";
        
    }
    void CheckWord()
    {
        if(text.text.ToLower() == word)
        {
            result.enabled = true;
        }
        else { attempt.enabled = true; }
        i++;
    }
    private void AddWord(string word)
    {
        wordlist.Add(word);
    }
    private void DelWord(string delWord)
    {
        if (delWord != null)
            wordlist.Remove(delWord);
    }
}
