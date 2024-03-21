using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    [SerializeField]
    private List<Button> _Button;

    public event Action<Button> ButtonClicked;

    public void AddScore(string name)
    {
        foreach( Button button in _Button)
        {
            if(button.name == name)
            {
                ButtonClicked?.Invoke(button);
            }
        }
    }
}
