using System.Collections.Generic;
using TMPro;
using UnityEngine;


/// <summary>
/// Enter point in game
/// </summary>
public class Bootstrap : MonoBehaviour
{
    [SerializeField]
    private UI _uiInstance;
    [SerializeField]
    private List<TextMeshProUGUI> _resources;
    [SerializeField]
    private TextMeshProUGUI _sumScore;
    [SerializeField] 
    private List<ScoreDisplay> _score;
    [SerializeField]
    private ButtonController _buttonController;
    private ParameterController _parameterController;

    void Awake()
    {
        _parameterController = new ParameterController(_resources, _sumScore, _score, _buttonController);
        _uiInstance.Init(_parameterController);
    }
}
