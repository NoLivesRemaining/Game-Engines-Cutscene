using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTimer : MonoBehaviour
{
    public bool close;
    public bool point;
    public float PointTime = 22f;

    private void Start()
    {
        point = false;
        close = false;
    }

    private void Update()
    {
        if(PointTime == 0)
        {
            close = true;
        }

        if (PointTime <= 1)
        {
            point = true;
        }

        if (PointTime >= 0)
        {

            PointTime -= Time.deltaTime;
        }

        if (PointTime <= 0)
        {
            PointTime = 0;
        }
        
    }

}
