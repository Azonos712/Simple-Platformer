using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance = null;
    public static GameManager Instance { get { return _instance; } }
    public bool GameOver { get; private set; }
    GameObject _finishPanel;
    void Awake()
    {
        if (_instance == null)// проверяем существование экземпляра
        {
            GetComponent<AudioSource>().Play();
            _instance = this; // задаем ссылку на экземпляр объекта
        }
        else if (_instance == this) // экземпляр объекта уже существует на сцене
            Destroy(gameObject); // удаляем объект

        DontDestroyOnLoad(_instance.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<RigidbodyFirstPersonController>())
        {
            GameOver = true;
            Time.timeScale = 0.2f;
            Time.fixedDeltaTime = 0.02f * 0.2f;
            GameObject.Find("FinishGroup").transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}