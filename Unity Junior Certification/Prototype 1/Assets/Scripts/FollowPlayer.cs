using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offeset = new Vector3(0, 5, -7);

    private void LateUpdate()
    {
        //Set camera position to player position + offset
        transform.position = player.transform.position + offeset;
    }
}
