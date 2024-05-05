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
    [SerializeField] private Button button;
    static string[] words = { "at", "mad", "sad", "dad", "sat", "mat" };
    public List<string> wordlist = new List<string>(words);
    string word;

    // Start is called before the first frame update
    void Start()
    {
        result = GetComponent<UnityEngine.UI.Image>();
        result.enabled = false;
        prompt.text = words[0];
        CheckList();
    }

    // Update is called once per frame
    void Update()
    {
    }
    void CheckList()
    {
        for (int i = 0; i < wordlist.Count; i++)
        {
            word = wordlist[i];
            prompt.text = word;
            button.onClick.AddListener(CheckWord);
        }
    }
    void CheckWord()
    {
        if(text.text == word)
        {
            result.enabled = true;
        }
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
