using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    public float rotatespeed;
    public List<GameObject> cylinders = new List<GameObject>();
    void Start()
    {
        Rotate(0, 14);
        Rotate(1,-7);
        Rotate(2, 270);
    }

    void Update()
    {
        
    }
    void FixedUpdate() 
    {
        
    }
    public void Rotate(int index, float rotatie)
    {
        if (cylinders[index].transform.rotation.x >= cylinders[index].transform.rotation.x)
        {
            cylinders[index].transform.rotation = Quaternion.RotateTowards(transform.rotation,
                Quaternion.Euler(rotatie, transform.localRotation.y, transform.localRotation.z), rotatespeed);
        }
        Debug.Log(cylinders[index].transform.rotation);
    }
}
