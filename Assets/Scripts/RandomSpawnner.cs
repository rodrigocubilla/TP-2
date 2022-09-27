using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnner : MonoBehaviour
{   
    [SerializeField] private GameObject mugrePrefab;
    [SerializeField] private float tiempoSpawn;
    [SerializeField] private float tiempoEspera;

    void Update()
    {
        tiempoSpawn -= Time.deltaTime;
        if(tiempoSpawn <= 0)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-8,25),16,Random.Range(-4,8));
            Instantiate(mugrePrefab, randomSpawnPosition, Quaternion.identity);
            tiempoSpawn = tiempoEspera;
        }
    }
    
}
