using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPooling : MonoSingleton<MyPooling>
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private int _poolSize;

    Queue<GameObject> pool = new Queue<GameObject>();

    private void Awake()
    {
        CreatePool();
    }

    public void CreatePool()
    {
        for (int i = 0; i < _poolSize; i++)
        {
            GameObject obj = Instantiate(_prefab, transform);
            obj.SetActive(false);

            pool.Enqueue(obj); 
        }
    }

    public GameObject GetPoolObj()
    {
        return pool.Dequeue();
    }

    public void PutPoolObj(GameObject obj)
    {
        pool.Enqueue(obj);
    }





}
