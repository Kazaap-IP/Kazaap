using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{
    public GameObject p1, p2, p3, p4, p5, p6, m1, m2, m3, m4, m5 , m6;
    //public GameManager manager;
    public GameObject reg1, reg2, reg3, reg4, reg5, reg6, reg7, reg8, reg9, reg10;
    public GameObject Player1Area, Player1DeckArea;
    public GameObject Player2Area, Player2DeckArea;
    public List<GameObject> defaultCards = new List<GameObject>();
    public List<GameObject> personalcards = new List<GameObject>();
    public int turn = 0, cardnr0 = 0, cardnr1 = 0, drawDefault = 0;


    // Start is called before the first frame update
    void Start()
    {
        defaultCards.Add(p1);
        defaultCards.Add(p2);
        defaultCards.Add(p3);
        defaultCards.Add(p4);
        defaultCards.Add(p5);
        defaultCards.Add(p6);
        defaultCards.Add(m1);
        defaultCards.Add(m2);
        defaultCards.Add(m3);
        defaultCards.Add(m4);
        defaultCards.Add(m5);
        defaultCards.Add(m6);
        personalcards.Add(reg1);
        personalcards.Add(reg2);
        personalcards.Add(reg3);
        personalcards.Add(reg4);
        personalcards.Add(reg5);
        personalcards.Add(reg6);
        personalcards.Add(reg7);
        personalcards.Add(reg8);
        personalcards.Add(reg9);
        personalcards.Add(reg10);
    }

    public void OnClick()
    {
        if (drawDefault == 0)
        {
            for (int i = 0; i < 4; i++)
            {
                GameObject playerCardDeck1 = Instantiate(defaultCards[Random.Range(0, defaultCards.Count)], new Vector3(0, 0, 0), Quaternion.identity);
                playerCardDeck1.transform.SetParent(Player1DeckArea.transform, false);

                GameObject playerCardDeck2 = Instantiate(defaultCards[Random.Range(0, defaultCards.Count)], new Vector3(0, 0, 0), Quaternion.identity);
                playerCardDeck2.transform.SetParent(Player2DeckArea.transform, false);
            }
            drawDefault = 1;
        }
        else
        {
            if (GameManager.both == 0)
            {
                if (GameManager.turn == 0)
                {
                    if (cardnr0 < 9)
                    {
                        GameObject card = personalcards[Random.Range(0, personalcards.Count)];
                        GameObject playerCard1 = Instantiate(card, new Vector3(0, 0, 0), Quaternion.identity);
                        if (card.Equals(reg1))
                            GameManager.score1 += 1;
                        if (card.Equals(reg2))
                            GameManager.score1 += 2;
                        if (card.Equals(reg3))
                            GameManager.score1 += 3;
                        if (card.Equals(reg4))
                            GameManager.score1 += 4;
                        if (card.Equals(reg5))
                            GameManager.score1 += 5;
                        if (card.Equals(reg6))
                            GameManager.score1 += 6;
                        if (card.Equals(reg7))
                            GameManager.score1 += 7;
                        if (card.Equals(reg8))
                            GameManager.score1 += 8;
                        if (card.Equals(reg9))
                            GameManager.score1 += 9;
                        if (card.Equals(reg10))
                            GameManager.score1 += 10;
                        if (GameManager.score1 > 20)
                            Debug.Log("Player 2 has won!");

                        playerCard1.transform.SetParent(Player1Area.transform, false);
                        GameManager.turn = 1;
                        cardnr0++;
                    }
                }
                else
                {
                    if (cardnr1 < 9)
                    {

                        GameObject card = personalcards[Random.Range(0, personalcards.Count)];
                        GameObject playerCard2 = Instantiate(card, new Vector3(0, 0, 0), Quaternion.identity);
                        if (card.Equals(reg1))
                            GameManager.score2 += 1;
                        if (card.Equals(reg2))
                            GameManager.score2 += 2;
                        if (card.Equals(reg3))
                            GameManager.score2 += 3;
                        if (card.Equals(reg4))
                            GameManager.score2 += 4;
                        if (card.Equals(reg5))
                            GameManager.score2 += 5;
                        if (card.Equals(reg6))
                            GameManager.score2 += 6;
                        if (card.Equals(reg7))
                            GameManager.score2 += 7;
                        if (card.Equals(reg8))
                            GameManager.score2 += 8;
                        if (card.Equals(reg9))
                            GameManager.score2 += 9;
                        if (card.Equals(reg10))
                            GameManager.score2 += 10;

                        if (GameManager.score2 > 20)
                            Debug.Log("Player 1 has won!");
                        playerCard2.transform.SetParent(Player2Area.transform, false);
                        GameManager.turn = 0;
                        cardnr1++;
                    }
                }
            } else if (GameManager.both == 1)
            {
                    if (cardnr1 < 9)
                    {

                        GameObject card = personalcards[Random.Range(0, personalcards.Count)];
                        GameObject playerCard2 = Instantiate(card, new Vector3(0, 0, 0), Quaternion.identity);
                        if (card.Equals(reg1))
                            GameManager.score2 += 1;
                        if (card.Equals(reg2))
                            GameManager.score2 += 2;
                        if (card.Equals(reg3))
                            GameManager.score2 += 3;
                        if (card.Equals(reg4))
                            GameManager.score2 += 4;
                        if (card.Equals(reg5))
                            GameManager.score2 += 5;
                        if (card.Equals(reg6))
                            GameManager.score2 += 6;
                        if (card.Equals(reg7))
                            GameManager.score2 += 7;
                        if (card.Equals(reg8))
                            GameManager.score2 += 8;
                        if (card.Equals(reg9))
                            GameManager.score2 += 9;
                        if (card.Equals(reg10))
                            GameManager.score2 += 10;

                        if (GameManager.score2 > 20)
                            Debug.Log("Player 1 has won!");
                        playerCard2.transform.SetParent(Player2Area.transform, false);
                        GameManager.turn = 0;
                        cardnr1++;
                    }
          
            }
            else if (GameManager.both == 2)
            {
                if (cardnr0 < 9)
                {
                    GameObject card = personalcards[Random.Range(0, personalcards.Count)];
                    GameObject playerCard1 = Instantiate(card, new Vector3(0, 0, 0), Quaternion.identity);
                    if (card.Equals(reg1))
                        GameManager.score1 += 1;
                    if (card.Equals(reg2))
                        GameManager.score1 += 2;
                    if (card.Equals(reg3))
                        GameManager.score1 += 3;
                    if (card.Equals(reg4))
                        GameManager.score1 += 4;
                    if (card.Equals(reg5))
                        GameManager.score1 += 5;
                    if (card.Equals(reg6))
                        GameManager.score1 += 6;
                    if (card.Equals(reg7))
                        GameManager.score1 += 7;
                    if (card.Equals(reg8))
                        GameManager.score1 += 8;
                    if (card.Equals(reg9))
                        GameManager.score1 += 9;
                    if (card.Equals(reg10))
                        GameManager.score1 += 10;
                    if (GameManager.score1 > 20)
                        Debug.Log("Player 2 has won!");

                    playerCard1.transform.SetParent(Player1Area.transform, false);
                    GameManager.turn = 1;
                    cardnr0++;
                }

            }
            else if(GameManager.both == 3)
            {
                if(GameManager.score1 > GameManager.score2) {
                    Debug.Log("Player 1 has won!");
                }
                else if (GameManager.score1 < GameManager.score2) {
                    Debug.Log("Player 2 has won!");
                }
                else if(GameManager.score1 == GameManager.score2)
                {
                    Debug.Log("Draw!");
                }
            }
        }


        //GameObject playerCard2 = Instantiate(Card2, new Vector3(0, 0, 0), Quaternion.identity);
    }


}
