using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    [SerializeField] private Bomb _bombPrefab;
    [Header("Player Position detection")]
    [SerializeField] private Transform _playerPosition;
    [SerializeField] private float _playerRadius;
    [Header("Range spawn X position")]
    [SerializeField] private float _maxXSapwnPosition;
    [SerializeField] private float _minXSapwnPosition;
    [Header("Range spawn Y position")]
    [SerializeField] private float _maxYSapwnPosition;
    [SerializeField] private float _minYSapwnPosition;

    private void OnEnable()
    {
        Treat.TreatCollectedEvent += SpawnBomb;

    }

    private void OnDisable()
    {
        Treat.TreatCollectedEvent -= SpawnBomb;
    }

    public void SpawnBomb()
    {
        Vector2 randomSpawnPosition = new Vector2(Random.Range(_minXSapwnPosition, _maxXSapwnPosition), Random.Range(_maxYSapwnPosition, _minYSapwnPosition));

        if (Vector2.Distance(_playerPosition.transform.position, randomSpawnPosition) < _playerRadius)
        {
            SpawnBomb();
            Debug.Log("Bomb wanted spawn in player range but ");
        }
        else
        {
            Instantiate(_bombPrefab, randomSpawnPosition, Quaternion.identity);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(_playerPosition.transform.position, _playerRadius);
    }
}