using UnityEngine;
using System.Collections;

public class SpawnOverTimeScript : MonoBehaviour
{

    // Object to spawn.
    [SerializeField]
    private GameObject spawnObject;

    // Delay between spawns.
    [SerializeField]
    private float spawnDelay = 2f;

    private Renderer ourRenderer;

    // Start is called before the first frame update.
    void Start()
    {

        ourRenderer = GetComponent<Renderer>();

        // Stop our Spawner from being visible.
        ourRenderer.enabled = false;

        // Delay GameObject spawning and repeat after GameObject has spawned.
        InvokeRepeating("Spawn", spawnDelay, spawnDelay);
    }

    void Spawn()
    {
        float x1 = transform.position.x - ourRenderer.bounds.size.x / 2;
        float x2 = transform.position.x + ourRenderer.bounds.size.x / 2;

        // Randomize spawn location.
        Vector2 spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);

        // Spawn object.
        Instantiate(spawnObject, spawnPoint, Quaternion.identity);
    }
}