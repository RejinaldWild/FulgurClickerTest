using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ClickSilverButton : MonoBehaviour, IClickButton
{
    public static event Action onClickButton;

    [SerializeField]
    private Button _silverButton;    

    /// <summary>
    /// Clicking on Button to trigger adding score of silver
    /// </summary>
    public void OnClick()
    {
        onClickButton?.Invoke();
    }

}
