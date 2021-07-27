using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;    
    public bool isThirdView = true;
    private Vector3 offeset = new Vector3(0, 5, -7);
    private Vector3 offsetFronAngle = new Vector3(0,2.1500001f,1.19000006f);
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            isThirdView = !isThirdView;
        }
    }

    private void LateUpdate()
    {
        if (isThirdView)
        {
            //Set camera position to player position + offset
            transform.position = player.transform.position + offeset;
        }
        else
        {
            transform.position = player.transform.position + offsetFronAngle;
        }
    }
}
