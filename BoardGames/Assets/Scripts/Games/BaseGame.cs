using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGame : MonoBehaviour
{
    public void CreateCardStack(Vector3 position, Stack<Card> cards)
    {
        var cardStack = Instantiate<GameObject>(Resources.Load<GameObject>("Prefabs/CardStack"));
        cardStack.transform.position = position;
        var cardStackScript = cardStack.GetComponent<CardStackScript>();
        
        cardStackScript.Cards = cards;
    }
}
