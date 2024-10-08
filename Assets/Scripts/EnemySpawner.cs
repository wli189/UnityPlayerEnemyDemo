using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public int startTime = 2;
    public int delay = 1;
    public List<GameObject> enemies;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("createEnemy", startTime, delay);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void createEnemy()
    {
        int index = Random.Range(0, enemies.Count);
        float xValue = Random.Range(-11f, 11f);
        Vector3 position = new Vector3(xValue, 0.5f, -8.5f);
        Instantiate(enemies[index], position, enemies[index].transform.rotation);
    }
}
