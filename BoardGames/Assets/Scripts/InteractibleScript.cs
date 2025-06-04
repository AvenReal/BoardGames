using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class InteractibleScript : MonoBehaviour
{
    [FormerlySerializedAs("Interactable")] public bool Interactible = false;
    
    public virtual void OnClick(){}

    public virtual void OnHover(){}
}
