using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentController : MonoBehaviour
{

    public static Material matOne;
    public static Material matTwo;
    public static Material matThree;
    public int number;
    
    public Material[] skyboxes = new Material[] {matOne, matTwo, matThree};



    // Start is called before the first frame update
    void Start()
    {
        SetEnvironment(number);
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void SetEnvironment(int number)
    {
        RenderSettings.skybox = skyboxes[number];
    }
}
