using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ConnectGame : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler
{
    static ConnectGame firstCard;
    static ConnectGame secondCard;
    static ConnectGame hoverCard;
    public int cardNum;
    public string cardTag;
    private bool firstClick;// = true;
    private bool secondClick;// = false;
    private int score = 0;
    private bool matching = false;

    void Start()
    {
        firstClick = true;
        secondClick = false;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        hoverCard = this;
    }
    // when the mouse is clicked, the card is assigned either as the first or second card
    //
    //public void CardClicked()
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("A card was clicked");
        if(firstClick == true)
        {
            //assign as first card
            firstCard = hoverCard;
            //set first click to false
            firstClick = false;
            //set second as true
            secondClick = true;
            //check if this condition is met
            Debug.Log("1 - First card was clicked...");
        }
        else if(secondClick == true)
        {
            //assign 2nd card
            secondCard = hoverCard;
            //assign 2nd click to false
            secondClick = false;
            // [could be moved to after the check?] assign 1st click to true
            // firstClick = true;
            Debug.Log("2 - Second card was clicked...");
        }
        else
        {
            //reset to og state?
            Debug.Log("3 - Third card was clicked... please reset");
        }
        CheckCards();
    }
    /**
    public bool IsFirstClick(int num)
    {
        return firstClick;
    }
    public bool IsSecondClick(int num)
    {
        return secondClick;
    }**/
    void CheckCards()
    {
        if(firstCard != null && secondCard != null)
        {
            if(firstCard.cardTag.Equals(secondCard.cardTag))
            {
                matching = true;
                score += score;
                Debug.Log("The cards match!");   
            }
            else
            {
                Debug.Log("They do not match");
            }
            Debug.Log("The first tag was: "+firstCard.cardTag+" and the second was: "+secondCard.cardTag);
        }
        ConnectLine();
    }
    void ConnectLine()
    {
        if(matching == true)
        {
            Debug.Log("Draw a line between first and second cards then reset pls");
            Destroy(firstCard);
            Destroy(secondCard);
        }
    }
}
