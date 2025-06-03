using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSphereScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float z = 20;
        float x = (Input.mousePosition.x - Screen.width / 2);
        float y = (Input.mousePosition.y - Screen.height / 2);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            x = hit.transform.position.x;
            y = hit.transform.position.y;
            z = hit.transform.position.z;
        }
        
        transform.position = new Vector3(x, y, z);
    }
}
