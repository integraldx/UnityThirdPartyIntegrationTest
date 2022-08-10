using System.Collections;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(Coroutine());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }
    
    private IEnumerator Coroutine()
    {
        while (Application.isPlaying)
        {
            Debug.Log("Hello World!");
            yield return new WaitForSeconds(1.0f);
        }
    }
}