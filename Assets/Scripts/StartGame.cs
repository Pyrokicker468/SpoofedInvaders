using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    //Music from https://www.zapsplat.com
    Vector3 beginPos = new Vector3(-15.3f, 10f, 23);
    Vector3 endPos = new Vector3(-15.3f, 10f, -10);
    float time = 2.5f;

    void Start()
    {
        GameObject.Destroy(gameObject, time);
        StartCoroutine(Move(beginPos, endPos, time));
    }

    IEnumerator Move(Vector3 beginPos, Vector3 endPos, float time)
    {
        for (float t = 0; t < 1; t += Time.deltaTime / time)
        {
            transform.position = Vector3.Lerp(beginPos, endPos, t);
            yield return null;
        }
    }
}
