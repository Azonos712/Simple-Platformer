using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<RigidbodyFirstPersonController>())
        {
            GetComponent<AudioSource>().Play();
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<BoxCollider>().enabled = false;
            CoinManager.Instance.AddCoin();
            Destroy(gameObject, 0.5f);
        }
    }
}