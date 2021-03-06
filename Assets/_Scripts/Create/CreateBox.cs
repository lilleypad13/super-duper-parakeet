﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBox : MonoBehaviour{

    #region Variables

    [Header("Object to Use as Box")]
    public GameObject box;

    [Header("Parameter Ranges")]
    [Header("Box Size")]
    public float minScale = 0.5f;
    public float maxScale = 4.0f;
    public float MAX_POSSIBLE_BOX_SIZE = 3.0f;

    [Header("Area Range")]
    public float minX = 0.0f;
    public float maxX = 10.0f;
    public float minY = 0.0f;
    public float maxY = 2.0f;
    public float minZ = 0.0f;
    public float maxZ = 10.0f;

    //Vector3 boxPosition = new Vector3();
    Vector3[] boxPosition;

    private int numberOfTests;
    private float separationDistance;
    private static CreateBox instance;
    public GenerationSystem generationSystem;
    #endregion


    #region Unity Methods

    //private void Awake()
    //{
    //    if (instance != null)
    //    {
    //        Debug.Log("More than one CreateBox in scene");
    //        return;
    //    }
    //    instance = this;

    //    //generationSystem = GenerationSystem.GetInstance();
    //    GetDataForMultipleTests();

    //    boxPosition = new Vector3[numberOfTests];
    //    PositionBox();
    //}

    //private void Start()
    //{
    //    GenerateBoxes();
    //}


    ///*
    // * Gets necessary information from GenerationSystem in cases where multiple test scenarios are being created
    // */
    //private void GetDataForMultipleTests()
    //{
    //    numberOfTests = generationSystem.GetNumberOfTests();
    //    separationDistance = generationSystem.GetTestSeparationDistance();
    //}


    ///*
    // * Create a number of boxes equal to the desired number of tests
    // * These boxes general areas will also be separated depending on the number of tests
    // */
    //private void GenerateBoxes()
    //{
    //    for (int i = 0; i < numberOfTests; i++)
    //    {
    //        Vector3 adjustedBoxPosition = boxPosition[i] + (float)i * separationDistance * new Vector3(0.0f, 0.0f, 1.0f);
    //        GameObject createdBox = (GameObject)Instantiate(box, adjustedBoxPosition, Quaternion.identity);

    //        // Adjust scale values if they are deemed impossible to use by the system
    //        float adjustedMinScale = CheckMin(minScale, i);
    //        float adjustedMaxScale = CheckMax(maxScale); // Is constant so does not need index value
    //        ScaleBox(createdBox, adjustedMinScale, adjustedMaxScale);
    //    }
    //}


    ///*
    // * Positions an object within specified bounds in 3D space
    // * Generates position data for all boxes in cases of multiple tests.
    // */
    //private void PositionBox()
    //{
    //    for (int i = 0; i < numberOfTests; i++)
    //    {
    //        boxPosition[i] = new Vector3(
    //        Random.Range(minX, maxX),
    //        Random.Range(minY, maxY),
    //        Random.Range(minZ, maxZ));

    //        // Allows for positioning of entire instantiation system by moving parent game object
    //        boxPosition[i] += transform.position;
    //    }
    //}


    ///*
    // * Uniformly scales an object on all 3 axes
    // */
    //private void ScaleBox(GameObject newBox, float min, float max)
    //{
    //    // Setting a single float randomly and then applying that to all the scaling dimensions
    //    // of the instantiated object ensures it is uniformly scaled
    //    float scalingFactor = Random.Range(min, max);
    //    newBox.transform.localScale = new Vector3(scalingFactor, scalingFactor, scalingFactor);

    //    Debug.Log("SYSTEM FACTOR: Box scale is: " + newBox.transform.localScale);
    //}

    //private float CheckMin(float min, int index)
    //{
    //    float check = generationSystem.GetLedgeInformation(index) - min;

    //    // Only update min value if it is out of the necessary bounds
    //    if(check > generationSystem.GetDistFromLedgeToBox())
    //    {
    //        min = generationSystem.GetLedgeInformation(index) - generationSystem.GetDistFromLedgeToBox();
    //        Debug.Log("Box scale failed CheckMin");
    //    }

    //    return min;
    //}


    //private float CheckMax(float max)
    //{
    //    // Only update max value if it is out of the necessary bounds
    //    if(max > MAX_POSSIBLE_BOX_SIZE)
    //    {
    //        max = MAX_POSSIBLE_BOX_SIZE;
    //        Debug.Log("Box scale failed CheckMax");
    //    }

    //    return max;
    //}

    //public static CreateBox GetInstance()
    //{
    //    return instance;
    //}

    #endregion
}
