using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCameraChanger : MonoBehaviour
{
    public Camera First;
    public Camera Second;
    // Start is called before the first frame update
    void Start()
    {
        First.enabled = true;
        Second.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            First.enabled = false;
            Second.enabled = true;
        }
    }
}
