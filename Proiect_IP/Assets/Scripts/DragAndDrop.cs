using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq.Expressions;
using TMPro;
using UnityEngine;


public class DragAndDrop : MonoBehaviour
{
    private bool isDragging = false;
    private Vector2 startPosition;
    public GameObject Card;
    public GameObject Player1Hand;
    public GameObject Player2Hand;
    public GameObject p1, p2, p3, p4, p5, p6, m1, m2, m3, m4, m5, m6;
    //public GameManager manager;
    public bool isInDropZone = false;
    public GameObject Canvas;
    private GameObject startParent;
    //public int player1Score;
    //public TextMeshProUGUI p1ScoreText;
    public static GameObject p1ScoreObject;
    TextMeshProUGUI p1ScoreText;
    public static GameObject p2ScoreObject;
    TextMeshProUGUI p2ScoreText;

    private void Awake()
    {
        Canvas = GameObject.Find("Main Canvas");
        p1ScoreObject = GameObject.Find("P1Points");
        p1ScoreText = p1ScoreObject.GetComponent<TextMeshProUGUI>();
        p2ScoreObject = GameObject.Find("P2Points");
        p2ScoreText = p2ScoreObject.GetComponent<TextMeshProUGUI>();
        //player1Score = 0;
    }

    private void Start()
    {
        //Canvas = GameObject.Find("Main Canvas");
        //p1ScoreObject = GameObject.Find("P1Points");
        //p1ScoreText = p1ScoreObject.GetComponent<TextMeshProUGUI>();
        //player1Score = 0;

    }

    private void UpdateScore(int scoreToAdd)
    {
        if (GameManager.turn == 0)
            GameManager.score1 += scoreToAdd;
        else
            GameManager.score2 += scoreToAdd;
        //p1ScoreText.text = " " + scoreToAdd;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            transform.SetParent(Canvas.transform, true);
        }
        p1ScoreText.text = GameManager.score1.ToString();
        p2ScoreText.text = GameManager.score2.ToString();
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                Debug.Log(hit.transform.gameObject.name);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isInDropZone = true;
        Player1Hand = collision.gameObject;
        Player2Hand = collision.gameObject;
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        isInDropZone = false;
        Player1Hand = null;
        Player2Hand = null;
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
            if (GameManager.both == 0)
            {
                if (GameManager.turn == 0)
                {
                    transform.SetParent(Player1Hand.transform, false);
                    if (Card.Equals(p1))
                        GameManager.score1 += 1;
                    if (Card.Equals(p2))
                        GameManager.score1 += 2;
                    if (Card.Equals(p3))
                        GameManager.score1 += 3;
                    if (Card.Equals(p4))
                        GameManager.score1 += 4;
                    if (Card.Equals(p5))
                        GameManager.score1 += 5;
                    if (Card.Equals(p6))
                        GameManager.score1 += 6;
                    if (Card.Equals(m1))
                        GameManager.score1 -= 1;
                    if (Card.Equals(m2))
                        GameManager.score1 -= 2;
                    if (Card.Equals(m3))
                        GameManager.score1 -= 3;
                    if (Card.Equals(m4))
                        GameManager.score1 -= 4;
                    if (Card.Equals(m5))
                        GameManager.score1 -= 5;
                    if (Card.Equals(m6))
                        GameManager.score1 -= 6;
                    if (GameManager.score1 > 20)
                        Debug.Log("Player 2 has won!");

                    GameManager.turn = 1;
                }
                else
                {
                    transform.SetParent(Player2Hand.transform, false);
                    if (Card.Equals(p1))
                        GameManager.score2 += 1;
                    if (Card.Equals(p2))
                        GameManager.score2 += 2;
                    if (Card.Equals(p3))
                        GameManager.score2 += 3;
                    if (Card.Equals(p4))
                        GameManager.score2 += 4;
                    if (Card.Equals(p5))
                        GameManager.score2 += 5;
                    if (Card.Equals(p6))
                        GameManager.score2 += 6;
                    if (Card.Equals(m1))
                        GameManager.score2 -= 1;
                    if (Card.Equals(m2))
                        GameManager.score2 -= 2;
                    if (Card.Equals(m3))
                        GameManager.score2 -= 3;
                    if (Card.Equals(m4))
                        GameManager.score2 -= 4;
                    if (Card.Equals(m5))
                        GameManager.score2 -= 5;
                    if (Card.Equals(m6))
                        GameManager.score2 -= 6;

                    if (GameManager.score2 > 20)
                        Debug.Log("Player 1 has won!");
                    GameManager.turn = 0;
                }


            }
            else if (GameManager.both == 1)
            {
                transform.SetParent(Player2Hand.transform, false);
                if (Card.Equals(p1))
                    GameManager.score2 += 1;
                if (Card.Equals(p2))
                    GameManager.score2 += 2;
                if (Card.Equals(p3))
                    GameManager.score2 += 3;
                if (Card.Equals(p4))
                    GameManager.score2 += 4;
                if (Card.Equals(p5))
                    GameManager.score2 += 5;
                if (Card.Equals(p6))
                    GameManager.score2 += 6;
                if (Card.Equals(m1))
                    GameManager.score2 -= 1;
                if (Card.Equals(m2))
                    GameManager.score2 -= 2;
                if (Card.Equals(m3))
                    GameManager.score2 -= 3;
                if (Card.Equals(m4))
                    GameManager.score2 -= 4;
                if (Card.Equals(m5))
                    GameManager.score2 -= 5;
                if (Card.Equals(m6))
                    GameManager.score2 -= 6;

                if (GameManager.score2 > 20)
                    Debug.Log("Player 1 has won!");
            }
            else if (GameManager.both == 2)
            {
                transform.SetParent(Player1Hand.transform, false);
                if (Card.Equals(p1))
                    GameManager.score1 += 1;
                if (Card.Equals(p2))
                    GameManager.score1 += 2;
                if (Card.Equals(p3))
                    GameManager.score1 += 3;
                if (Card.Equals(p4))
                    GameManager.score1 += 4;
                if (Card.Equals(p5))
                    GameManager.score1 += 5;
                if (Card.Equals(p6))
                    GameManager.score1 += 6;
                if (Card.Equals(m1))
                    GameManager.score1 -= 1;
                if (Card.Equals(m2))
                    GameManager.score1 -= 2;
                if (Card.Equals(m3))
                    GameManager.score1 -= 3;
                if (Card.Equals(m4))
                    GameManager.score1 -= 4;
                if (Card.Equals(m5))
                    GameManager.score1 -= 5;
                if (Card.Equals(m6))
                    GameManager.score1 -= 6;
                if (GameManager.score1 > 20)
                    Debug.Log("Player 2 has won!");
            }
        } 
        else
        {
            transform.position = startPosition;
            transform.SetParent(startParent.transform, false);
        }
        
        
    }
}