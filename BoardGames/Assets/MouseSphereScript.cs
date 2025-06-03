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
        float z = -10;
        float x = 0;
        float y = 0;
        if (Physics.Raycast(ray, out RaycastHit hit) && !hit.collider.gameObject.CompareTag("MouseSphere"))
        {
            x = hit.point.x;
            y = hit.point.y-1;
            z = hit.point.z;
        }
        
        transform.position = new Vector3(x, y, z);
    }
}
