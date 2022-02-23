using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteInEditMode]
public class OnEnableTestScript : MonoBehaviour
{
    public TextMeshProUGUI text_;

    private void Awake()
    {
        Debug.Log("Awake!");
    }

    void Start()
    {
        text_.text += "Started! (Only called once, after first enable)\n";
    }

    private void OnEnable()
    {
        text_.text += "Enabled!\n";
    }
}
