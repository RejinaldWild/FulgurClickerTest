using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Enter point in game
/// </summary>
public class Bootstrap : MonoBehaviour
{
    private UI _uiInstance;
    
    void Awake()
    {
        _uiInstance = GetComponent<UI>();
    }
}
