using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglingScript : MonoBehaviour
{
    public OnEnableTestScript objToToggle_;

    private float toggleTime_;

    void Awake()
    {
        toggleTime_ = 0;
    }

    private void Update()
    {
        toggleTime_ += Time.deltaTime;
        if (toggleTime_ > 1.5f)
        {
            toggleTime_ -= 1.5f;
            ToggleObj();
        }
    }

    private void ToggleObj()
    {
        objToToggle_.enabled = !objToToggle_.enabled;
    }
}
