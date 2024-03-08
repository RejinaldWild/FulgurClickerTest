using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ClickGoldButton : MonoBehaviour, IClickButton
{
    public static event Action onClickButton;

    [SerializeField]
    private Button _goldButton;
    
    /// <summary>
    /// Clicking on Button to trigger adding score of gold
    /// </summary>
    public void OnClick()
    {
        onClickButton?.Invoke();
    }
}
