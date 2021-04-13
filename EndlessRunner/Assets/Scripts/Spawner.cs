using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : Interactable
{
    [SerializeField] GameObject obstacle;
    
    [Header("Spawn and Destroy points")]
    [SerializeField] Transform endpoint;
    [SerializeField] Transform spawn;

    private float timeTillNextSpawn = 3f;
    private float currentTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(currentTime >= timeTillNextSpawn)    
        {
            var obstacleInstantiated = Instantiate(obstacle, spawn.transform.position, Quaternion.identity);
            obstacle.GetComponent<ObstacleMovement>().SetEndpoint(endpoint);
            currentTime = 0f;
        }
        else{
            currentTime += Time.deltaTime;
        }
    }
}
