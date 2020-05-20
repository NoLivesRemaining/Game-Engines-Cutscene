using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationTimer : MonoBehaviour
{
    public bool close;
    public bool point;
    public float PointTime = 22f;
    public float changeScene = 30f;

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

        if (PointTime <= 2)
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

        if (changeScene <= 0)
        {
            changeScene = 0;
        }

        if (changeScene == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (changeScene >= 0)
        {

            changeScene -= Time.deltaTime;
        }

      
    }

}
