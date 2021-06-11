using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OncomingVehicles : MonoBehaviour
{
    private float speed = 10f;
    private bool start;
    
    // Start is called before the first frame update
    void Start()
    {
        start = false;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (PlayerController.playerController.horizontalInput != 0 || PlayerController.playerController.forwardInput != 0)
        {
            start = true;
        }

        if (start)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        
    }
}
