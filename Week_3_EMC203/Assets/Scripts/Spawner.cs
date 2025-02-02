using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Assign the Enemy prefab in the Inspector
    public Transform spawnPoint;   // Where to spawn enemies
    public float spawnRate = 2f;   // Time between spawns

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 0f, spawnRate); // Repeatedly spawn enemies
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
    }
}
