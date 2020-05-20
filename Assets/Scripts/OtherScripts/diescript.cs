using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diescript : MonoBehaviour
{
    public float die = 5f;
    public GameObject target;
    public GameObject explosion;
    public GameObject explosionspot;
    public bool blowup;

    private void Start()
    {
        blowup = false;
    }

    private void Update()
    {
        if (die <= 0)
        {
            die = 0;
        }

        if (die == 0)
        {
            if(blowup == false)
            {
                Instantiate(explosion, explosionspot.transform);
                blowup = true;
            }

            Destroy(target);
        }

        if (die >= 0)
        {

            die -= Time.deltaTime;
        }
    }
}
