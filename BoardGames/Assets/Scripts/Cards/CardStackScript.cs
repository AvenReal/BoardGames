using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class CardStack : MonoBehaviour
{
    private Stack<Card> _cards = new Stack<Card>();
    
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
    
    
}
