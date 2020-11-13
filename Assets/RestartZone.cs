using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class RestartZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<RigidbodyFirstPersonController>()) //если объект является игроком 
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // перезапускаем сцену
        else
            Destroy(other.gameObject); // иначе уничтожаем другой объект
    }
}