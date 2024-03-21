using UnityEngine;

/// <summary>
/// UI responsible class. It is responsible for all UI element including Canvas
/// </summary>
public class UI : MonoBehaviour
{
    private ParameterController _parameterController;    

    public void Init(ParameterController controller)
    {
        _parameterController = controller;
        _parameterController.Init();
    }

    private void Update()
    {
        
    }

    private void OnDisable()
    {
        _parameterController.Terminate();
    }
}
