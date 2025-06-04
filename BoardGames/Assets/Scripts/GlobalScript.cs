using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            
            
            var interactable = hit.collider.gameObject.GetComponent<InteractibleScript>();
            
            Debug.Log(interactable);
            
            interactable.OnHover();
            
            if (Input.GetMouseButtonDown(0))
            {
                interactable.OnClick();
            }
        }
    }
}
