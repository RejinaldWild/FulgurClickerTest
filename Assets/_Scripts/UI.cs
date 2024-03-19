using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.ComponentModel;
using System;
using Unity.VisualScripting;

/// <summary>
/// UI responsible class. It is responsible for all UI element including Canvas
/// </summary>
public class UI : MonoBehaviour
{
    private ParameterController _parameterController;
    public static event Action onChangeScore;

    public void Init(ParameterController controller)
    {
        _parameterController = controller;
        _parameterController.Init();
    }

    private void Update()
    {
        
    }

    private void OnDisable()
    {
        _parameterController.Terminate();
    }
}
