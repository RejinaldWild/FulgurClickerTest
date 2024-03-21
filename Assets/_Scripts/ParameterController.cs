using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;

public class ParameterController
{
    private List<TextMeshProUGUI> _resources;
    private TextMeshProUGUI _sumScore;
    private List<ScoreDisplay> _scores;
    private ButtonController _buttonController;

    public ParameterController(List<TextMeshProUGUI> resources, TextMeshProUGUI sumScore, 
                                List<ScoreDisplay> score, ButtonController clickButton)
    {
        _resources = resources;
        _sumScore = sumScore;
        _scores = score;
        _buttonController = clickButton;
    }

    public void Init()
    {
        _buttonController.ButtonClicked += ShowActualResource;
        _buttonController.ButtonClicked += ShowAllResources;
    }

    public void Terminate()
    {
        _buttonController.ButtonClicked -= ShowActualResource;
        _buttonController.ButtonClicked -= ShowAllResources;
    }

    private void ShowActualResource(Button button)
    {
        int startIndex = 0;
        string[] tempButtonString = button.name.Split();
        foreach (TextMeshProUGUI res in _resources)
        {
            string[] tempTMPStr = res.name.Split();
            if (tempButtonString[startIndex] == tempTMPStr[startIndex])
            {
                int counter = Int32.Parse(res.text)+1;
                res.text = counter.ToString();
            }            
        }
    }

    private void ShowAllResources(Button button)
    {
        int counter = Int32.Parse(_sumScore.text) + 1;
        _sumScore.text = counter.ToString();
    }
}
