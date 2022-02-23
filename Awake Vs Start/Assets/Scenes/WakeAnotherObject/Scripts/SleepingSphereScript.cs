using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepingSphereScript : MonoBehaviour
{
    public MeshRenderer renderer_;

    private bool firstUpdate_;

    private void Awake()
    {
        Debug.Log("Sphere Awake!");
        firstUpdate_ = true;
        renderer_.enabled = false;
    }

    void Start()
    {
        Debug.Log("Sphere Start!");
        renderer_.enabled = true;
    }

    private void Update()
    {
        if (firstUpdate_)
        {
            firstUpdate_ = false;
            Debug.Log("Sphere First Update!");
        }
    }
}
