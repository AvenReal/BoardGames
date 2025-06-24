using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.MemoryProfiler;
using UnityEngine;
using UnityEngine.Serialization;




public class CardScript : InteractibleScript
{
    [Header("Animation")]
    [SerializeField] Animation Animation;
    
    [Header("Back")]
    [SerializeField] SpriteRenderer BackSprite;
    
    [Header("Front")]
    [SerializeField] SpriteRenderer FrontSprite;
    [SerializeField] TMP_Text DisplayText;
    
    [HideInInspector] public Card Card;
    private bool _faceUp = false;
    
    
    public void SetCard(Card card)
    {
        Card = card;
        DisplayText.text = card.DisplayValue;
        FrontSprite.color = card.Color;
    }

    public void Update()
    {
        BackSprite.color = Interactible ?  Color.white : Color.gray;
    }

    # region Flips
    public void Flip()
    {
        if(_faceUp)
            FrontToBackFlip();
        else
            BackToFrontFlip();
    }
    
    public void FrontToBackFlip()
    {
        if(!_faceUp)
            return;
        _faceUp = !_faceUp;
        Animation.Play("CardFrontToBackFlip");
        //gameObject.transform.rotation = new Quaternion(0, 180, 0, 0);
    }

    public void BackToFrontFlip()
    {
        if(_faceUp)
            return;
        _faceUp = !_faceUp;
        Animation.Play("CardBackToFrontFlip");
        //gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
    }
    
    #endregion

    public override void OnClick()
    {
        base.OnClick();
        
        if(!Interactible)
            return;
        
        if(GlobalScript.Instance.SelectedCard != null)
            GlobalScript.Instance.SelectedCard = gameObject;
        
        if(GlobalScript.Instance.SelectedCard == gameObject)
            GlobalScript.Instance.SelectedCard = null;
    }

    public override void OnHover()
    {
        if(!Interactible)
            return;

        Animation.Play("CardHover");
    }

    
}
