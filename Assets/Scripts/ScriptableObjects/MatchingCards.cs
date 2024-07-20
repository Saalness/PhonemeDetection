using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Card", menuName = "Card Game Objects/Card")]
public class MatchingCards : ScriptableObject
{
    public string cardName;
    public string pairName;
    public Sprite cardIcon;
}
