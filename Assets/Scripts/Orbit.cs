using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class Orbit : MonoBehaviour
{
    public float timeMultiplier = 1;
    public float timeOffset = 0;

    public Transform orbitCenter;


    public float radius = 10; // UInit is Meters
    public int pathResolution = 100;


    // Rotation Settings
    public float rotation = 0;
    public float rotationSpeed = 1;

    // Orbit Settings
    public float offsetX = 1;
    public float offsetY = 0;
    public float offsetZ = 1;
    public float axisOffsetX = 0;
    public float axisOffsetZ = 0;

    public bool worldSpace = true;


    private LineRenderer path; // Renders line representing orbital path


    // Start is called before the first frame update
    void Start()
    {
        path = GetComponent<LineRenderer>();

        path.loop = true;
        path.useWorldSpace = worldSpace;

        UpdateOrbitPath();
    }


    void Update()
    {
        if (!orbitCenter) return;

        float x = radius * Mathf.Cos(Time.time * timeMultiplier + timeOffset) * offsetX;
        float y = radius * Mathf.Sin(Time.time * timeMultiplier + timeOffset) * offsetY;
        float z = radius * Mathf.Sin(Time.time * timeMultiplier + timeOffset) * offsetZ;


        transform.position = new Vector3(x, y, z) + orbitCenter.position;


         

        if (orbitCenter.hasChanged) UpdateOrbitPath();
    }

    void UpdateOrbitPath()
    {

        if (!orbitCenter) return;

        float radsPerCircle = 2 * Mathf.PI;

        // Resolution: The number of points we use to calculate the path of orbit

        Vector3[] pts = new Vector3[pathResolution]; // [] means array

        for (int i = 0; i < pts.Length; i++)
        {

            float x = radius * Mathf.Cos(i * radsPerCircle / pathResolution) * offsetX;
            float y = radius * Mathf.Sin(i * radsPerCircle / pathResolution) * offsetY;
            float z = radius * Mathf.Sin(i * radsPerCircle / pathResolution) * offsetZ;

            pts[i] = new Vector3(x, y, z) + orbitCenter.position;
        }

        path.positionCount = pathResolution;
        path.SetPositions(pts);

    }
}
