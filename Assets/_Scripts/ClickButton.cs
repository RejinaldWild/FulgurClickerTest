using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class ClickButton : MonoBehaviour, IClickButton
{
    public static event Action onClickButton;

    [SerializeField]
    private List<Button> _Button;
    
    /// <summary>
    /// Clicking on Button to trigger adding score
    /// </summary>
    public void OnClick()
    {
        onClickButton?.Invoke();
    }
}
