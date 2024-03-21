using UnityEngine;

public class ScoreDisplay: MonoBehaviour
{
    [SerializeField] private TMPResource _tmp;
    private int _id;
    private string _name;
    private int _score;

    void Start()
    {
        _id = _tmp.Id;
        _name = _tmp.Name;
        _score = _tmp.Score;
    }

}
