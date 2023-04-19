using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;


public class DragAndDrop : MonoBehaviour
{
    private bool isDragging = false;
    private Vector2 startPosition;
    public GameObject Card1;
    public GameObject Player1Hand;
    public GameObject Player2Hand;
    public bool isInDropZone = false;
    public GameObject Canvas;
    private GameObject startParent;

    private void Awake()
    {
        Canvas = GameObject.Find("Main Canvas");

    }

    // Update is called once per frame
    void Update()
    {
        if (isDragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            transform.SetParent(Canvas.transform, true);    
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isInDropZone = true;
        Player1Hand = collision.gameObject;
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        isInDropZone = false;
        Player1Hand = null;
    }
    public void startDrag()
    {
        startParent = transform.parent.gameObject;
        startPosition = transform.position;
        isDragging = true;
    }
    
    public void endDrag()
    {
        isDragging = false;
        if (isInDropZone)
        {
           transform.SetParent(Player1Hand.transform, false);
        }
        //if (isInDropZone2) {
        //   transform.SetParent(Player2Hand.transform, false);
        //}
        else
        {
            transform.position = startPosition;
            transform.SetParent(startParent.transform, false);
        }
       
    }
}

