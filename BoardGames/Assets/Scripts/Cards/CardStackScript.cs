using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardStack : MonoBehaviour
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
}
