using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>() ;



    void Awake ()
    {
        cardList.Add(new Card(1,"Simpson",2,"This is Homer"));
        cardList.Add(new Card(2,"Adventure",4,"He is Finn"));

    }
}
