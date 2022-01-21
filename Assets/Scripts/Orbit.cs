using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{

    public Transform orbitCenter;


    public float radius = 10; // UInit is Meters
    public float speed = Random.Range(1.0f, 5.0f);



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!orbitCenter) return;

        float x = radius * Mathf.Cos(Time.time * speed);
        float z = radius * Mathf.Sin(Time.time * speed);

        transform.position = new Vector3(x, 0, z) + orbitCenter.position;
    }
}
