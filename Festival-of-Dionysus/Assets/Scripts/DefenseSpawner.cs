using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenseSpawner : MonoBehaviour
{
    [SerializeField]
    private List<DefenseEnemy> enemies;
    [SerializeField]
    private GameObject placeHolderEnemy, enemyPrefab1, enemyPrefab2, enemyPrefab3, spawnPoint;
    [SerializeField]
    private float spawnTimer, burstSpawnTimer, speedMin, speedMax, delayMin, delayMax;
    [SerializeField]
    private int enemyNumb, enemiesToBurst;
    [SerializeField]
    private RandomQuestion questions;
    [SerializeField]
    bool stop, burstSpawn;

    private void OnEnable()
    {
        //clears list
        if (enemies.Count > 0)
        {
            foreach (DefenseEnemy enemy in enemies)
            {
                if(enemy != null)
                    enemy.Die();
            }
            enemies.Clear();
        }
        //sets timer
        spawnTimer = Random.Range(delayMin, delayMax);
        burstSpawnTimer = Random.Range(20f, 30f);
        //makes new enemy
        GameObject newEnemy = Instantiate(enemyPrefab1,spawnPoint.transform);
        //assigns the questions to the enemies so they can generate a question
        newEnemy.GetComponent<DefenseEnemy>().setQuestions(questions);
        //assigns speed
        newEnemy.GetComponent<DefenseEnemy>().setSpeed(-Random.Range(speedMin, speedMax));
        //adds enemy to list
        enemies.Add(newEnemy.GetComponent<DefenseEnemy>());
        enemyNumb = 1;
        stop = false;
    }

    void Update()
    {
        //runs down regular timer
        spawnTimer -= Time.deltaTime;
        //runs burst timer if burst is on
        if (burstSpawn)
        {
            burstSpawnTimer -= Time.deltaTime;
        }
        
        if(spawnTimer <= 0 && !stop)
        {
            //reset timer
            spawnTimer = Random.Range(delayMin, delayMax);
            //makes new enemy
            GameObject newEnemy = MakeEnemy();
            //assigns the questions to the enemies so they can generate a question
            newEnemy.GetComponent<DefenseEnemy>().setQuestions(questions);
            //assigns speed
            newEnemy.GetComponent<DefenseEnemy>().setSpeed(-Random.Range(speedMin, speedMax));
            //adds enemy to array
            enemies.Add(newEnemy.GetComponent<DefenseEnemy>());
        }

        if (burstSpawn && burstSpawnTimer <= 0)
        {
            if(enemiesToBurst > 0)
            {
                //reset timer
                spawnTimer = 10;
                burstSpawnTimer = 3;
                //makes new enemy
                GameObject newEnemy = MakeEnemy();
                //assigns the questions to the enemies so they can generate a question
                newEnemy.GetComponent<DefenseEnemy>().setQuestions(questions);
                //assigns speed
                newEnemy.GetComponent<DefenseEnemy>().setSpeed(-Random.Range(speedMin, speedMax));
                //adds enemy to array
                enemies.Add(newEnemy.GetComponent<DefenseEnemy>());
                enemiesToBurst--;
            }
        }
    }

    private GameObject MakeEnemy()
    {
        GameObject newEnemy = placeHolderEnemy;
        if (enemyNumb == 1)
        {
            newEnemy = Instantiate(enemyPrefab1, spawnPoint.transform);
            enemyNumb++;
        }
        else if (enemyNumb == 2)
        {
            newEnemy = Instantiate(enemyPrefab2, spawnPoint.transform);
            enemyNumb++;
        }
        else if (enemyNumb == 3)
        {
            newEnemy = Instantiate(enemyPrefab3, spawnPoint.transform);
            enemyNumb = 1;
        }
        return newEnemy;
    }

    public bool checkAnswers(int ans)
    {
        for(int i = 0; i < enemies.Count; i++)
        {
            //Debug.Log("Check");
            if (enemies != null && enemies[i].Answer(ans))
            {
                this.enemies.Remove(enemies[i]);
                return true;
            }
        }
        return false;
    }

    public void StopSpawns()
    {
        stop = true;
        foreach (DefenseEnemy enemy in enemies)
        {
            //this.enemies.Remove(enemy);
            enemy.Die();
        }
        Debug.Log("Stop Spawns");
    }

    public void StartSpawns()
    {
        stop = false;
        Debug.Log("Start spawns");
    }
}
