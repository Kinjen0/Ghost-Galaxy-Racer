using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public int activeEnemies;
    public int maxEnemies = 20;
    public Transform location;

    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {

        //location = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(activeEnemies < maxEnemies)
        {
            spawnEnemy();
        }
    }

    public void spawnEnemy()
    {
        GameObject newEnemy = Instantiate(enemy, location.transform);
        activeEnemies++;
    }
}
