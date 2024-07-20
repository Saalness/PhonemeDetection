using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundBoard : MonoBehaviour
{
    [SerializeField] private Canvas firstSet;
    [SerializeField] private Canvas secondSet; 
    [SerializeField] private Canvas thirdSet; 
    [SerializeField] private Canvas fourthSet; 
    [SerializeField] private Canvas fifthSet;
    [SerializeField] private Canvas settings;
    [SerializeField] private Button firstBtn;
    [SerializeField] private Button secondBtn;
    [SerializeField] private Button thirdBtn;
    [SerializeField] private Button fourthBtn;
    [SerializeField] private Button fifthBtn;
    // Start is called before the first frame update
    void Start()
    {
        firstSet.enabled = true; //shown
        secondSet.enabled = false;
        thirdSet.enabled = false;
        fourthSet.enabled = false;
        fifthSet.enabled = false;
        firstBtn.enabled = true; //shown
        secondBtn.enabled = false;
        thirdBtn.enabled = false;
        fourthBtn.enabled = false;
        fifthBtn.enabled = false;
        settings.enabled = false;
    }
    public void ShowSettings()
    {
        settings.enabled = true;
    }
    public void HideSettings()
    {
        settings.enabled = false;
    }
    public void ShowFirst()
    {
        firstSet.enabled = true; //shown
        secondSet.enabled = false;
        thirdSet.enabled = false;
        fourthSet.enabled = false;
        fifthSet.enabled = false;
        firstBtn.enabled = true; //shown
        secondBtn.enabled = false;
        thirdBtn.enabled = false;
        fourthBtn.enabled = false;
        fifthBtn.enabled = false;
    }
        public void ShowSecond()
    {
        firstSet.enabled = false;
        secondSet.enabled = true; //shown
        thirdSet.enabled = false;
        fourthSet.enabled = false;
        fifthSet.enabled = false;
        firstBtn.enabled = false;
        secondBtn.enabled = true; //shown
        thirdBtn.enabled = false;
        fourthBtn.enabled = false;
        fifthBtn.enabled = false;
    }
        public void ShowThird()
    {
        firstSet.enabled = false;
        secondSet.enabled = false;
        thirdSet.enabled = true; //shown
        fourthSet.enabled = false;
        fifthSet.enabled = false;
        firstBtn.enabled = false;
        secondBtn.enabled = false;
        thirdBtn.enabled = true; //shown
        fourthBtn.enabled = false;
        fifthBtn.enabled = false;
    }
        public void ShowFourth()
    {
        firstSet.enabled = false;
        secondSet.enabled = false;
        thirdSet.enabled = false;
        fourthSet.enabled = true; //shown
        fifthSet.enabled = false;
        firstBtn.enabled = false;
        secondBtn.enabled = false;
        thirdBtn.enabled = false;
        fourthBtn.enabled = true; //shown
        fifthBtn.enabled = false;
    }
        public void ShowFifth()
    {
        firstSet.enabled = false;
        secondSet.enabled = false;
        thirdSet.enabled = false;
        fourthSet.enabled = false;
        fifthSet.enabled = true; //shown
        firstBtn.enabled = false;
        secondBtn.enabled = false;
        thirdBtn.enabled = false;
        fourthBtn.enabled = false;
        fifthBtn.enabled = true; //shown
    }
}
