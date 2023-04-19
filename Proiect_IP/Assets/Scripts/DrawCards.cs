using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{
    public GameObject Card1;
    public GameObject Card2;
    public GameObject Player1Area, Player1DeckArea;
    public GameObject Player2Area, Player2DeckArea;
    public List <GameObject> cards = new List<GameObject>();
    public int turn = 0, cardnr0 = 0, cardnr1 = 0, drawDefault = 0;


    // Start is called before the first frame update
    void Start()
    {
        cards.Add(Card1);
        cards.Add(Card2);
    }

    public void OnClick()
    {
        if (drawDefault == 0)
        {
            for (int i = 0; i < 4; i++)
            {
                GameObject playerCardDeck1 = Instantiate(Card1, new Vector3(0, 0, 0), Quaternion.identity);
                playerCardDeck1.transform.SetParent(Player1DeckArea.transform, false);

                GameObject playerCardDeck2 = Instantiate(Card1, new Vector3(0, 0, 0), Quaternion.identity);
                playerCardDeck2.transform.SetParent(Player2DeckArea.transform, false);
            }
            drawDefault = 1;
        }
        else
        {
            if (turn == 0)
            {
                if (cardnr0 < 9)
                {
                    GameObject playerCard1 = Instantiate(Card2, new Vector3(0, 0, 0), Quaternion.identity);
                    playerCard1.transform.SetParent(Player1Area.transform, false);
                    turn = 1;
                    cardnr0++;
                }
            }
            else
            {
                if (cardnr1 < 9)
                {
                    GameObject playerCard2 = Instantiate(Card2, new Vector3(0, 0, 0), Quaternion.identity);
                    playerCard2.transform.SetParent(Player2Area.transform, false);
                    turn = 0;
                    cardnr1++;
                }
            }
        }
       

        //GameObject playerCard2 = Instantiate(Card2, new Vector3(0, 0, 0), Quaternion.identity);
    }


}
