using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] enemies;

    // Update is called once per frame
    void Start()
    {
        int index = Random.Range(0, enemies.Length);
        Instantiate(enemies[index], transform.position, quaternion.identity);
    }
}
