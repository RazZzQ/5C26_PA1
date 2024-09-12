using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public ObjectPooling objectPool;
    public float spawnRate = 2f;
    public float minY = -4f, maxY = 4f; 
    private float timer;

    void Start()
    {
        objectPool.Initialize();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnRate)
        {
            SpawnInteractable();
            timer = 0;
        }
    }

    void SpawnInteractable()
    {
        int interactableType = Random.Range(0, objectPool.objectPrefabs.Length);
        GameObject interactable = objectPool.GetPooledObject(interactableType);

        if (interactable != null)
        {
            float spawnY = Random.Range(minY, maxY);
            interactable.transform.position = new Vector2(10, spawnY);
            interactable.SetActive(true);
        }
    }
}
