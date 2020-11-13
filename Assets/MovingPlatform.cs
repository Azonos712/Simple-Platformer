using System;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using Random = UnityEngine.Random;

[Serializable]
public struct Value
{
    public float Min;
    public float Max;
}
public class MovingPlatform : MonoBehaviour
{
    private float _speed;
    public Value Speed;
    private float _rightLimit, _leftLimit;
    public Value RightLimit, LeftLimit;
    private Vector3 _direction;
    private void Start()
    {
        _speed = Random.Range(Speed.Min, Speed.Max); // задаём случайную скорость
        _direction = Random.value < 0.5f ? Vector3.left : Vector3.right; // выбираем случайное направление движения
        _rightLimit = transform.position.x + Random.Range(RightLimit.Min, RightLimit.Max);
        _leftLimit = transform.position.x + Random.Range(LeftLimit.Min, LeftLimit.Max);
    }
    void Update()
    {
        if (transform.position.x > _rightLimit)
            _direction = Vector3.left;

        if (transform.position.x < _leftLimit)
            _direction = Vector3.right;

        transform.Translate(_direction * _speed * Time.deltaTime); // двигаем платформу
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<RigidbodyFirstPersonController>())
            other.transform.parent = transform;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<RigidbodyFirstPersonController>())
            other.transform.parent = null;
    }
}