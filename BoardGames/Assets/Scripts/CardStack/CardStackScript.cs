using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class CardStackScript : InteractibleScript
{
    [SerializeField] public SpriteRenderer SpriteRenderer;
    
    public Stack<Card> Cards = new Stack<Card>();
    
    public bool FacingUp = false;
    public void Push(Card card)
    {
        Cards.Push(card);
    }

    private void Update()
    {
        SpriteRenderer.color = new Color(1f, 1f, 1f, Cards.Count == 0 ? 0f : 1f);
    }


    public override void OnClick()
    {
        if(Cards.Count == 0)
            return;
        var newCard = Cards.Peek().Instantiate(parent: transform);
        var newCardScript = newCard.GetComponent<CardScript>();
        
        newCardScript.OnClick();


    }

    public override void OnHover()
    {
        
    }
}
