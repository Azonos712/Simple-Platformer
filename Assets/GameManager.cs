using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance = null;
    public static GameManager Instance { get { return _instance; } }
    public bool GameOver { get; private set; }
    public GameObject FinishPanel;
    void Awake()
    {
        if (_instance == null) // проверяем существование экземпляра
            _instance = this; // задаем ссылку на экземпляр объекта
        else if (_instance == this) // экземпляр объекта уже существует на сцене
            Destroy(gameObject); // удаляем объект
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<RigidbodyFirstPersonController>())
        {
            GameOver = true;
            Time.timeScale = 0.2f;
            Time.fixedDeltaTime = 0.02f * 0.2f;
            FinishPanel.SetActive(true);
        }
    }
}