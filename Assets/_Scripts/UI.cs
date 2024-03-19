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
    [SerializeField]
    private List<TextMeshProUGUI> _resources;
    [SerializeField]
    private TextMeshProUGUI _sumScore;
    
    private int _goldNumScore;
    private int _silverNumScore;

    private ParameterController _parameterController;

    public static event Action onChangeScore;

    private void Start()
    {
        //Initializing start score
        _goldNumScore = 0;
        //_goldScores.text = "Gold:\n " + _goldNumScore;
        _silverNumScore = 0;
       // _silverScores.text = "Silver:\n " + _silverNumScore;
        _sumScore.text = "Score:\n" + (_goldNumScore + _silverNumScore).ToString();
    }

    public void Init(ParameterController controller)
    {
        _parameterController = controller;
        _parameterController.Init();
    }

    // Lower is trash


    private void OnEnable()
    {
        // subscribing on events
        onChangeScore += ChangeSumScore;
    }

    private void OnDisable()
    {
        // unsubscribing on events
        onChangeScore -= ChangeSumScore;
    }

    /// <summary>
    /// Shows actual score on UI
    /// </summary>
    void ChangeSumScore()
    {
        _sumScore.text = "Score:\n" + (_goldNumScore + _silverNumScore).ToString();
    }
}
