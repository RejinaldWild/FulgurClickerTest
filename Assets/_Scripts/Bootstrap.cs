using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


/// <summary>
/// Enter point in game
/// </summary>
public class Bootstrap : MonoBehaviour
{
    [SerializeField]
    private List<TextMeshProUGUI> _resources;
    [SerializeField]
    private TextMeshProUGUI _sumScore;
    private UI _uiInstance;
    private ParameterController _parameterController;

    void Awake()
    {
        _uiInstance = GetComponent<UI>();
        _parameterController = new ParameterController(_resources, _sumScore);
        _uiInstance.Init(_parameterController);
    }
}
