using UnityEngine;
using UnityEngine.UI;
public class CoinText : MonoBehaviour
{
    Text _text;
    void Awake()
    {
        _text = GetComponent<Text>();
        GameManager.Instance.OnCollectCoin += ShowNumberOfCoins;
    }
    private void OnDestroy()
    {
        GameManager.Instance.OnCollectCoin -= ShowNumberOfCoins;
    }
    void ShowNumberOfCoins(int count)
    {
        _text.text = "x" + count;
    }
}