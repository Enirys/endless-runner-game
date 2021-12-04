using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] obstaclePatterns;
    [SerializeField] private float startTimeBtwSpawn;
    [SerializeField] private float decreaseTime;
    
    private float m_TimeBtwSpawn;
    
    // Start is called before the first frame update
    void Start()
    {
        m_TimeBtwSpawn = startTimeBtwSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_TimeBtwSpawn <= 0)
        {
            int index = Random.Range(0, obstaclePatterns.Length);
            Instantiate(obstaclePatterns[index], transform.position, Quaternion.identity);
            startTimeBtwSpawn -= decreaseTime;
            m_TimeBtwSpawn = startTimeBtwSpawn;
        }
        else
        {
            m_TimeBtwSpawn -= Time.deltaTime;
        }
    }
}
