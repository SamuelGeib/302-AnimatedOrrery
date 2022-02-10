using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float speed;
    public float angleX;
    public float angleY;
    public float angleZ;

    private float x, y, z;


   void Start()
    {
        angleX = Random.Range(-20f, 20f);
        speed = Random.Range(0.75f, 1.25f);

    }

    // Update is called once per frame
    void Update()
    {
        /*
        x = transform.localEulerAngles.x * angleX;
        y = transform.localEulerAngles.y * angleY;
        z = transform.localEulerAngles.z * angleZ;
        */

        angleY += (speed / 10);
        transform.localEulerAngles = new Vector3(angleX, angleY, angleZ);
        //transform.localRotation = Quaternion.Euler(angleX, angleY, angleZ);
    }
}
