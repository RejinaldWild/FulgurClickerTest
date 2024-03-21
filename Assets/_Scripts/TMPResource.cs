using TMPro;
using UnityEngine;

[CreateAssetMenu(fileName ="Scriptable Objects", menuName = "Create TMP")]
public class TMPResource : ScriptableObject
{
    [SerializeField] private TextMeshProUGUI _tmp;
    [SerializeField] private int _id;
    [SerializeField] private string _name;
    [SerializeField] private int _score;

    public TextMeshProUGUI Tmp => this._tmp;
    public int Id => this._id;
    public string Name => this._name;
    public int Score => this._score;
}
