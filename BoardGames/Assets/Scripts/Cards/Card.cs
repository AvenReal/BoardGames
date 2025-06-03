using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardType
{
    Number
}


public class Card
{
    public int Value;
    public CardType Type = CardType.Number;
    public bool Pickable = false;
    public string DisplayValue => Type == CardType.Number ? Value.ToString() : Type.ToString();
    public Color Color => Type == CardType.Number ? Color.white : Color.red; 
    
    public CardScript Instantiate(Transform parent)
    {
        var card = GameObject.Instantiate<GameObject>(Resources.Load<GameObject>("Prefabs/Card"), parent);
        card.GetComponent<CardScript>().SetCard( this);
        return card.GetComponent<CardScript>();
    }
}
