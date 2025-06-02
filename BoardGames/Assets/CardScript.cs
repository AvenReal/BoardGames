using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.MemoryProfiler;
using UnityEngine;
using UnityEngine.Serialization;

public enum CardType
{
    Number
}


public class CardScript : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Animation")]
    [SerializeField] Animation Animation;
    
    [Header("Back")]
    [SerializeField] SpriteRenderer BackSprite;
    
    [Header("Front")]
    [SerializeField] SpriteRenderer FrontSprite;
    [SerializeField] TMP_Text DisplayText;
    
    [HideInInspector] public int value;
    [HideInInspector] public CardType type = CardType.Number;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            
            Flip();
        }
        
        if(Input.GetMouseButtonDown(1))
            FrontSprite.color = new Color(1f, 0f, 0f, 1f);
    }

    public void Flip()
    {
        if(Mathf.Approximately(gameObject.transform.rotation.y, -1))
            FrontToBackFlip();
        else
            BackToFrontFlip();
    }
    
    
    public void FrontToBackFlip()
    {
        Animation.Play("CardFrontToBackFlip");
        gameObject.transform.rotation = new Quaternion(0, 180, 0, 0);
    }

    public void BackToFrontFlip()
    {
        Animation.Play("CardBackToFrontFlip");
        gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
    }
}
