using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    const double TIMEUNIT;

    InputProcessor inputProcessor = new InputProcessor();
    TIMEUNIT = inputProcessor.getTime();
    inputProcessor.getTime();
    private double time;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
