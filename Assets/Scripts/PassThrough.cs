using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassThrough : MonoBehaviour
{
    private TrackManager trackManager;
    // Start is called before the first frame update
    void Start()
    {
        GameObject temp = GameObject.FindWithTag("TrackManager");
        trackManager = temp.GetComponent<TrackManager>();
    }

    public void OnTriggerEnter(Collider other)
    {
        trackManager.gateCount++;
    }
}
