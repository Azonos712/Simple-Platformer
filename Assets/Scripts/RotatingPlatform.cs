using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class RotatingPlatform : MonoBehaviour
{
    Animation _animation;
    void Start()
    {
        _animation = GetComponent<Animation>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<RigidbodyFirstPersonController>())
            _animation.Play();
    }
}
