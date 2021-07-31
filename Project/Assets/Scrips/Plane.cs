using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{

    public GameObject turbine;

    public float speed;
    public Vector3 rotationAxis;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.RotateAround(rotationAxis, Vector3.up, this.speed * -Time.deltaTime);
        turbine.transform.Rotate(Vector3.right, 360 * 7 * Time.deltaTime);
    }
}
