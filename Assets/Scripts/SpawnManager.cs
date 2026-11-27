using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public InputAction spawnAction;

    private float _spawnRangeX = 15;
    private float _spawnPosZ = 20;

    private float _startDelay = 2f;
    private float _spawnInterval = 1.5f;

    void Start()
    {
        spawnAction.Enable();
        
        InvokeRepeating("SpawnRandomAnimal", _startDelay, _spawnInterval);
    }

    void Update()
    {
        
    }

    private void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        
        Vector3 spawnPos = new Vector3(Random.Range(-_spawnRangeX, _spawnRangeX), 0, _spawnPosZ);
        
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}