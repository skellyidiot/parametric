using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marker1Move : MonoBehaviour
{
    TrailRenderer tr;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<TrailRenderer>();
        tr.enabled = false;
        transform.position = PEQ.Circle(0, 4);
        tr.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time;
        transform.position = PEQ.Circle(t, 4);
    }
}
