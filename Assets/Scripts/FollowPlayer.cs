using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    private Vector3 offSet = new Vector3(0, 6.5f, -9.2f);
    
    // Start is called before the first frame update
    void Start()
    {        
        
    }

    // LateUpdate is called once per frame after Update
    void LateUpdate()
    {
        // There we get the player's position and adds offset so the camera stays behind of player
        transform.position = player.transform.position + offSet;        
    }
}
