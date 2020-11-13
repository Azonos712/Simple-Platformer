using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class FallsPlatform : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<RigidbodyFirstPersonController>())
            if (!gameObject.GetComponent<Rigidbody>())
                gameObject.AddComponent<Rigidbody>();
    }
}