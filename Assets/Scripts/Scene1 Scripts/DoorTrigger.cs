using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public AnimationTimer Animation;
    public GameObject Squaddie;
    public GameObject Squaddie2;
    static Animator anim1;
    static Animator anim2;

    private void Start()
    {
        anim1 = Squaddie.GetComponent<Animator>();
        anim2 = Squaddie2.GetComponent<Animator>();

    }

    private void Update()
    {
        if (Animation.close == true)
        {
            anim1.SetTrigger("Leap");
            anim2.SetTrigger("Leap");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Squaddies")
        {
        anim1.SetTrigger("Stop");
       anim2.SetTrigger("Stop");
        }

    }
}
