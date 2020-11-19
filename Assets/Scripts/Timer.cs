using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    Text _text;
    float _startTime;
    void Start()
    {
        _text = GetComponent<Text>();
        _text.text = _startTime.ToString("F2");
    }
    void FixedUpdate()
    {
        if (!GameManager.Instance.GameOver)
        {
            _startTime += Time.fixedDeltaTime;
            _text.text = _startTime.ToString("F2");
        }
    }
}
