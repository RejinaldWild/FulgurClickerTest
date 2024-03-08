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
    private TextMeshProUGUI _goldScore;
    [SerializeField]
    private TextMeshProUGUI _silverScore;
    [SerializeField]
    private TextMeshProUGUI _sumScore;
    
    private int _goldNumScore;
    private int _silverNumScore;

    public static event Action onChangeScore;

    private void Start()
    {
        //Initializing start score
        _goldNumScore = 0;
        _goldScore.text = "Gold:\n " + _goldNumScore;
        _silverNumScore = 0;
        _silverScore.text = "Silver:\n " + _silverNumScore;
        _sumScore.text = "Score:\n" + (_goldNumScore + _silverNumScore).ToString();
    }

    private void OnEnable()
    {
        // subscribing on events
        ClickGoldButton.onClickButton += ShowActualGold;
        ClickSilverButton.onClickButton += ShowActualSilver;
        onChangeScore += ChangeSumScore;
    }

    private void OnDisable()
    {
        // unsubscribing on events
        ClickGoldButton.onClickButton -= ShowActualGold;
        ClickSilverButton.onClickButton -= ShowActualSilver;
        onChangeScore -= ChangeSumScore;
    }

    /// <summary>
    /// Shows actual gold on UI
    /// </summary>
    void ShowActualGold()
    {
        string text = _goldScore.text;
        _goldNumScore++;
        text = "Gold:\n " + _goldNumScore;
        _goldScore.text = text;
        onChangeScore?.Invoke();
    }

    /// <summary>
    /// Shows actual silver on UI
    /// </summary>
    void ShowActualSilver()
    {
        string text = _silverScore.text;
        _silverNumScore++;
        text = "Silver:\n " + _silverNumScore;
        _silverScore.text = text;
        onChangeScore?.Invoke();
    }

    /// <summary>
    /// Shows actual score on UI
    /// </summary>
    void ChangeSumScore()
    {
        _sumScore.text = "Score:\n" + (_goldNumScore + _silverNumScore).ToString();
    }
}
