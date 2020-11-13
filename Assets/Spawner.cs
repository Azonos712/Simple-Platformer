using UnityEngine;
public class Spawner : MonoBehaviour
{
    public GameObject SpawnPrefab;
    public Value SpawnPeriod;
    public float OffsetValue;
    float _period;
    private float _time;
    private void Start()
    {
        _period = Random.Range(SpawnPeriod.Min, SpawnPeriod.Max);
    }
    void Update()
    {
        if (_time >= _period)
        {
            _time = 0;
            Vector3 randomOffset = new Vector3(Random.Range(-OffsetValue, OffsetValue), 0f, Random.Range(-OffsetValue, OffsetValue));
            Instantiate(SpawnPrefab, transform.position + randomOffset, transform.rotation);
            _period = Random.Range(SpawnPeriod.Min, SpawnPeriod.Max);
        }
        _time += Time.deltaTime;
    }
}