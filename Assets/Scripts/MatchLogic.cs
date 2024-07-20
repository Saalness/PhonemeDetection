using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MatchLogic : MonoBehaviour
{
    //singleton
    static MatchLogic Instance;

    public int maxPoints;
    public TextMeshProUGUI pointsText;
    public GameObject levelCompleted;
    private int points = 0; 
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }
    // Update is called once per frame
    void UpdatePointsText()
    {
        pointsText.text = points + "/" + maxPoints;
        if(points == maxPoints)
        {
            levelCompleted.SetActive(true);
        }   
    }
    public static void AddPoint()
    {
        AddPoints(1);
    }
    public static void AddPoints(int points)
    {
        Instance.points += points;
        Instance.UpdatePointsText();
    }
}
