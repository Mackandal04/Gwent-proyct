using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowCards : MonoBehaviour
{
    public List<Card> ShowCard = new List<Card>();
    public int displayId;


    public int Id ;
    public string cardNAme ;
    public int cost;
    public string description;

    public TextMeshPro nameText;
    public TextMeshPro costText;
    public TextMeshPro descriptionText;
    


    void Start()
    {
        ShowCard[0] = CardDatabase.cardList[displayId];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
