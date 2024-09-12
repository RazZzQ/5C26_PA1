using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ObjectPoolSO", menuName = "Pooling/Object Pool", order = 2)]

public class ObjectPooling : ScriptableObject
{
    public GameObject[] objectPrefabs;
    public int poolSize = 10;
    private List<GameObject> poolObjects;

    public void Initialize()
    {
        poolObjects = new List<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            for (int j = 0; j < objectPrefabs.Length; j++)
            {
                GameObject obj = Instantiate(objectPrefabs[j]);
                obj.SetActive(false);
                poolObjects.Add(obj);
            }
        }
    }

    public GameObject GetPooledObject(int index)
    {
        for (int i = 0; i < poolObjects.Count; i++)
        {
            if (!poolObjects[i].activeInHierarchy && poolObjects[i].tag == objectPrefabs[index].tag)
            {
                return poolObjects[i];
            }
        }
        return null;
    }

    public void ResetPool()
    {
        foreach (GameObject obj in poolObjects)
        {
            obj.SetActive(false);
        }
    }
}
