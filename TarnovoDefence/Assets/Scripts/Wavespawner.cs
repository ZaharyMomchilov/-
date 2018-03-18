using System.Collections;
using UnityEngine;

public class Wavespawner : MonoBehaviour {
    public Transform EnemyPrefab;
    public Transform SpawnPoint;
    public float TimeBetweenWaves = 5f;
    private float Countdown = 2f;
    private int WaveIndex = 0;
    void Update()
    {
        if (Countdown <= 0f)
        {
            StartCoroutine(Spawnwave());
            Countdown = TimeBetweenWaves;
        }
        Countdown -= Time.deltaTime;
    }
    IEnumerator Spawnwave()
    {
        WaveIndex++;
        for (int i = 0; i < WaveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
    }
    void SpawnEnemy()
    {
        Instantiate(EnemyPrefab, SpawnPoint.position, SpawnPoint.rotation);
    }
}

