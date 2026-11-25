using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    public InputAction spawnAction;

    void Start()
    {
        spawnAction.Enable();
    }
    
    
}