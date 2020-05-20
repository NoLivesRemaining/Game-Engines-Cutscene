using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulsingScript : MonoBehaviour
{
    public int TimeScale;
    public int ScaleScale;

    void Update()
    {
        Vector3 vec = new Vector3(Mathf.Sin(Time.time *TimeScale) + ScaleScale, Mathf.Sin(Time.time * TimeScale) + ScaleScale, Mathf.Sin(Time.time * TimeScale) + ScaleScale);

        transform.localScale = vec;
    }
}
