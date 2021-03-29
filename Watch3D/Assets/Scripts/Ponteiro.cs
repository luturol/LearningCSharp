using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ponteiro : MonoBehaviour
{
    [SerializeField] private GameObject secondsPointer;
    [SerializeField] private GameObject minutsPointer;
    [SerializeField] private GameObject hoursPointer;

    private const float secondsDegrees = 360 / 60;
    private const float minutsDegrees = 360f / 3600f; //seconds in an hour
    private const float hoursDegrees = 360f / 43200f; // seconds in 12 hours

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        secondsPointer.transform.rotation = Quaternion.Euler(0, 0, Time.time * -secondsDegrees);
        minutsPointer.transform.rotation = Quaternion.Euler(0, 0, Time.time * -minutsDegrees);
        hoursPointer.transform.rotation = Quaternion.Euler(0, 0, Time.time * -hoursDegrees);
    }    
}
