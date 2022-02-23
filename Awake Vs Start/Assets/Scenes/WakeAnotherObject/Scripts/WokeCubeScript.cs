using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WokeCubeScript : MonoBehaviour
{
    public SleepingSphereScript objToWake_;

    private void Awake()
    {
        Debug.Log("Cube Awake!");
    }

    void Start()
    {
        Debug.Log("Cube Start!");
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && !objToWake_.enabled)
        {
            Debug.Log("Cube is waking up Sphere");
            objToWake_.enabled = true;
        }
    }
}
