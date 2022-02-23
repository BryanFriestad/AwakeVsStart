using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedStart : MonoBehaviour
{
    public float waitTime_;
    public List<Rigidbody> rigidbodies_;

    IEnumerator Start()
    { 
        foreach(Rigidbody r in rigidbodies_)
        {
            r.isKinematic = true;
        }

        Debug.Log("Wait started");
        yield return new WaitForSeconds(waitTime_);
        Debug.Log("Wait done");

        foreach (Rigidbody r in rigidbodies_)
        {
            r.isKinematic = false;
        }
    }
}
