using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card 
{
    public int CardID;
    public int ImageIndex;
    public string CardTitle = "";
    public string CardInfo = "";

    public Card(int cardID, string cardTitle, string cardInfo) 
    {
        this.CardID = cardID;
        this.CardTitle = cardTitle;
        this.CardInfo = cardInfo;
    }
    
}
