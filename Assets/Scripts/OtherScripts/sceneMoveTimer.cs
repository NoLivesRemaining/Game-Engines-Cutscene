using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneMoveTimer : MonoBehaviour
{
    public float changeScene;

    private void Update()
    {
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
