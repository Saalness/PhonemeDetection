using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire : MonoBehaviour
{
    Vector3 startPoint;
    // Start is called before the first frame update
    void Start()
    {
        startPoint = transform.parent.position;
    }

    private void OnMouseDrag()
    {
        //set mouse position to world point
        Vector3 newPosition = GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition);
        newPosition.z = 0;

       /** BoxCollider2D[] colliders = Physics2D.OverlapCircleAll(newPosition, .2f, layerMask);
        foreach(BoxCollider2D collider in colliders)
        {
            if(collider.GameObject != GameObject)
            {
                UpdateWire(collider.transform.position);
                if(transform.parent.name.Equals(collider.transform.parent.name))
                {
                    Main.Instance.SwitchChange(1);
                    collider.GetComponent<Wire>()?.Done();
                    Done();
                }
                return;  
            }   
        }
        UpdateWire(newPosition); **/

        //update wire, position, and direction
        //Vector3 direction = newPosition - transform.newPosition;
        transform.position = newPosition - startPoint;
        //transform.right = direction;
        float dist = Vector2.Distance(startPoint, newPosition);
    }
    
    
}