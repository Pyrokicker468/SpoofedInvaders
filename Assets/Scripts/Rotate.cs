using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    //Credit to https://www.appsloveworld.com/csharp/100/448/rotate-gameobject-around-pivot-point-over-time 
    //The GameObject with the pivot point to move
    public GameObject pointToRotate;
    //The Pivot point to move the GameObject around
    public Transform pivotPoint;

    //The angle to Move the pivot point
    public Vector3 angle = new Vector3(0f, 180f, 0f);

    //The duration for the rotation to occur
    public float rotDuration = 5f;
    public GameObject root;

    void Start()
    {
        root = GameObject.Find("Directional Light");
    }
    void Update()
    {
            StartCoroutine(rotateObject(pointToRotate, pivotPoint.position, angle, rotDuration));
            pointToRotate.transform.LookAt(pivotPoint);
        
    }

    bool rotating = false;

    IEnumerator rotateObject(GameObject objPoint, Vector3 pivot, Vector3 angles, float duration)
    {
        if (rotating)
        {
            yield break;
        }
        rotating = true;

        Vector3 beginRotPoint = RotatePointAroundPivot(objPoint.transform.position, pivot, Vector3.zero);

        float counter = 0;
        while (counter < duration)
        {
            counter += Time.deltaTime;

            float t = counter / duration;
            Vector3 tempAngle = Vector3.Lerp(Vector3.zero, angles, t);

            Vector3 tempPivot = RotatePointAroundPivot(beginRotPoint, pivot, tempAngle);
            objPoint.transform.position = tempPivot;
            yield return null;
        }
        rotating = false;
    }

    Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angles)
    {
        Vector3 dir = point - pivot; // get point direction relative to pivot
        dir = Quaternion.Euler(angles) * dir; // rotate it
        point = dir + pivot; // calculate rotated point

        return point;
    }
}
