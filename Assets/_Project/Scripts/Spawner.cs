using UnityEngine;

public class Spawner : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameObject go = MyPooling.Instance.GetPoolObj();
            go.SetActive(true);
        }
    }
}
