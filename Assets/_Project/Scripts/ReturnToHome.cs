using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToHome : MonoBehaviour
{

    private void OnEnable()
    {
        StartCoroutine(WaitToreturn());
    }

    IEnumerator WaitToreturn()
    {
        yield return new WaitForSeconds(3f);

        MyPooling.Instance.PutPoolObj(gameObject);
    }

}
