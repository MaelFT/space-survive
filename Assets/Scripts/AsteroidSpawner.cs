using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float spawnRate = 2f;

    void Start()
    {
        InvokeRepeating("SpawnAsteroid", 0f, spawnRate);
    }

    void SpawnAsteroid()
    {
        if (asteroidPrefab != null)
        {
            float randomX = Random.Range(-8f, 8f);
            Vector2 spawnPosition = new Vector2(randomX, 6f);
            Instantiate(asteroidPrefab, spawnPosition, Quaternion.identity);
            Debug.Log("Asteroid spawned at " + spawnPosition);
        }
    }
}
