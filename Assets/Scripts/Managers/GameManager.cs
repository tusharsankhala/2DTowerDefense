using System.Collections;
using System.Collections.Generic;
using TowerDefense.Singleton;
using UnityEngine;

namespace TowerDefense.Managers
{
    public class GameManager : Singleton<GameManager>
    {
        private const float _mWaitingTime = 1;
        public GameObject spawnPoint;
        public GameObject[] enemies;

        public int maxEnemiesOnScreen;
        public int enemiesOnScreen;
        public int totalEnemies;
        public int enemiesPerSpawn;

        private float mSpawnDelay = 1.0f;
        private WaitForSeconds _mSpawnRoutineDelay;
        
        // Start is called before the first frame update
        void Start()
        {
            _mSpawnRoutineDelay = new WaitForSeconds(mSpawnDelay);
            StartCoroutine(Spawn());
        }

        // Update is called once per frame
        void Update()
        {

        }

        IEnumerator Spawn()
        {
            // Check if we have less enemies than our totalEnemies
            if (enemiesOnScreen < totalEnemies)
            {
                for (int i = 0; i < enemiesPerSpawn; ++i)
                {
                    GameObject newEnemy = Instantiate(enemies[0]) as GameObject;
                    newEnemy.transform.position = spawnPoint.transform.position;
                    ++enemiesOnScreen;
                }
            }

            // Time delay between each Spawn.
            yield return _mSpawnRoutineDelay;
            StartCoroutine(Spawn());
        }
    }
}