using System.Collections;
using UnityEngine;

public class EnemiesManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public Vector2 spawnArea;
    public float spawnTimer = 2f;
    public float timeBetweenWaves = 20f;
    //public int enemiesPerWave = 5;
    public GameObject objective;

    public int waveIndex ;
    private float countdown = 5f;
    private float timer;

    private void Start()
    {

        StartNextWave();
    }

    private void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            waveIndex++;
            countdown = timeBetweenWaves;
        }
    }

    private IEnumerator SpawnWave()
    {
        
        for (int i = 0; i < Random.Range(10,25); i++)
        {
            SpawnEnemy();
            if(waveIndex < 5)
            {
                yield return new WaitForSeconds(spawnTimer);

            }
            if (waveIndex > 5 && waveIndex < 10)
            {
                yield return new WaitForSeconds(spawnTimer + Random.Range(1, 5));
            }


        }
    }

    private void SpawnEnemy()
    {
        Vector3 position = new Vector3(Random.Range(-spawnArea.x, spawnArea.x), Random.Range(-spawnArea.y, spawnArea.y), 0f);
        int randomIndex = Random.Range(0, enemyPrefabs.Length);
        GameObject newEnemy = Instantiate(enemyPrefabs[randomIndex], position, Quaternion.identity);
        newEnemy.GetComponent<Enemy>(); 
        
    }

    private void StartNextWave()
    {
        waveIndex = 0;
        countdown = timeBetweenWaves;
        Debug.Log("Starting Wave " + (waveIndex + 1));
    }
}
