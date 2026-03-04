using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPooling : MonoSingleton<MyPooling>
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private int _poolSize;

    Queue<GameObject> pool = new Queue<GameObject>();

    private void Start()
    {
        CreatePool(_poolSize);
    }

    public void CreatePool(int num)
    {
        for (int i = 0; i < num; i++)
        {
            GameObject obj = Instantiate(_prefab, transform);
            obj.SetActive(false);
            pool.Enqueue(obj);
        }
    }

    public GameObject GetPoolObj()
    {
        if (pool.Count == 0)
        {
            CreatePool(1);
        }
        return pool.Dequeue();
    }

    public void PutPoolObj(GameObject obj)
    {
        pool.Enqueue(obj);
        obj.SetActive(false);
    }





}
