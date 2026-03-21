using UnityEngine;

public abstract class GenericSingleton<T> : MonoBehaviour where T : GenericSingleton<T>
{
    private static T _instance;

    private static bool _isApplicationQuitting = false;

    protected virtual bool ShouldBeDestroyedOnLoad() => false;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindAnyObjectByType<T>(FindObjectsInactive.Include);

                if (_instance == null && !_isApplicationQuitting)
                {
                    Debug.LogWarning($"Genetrating {typeof(T)} singleton");
                    GameObject gameObject = new GameObject(typeof(T).ToString());
                    _instance = gameObject.AddComponent<T>();
                }
            }
            return _instance;
        }
    }

    protected virtual void Awake()
    {
        if (_instance == null)
        {
            _instance = GetComponent<T>();

            if (!ShouldBeDestroyedOnLoad())
            {
                DontDestroyOnLoad(gameObject);
            }
        }
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
    }

    protected virtual void onDestroy()
    {
        if (_instance == this)
        {
            _instance = null;
        }
    }

    protected virtual void OnApplicationQuit()
    {
        _isApplicationQuitting = true;
    }

}