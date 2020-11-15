using System;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    private static GameManager _instance = null;
    public static GameManager Instance { get { return _instance; } }
    private int _numberOfCoins;
    public event Action<int> OnCollectCoin; // событие при сборе монет 
    void Awake()
    {
        if (_instance == null) // проверяем существование экземпляра
            _instance = this; // задаем ссылку на экземпляр объекта
        else if (_instance == this) // экземпляр объекта уже существует на сцене
            Destroy(gameObject); // удаляем объект
    }
    void Start()
    {
        _numberOfCoins = 0;
        OnCollectCoin?.Invoke(_numberOfCoins);
    }
    public void AddCoin()
    {
        _numberOfCoins++;
        OnCollectCoin?.Invoke(_numberOfCoins);
    }
}