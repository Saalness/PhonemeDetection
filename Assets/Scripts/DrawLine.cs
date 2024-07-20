using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    private LineRenderer line;
    [SerializeField] private string destinationTag;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();
    }
    private void OnMouseDown()
    {
        offset = transform.position - MouseWorldPosition();
        line.positionCount = 2;
        Debug.Log("The mouse is down");
    }
    private void OnMouseUp()
    {
        Debug.Log("The mouse is up");
        //Vector3 rayOrigin = GetComponent<Camera>().transform.position;
        //Vector3 rayDirection = MouseWorldPosition() - GetComponent<Camera>().transform.position;
        Vector3 rayOrigin = Camera.main.transform.position;
        Vector3 rayDirection = MouseWorldPosition() - Camera.main.transform.position;
        RaycastHit hitinfo;
        if(Physics.Raycast(rayOrigin, rayDirection, out hitinfo,Mathf.Infinity))
        {
            if(hitinfo.transform.tag == destinationTag)
            {
                line.SetPosition(0, hitinfo.transform.position);
               // Collider gObject = GameObject.GetComponent<BoxCollider2D>();
                //transform.gObject.enabled = false;
            }
            else
            {
                line.SetPosition(0, transform.position);
            }
        }
    }
    private void OnMouseDrag()
    {
        Debug.Log("The mouse is being dragged");
        line.SetPosition(0, MouseWorldPosition() +  offset);
        line.SetPosition(1, transform.position);
    }
    private Vector3 MouseWorldPosition()
    {
        Vector3 mouseScreenPosition = Input.mousePosition;
        //mouseScreenPosition.z = GetComponent<Camera>().WorldToScreenPoint(transform.position).z;
        //return GetComponent<Camera>().WorldToScreenPoint(mouseScreenPosition);
        mouseScreenPosition.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.WorldToScreenPoint(mouseScreenPosition);
    }
}

