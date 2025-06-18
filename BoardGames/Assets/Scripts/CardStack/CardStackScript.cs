using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class CardStack : InteractibleScript
{
    [SerializeField] public Stack<Card> Cards = new Stack<Card>();
    public bool FacingUp = false;
    public void Push(Card card)
    {
        Cards.Push(card);
    }

    private void Update()
    {
            
    }


    public override void OnClick()
    {
        if(Cards.Count == 0)
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
