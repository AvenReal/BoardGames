using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public int CameraShake = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3((float) (Input.mousePosition.x - Screen.width/2.0) / CameraShake,
            (float)(Input.mousePosition.y - Screen.height/2.0) / CameraShake, -20);
    }
}
