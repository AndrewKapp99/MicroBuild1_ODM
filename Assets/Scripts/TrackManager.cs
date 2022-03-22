using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> markers;

    public int gateCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < markers.Count; i++)
        {
            if (i == 0)
            {
                markers[i].GetComponent<TrackMarker>().ActivateMarker();
            }
            else
            {
                markers[i].GetComponent<TrackMarker>().DeactivateMArker();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gateCount >= markers.Count)
        {
            gateCount = 0;
        }

        for (int i = 0; i < markers.Count; i++)
        {
            if (i == gateCount)
            {
                markers[i].GetComponent<TrackMarker>().ActivateMarker();
            }
            else
            {
                markers[i].GetComponent<TrackMarker>().DeactivateMArker();
            }
        }
    }
}
