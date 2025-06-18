using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class CardStack : InteractibleScript
{
    private Stack<Card> _cards = new Stack<Card>();

    [SerializeField] private TMP_Text _debugDisplay; 
    
    [CanBeNull] public CardScript GetTopCard()
    {
        if(_cards.TryPeek(out Card card))
            return card.Instantiate(gameObject.transform);
        
        return null;
    }
    
    public void Push(Card card)
    {
        _cards.Push(card);
    }

    private void Update()
    {
        _debugDisplay.text = "";
        foreach (var card in _cards)
        {
            _debugDisplay.text += $"{card.DisplayValue}\n";
        }
    }


    public override void OnClick()
    {
        if(_cards.Count == 0)
            return;
        var newCard = Instantiate<GameObject>(Resources.Load<GameObject>("Prefabs/Card"), transform);
        newCard.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z  + transform.localScale.z/2);
        var newCardScript = newCard.GetComponent<CardScript>();
        
        newCardScript.OnClick();


    }

    public override void OnHover()
    {
        
    }
}
