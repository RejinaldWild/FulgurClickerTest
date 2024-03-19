using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ParameterController
{
    private int _CountScore = 0;
    private int _silverCountScore = 0;
    private List<TextMeshProUGUI> _resources;
    private TextMeshProUGUI _sumScore;

    public ParameterController(List<TextMeshProUGUI> resources, TextMeshProUGUI sumScore)
    {
        _resources = resources;
        _sumScore = sumScore;
    }

    public void Init()
    {
        ClickButton.onClickButton += ShowActualResource;
        ClickButton.onClickButton += ShowAllResources;
    }

    public void Terminate()
    {
        ClickButton.onClickButton -= ShowActualResource;
        ClickButton.onClickButton -= ShowAllResources;
    }

    public void ShowActualResource()
    {
        foreach (TextMeshProUGUI res in _resources)
        {
            if (res.tag == "Resource")
            {
                //EventManager.OnParameterScored();
                int count = _CountScore++;
                string tempText = res.text + count.ToString();
                res.text = tempText;
                Debug.Log("Нажата кнопка была " + _CountScore + " и " + res.text);
            }
        }
    }

    public void ShowAllResources()
    {
        int counter = 0;
        foreach (TextMeshProUGUI res in _resources)
        {
            //counter += Int32.Parse(res.text);
        }

        _sumScore.text = counter.ToString();
        Debug.Log("Всё тут!");
    }
}
