using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public Transform Turret, Guns, Target; //Assign to the object you want to rotate
    public float TurretSpeed, GunsSpeed;
    private float TurretAngle, GunsAngle;
    public Camera main;
    public GameObject root;

    void Start()
    {
        root = GameObject.Find("Directional Light");
    }

    void Update()
    {
        if (root.GetComponent<TheWorld>().returnCheck())
        {
            RotateTurret();
            Guns.LookAt(2 * Guns.position - Target.position);
        }
    }

    void RotateTurret()
    {
        TurretAngle += Input.GetAxis("Mouse X") * TurretSpeed * Time.deltaTime;
        TurretAngle = Mathf.Clamp(TurretAngle, -75, 75);
        Turret.localRotation = Quaternion.AngleAxis(TurretAngle, Vector3.up);
    }

}
