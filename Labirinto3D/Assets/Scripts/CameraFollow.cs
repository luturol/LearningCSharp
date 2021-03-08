using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject player;

    private Vector3 distance;

    // Start is called before the first frame update
    void Start()
    {
        distance = transform.position - player.transform.position;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        
    void LateUpdate()
    {
        transform.position = player.transform.position + distance;
    }
}
