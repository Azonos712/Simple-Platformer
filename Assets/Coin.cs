using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<RigidbodyFirstPersonController>())
        {
            GameManager.Instance.AddCoin();
            Destroy(gameObject);
        }
    }
}