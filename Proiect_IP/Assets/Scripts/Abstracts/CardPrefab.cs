using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class CardPrefab
{
    public string cardName;
    public int points;
    public Sprite illustration;
    public int ownerID;

    public CardPrefab()
    {

    }

    public CardPrefab(CardPrefab card)
    {
        this.cardName = card.cardName;
        this.points = card.points;
        this.illustration = card.illustration;
        this.ownerID = card.ownerID;
    }
}
