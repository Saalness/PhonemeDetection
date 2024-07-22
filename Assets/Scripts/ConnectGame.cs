using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ConnectGame : MonoBehaviour//, IPointerClickHandler, IPointerEnterHandler
{
    static string firstCard;
    static string secondCard;
    static string hoverCard;
    public int cardNum;
    public string cardTag;
    private float animationTime = 1f;
    private int score = 0;
    private int clicks = 0;
    private bool matching = false;
    static string[] cards = { "apple", "banana", "cup", "flower"};
    private List<string> cardList = new List<string>(cards);
    [SerializeField] public LineRenderer line0;
    [SerializeField] public LineRenderer line1;
    [SerializeField] public LineRenderer line2;
    [SerializeField] public LineRenderer line3;
    private LineRenderer line;

    void Start()
    {
        line0.enabled = false;
        line1.enabled = false;
        line2.enabled = false;
        line3.enabled = false;
    }
    //public void OnPointerEnter(PointerEventData eventData)
    //{
        
    //}
    // when the mouse is clicked, the card is assigned either as the first or second card
    //
    //public void OnPointerClick(PointerEventData eventData)
    public void CardClicked()
    {
        hoverCard = EventSystem.current.currentSelectedGameObject.tag;
        Debug.Log("A card was clicked: " + clicks);
        clicks++;
        if(clicks == 1)
        {
            //assign as first card
            firstCard = hoverCard;
            //set first click to false
            //firstClick = false;
            //set second as true
            //secondClick = true;
            //check if this condition is met
            Debug.Log("1 - First card was clicked..." + cardTag);
        }
        else if(clicks == 2)
        {
            //assign 2nd card
            secondCard = hoverCard;
            //assign 2nd click to false
            //secondClick = false;
            // [could be moved to after the check?] assign 1st click to true
            // firstClick = true;
            Debug.Log("2 - Second card was clicked..." + cardTag);
        }
        else
        {
            //reset to og state?
            Debug.Log("3 - Third card was clicked... please reset");
        }
        CheckCards();
    }
    void CheckCards()
    {
        if(clicks == 2)
        {
            if(firstCard == secondCard)
            {
                matching = true;
                score += score;
                Debug.Log("The cards match!");   
            }
            else
            {
                Debug.Log("They do not match");
            }
            Debug.Log("The first tag was: "+firstCard+" and the second was: "+secondCard);
            ConnectLine();
        }  
    }
    void ConnectLine()
    {
        if(matching == true)
        {
            Debug.Log("Draw a line between first and second cards then reset pls");
            tag = hoverCard;
            switch(tag)
            {
            case "cardA":
                line = line0;
                break;
            case "cardB":
                line = line1;
                break;
            case "cardC":
                line = line2;
                break;
            case "cardD":
                line = line3;
                break;
            }
            StartCoroutine(AnimateLine());
            //Destroy(firstCard);
            //Destroy(secondCard);
            //firstClick = true;
        }
        clicks = 0;
        matching = false;
    }
    private IEnumerator AnimateLine()
    {
        line.enabled = true;
        float startTime = Time.time;
        Vector3 startPos = line.GetPosition(0);
        Vector3 endPos = line.GetPosition(1);
        Vector3 pos = startPos;
        while(pos != endPos)
        {
            float t = (Time.time - startTime) / animationTime;
            pos = Vector3.Lerp(startPos, endPos, t);
            line.SetPosition(1, pos);
            yield return null;
        }
    }
}
