using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PsyonicDoorTrigger : MonoBehaviour
{
    public GameObject Psyonic;
    static Animator anim1;
    public AnimationTimer Animation;

    private void Start()
    {
        anim1 = Psyonic.GetComponent<Animator>();
    }

    private void Update()
    {
        if (Animation.point == true)
        {
            anim1.SetTrigger("Point");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Psyonic")
        {
            anim1.SetTrigger("Stop");
        }

    }
}
