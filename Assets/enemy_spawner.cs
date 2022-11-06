using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_spawner : MonoBehaviour
{
    public GameObject pink_enemy;
    public float TimeBetweenWaves;
    public int NumberOfEnemiesPerWave;
    public int TotalEnemyCap;
    public float spawnDistance;
    List<GameObject> enemies = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RunSpawner());
    }
    IEnumerator RunSpawner()
    {
        yield return new WaitForSeconds(1.0f);
        while (true)
        {
            for (int i = 0; i < NumberOfEnemiesPerWave; i++)
            {
                if (enemies.Count > TotalEnemyCap) break;
                var position = this.transform.position;
                var theta = Random.Range(0, Mathf.PI * 2);
                var dx = spawnDistance * Mathf.Sin(theta);
                var dy = spawnDistance * Mathf.Cos(theta);
                var enemy = Instantiate(pink_enemy, position + new Vector3(dx, dy, 0f), Quaternion.identity);
                var details = enemy.GetComponent<pink_enemy>();
                details.speed = Random.Range(0.02f, 0.05f);
                details.Target = this.gameObject;
            }
            yield return new WaitForSeconds(TimeBetweenWaves);
        }
    }
}
