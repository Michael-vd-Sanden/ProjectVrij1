using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CylinderRotation : MonoBehaviour
{
    //public List<GameObject> cylinderList = new List<GameObject>();
    public Coroutine currentRoutine;
    private Quaternion newRotationInQuats;

    private float newMaxRotation;


    public void Start()
    {
        newMaxRotation = 0f;
        //currentRoutine = StartCoroutine(RotateCylinder(0, 20f, 0.09f, 5f));
    }

    //public IEnumerator RotateCylinder(int cylinderIndex, float maxRotation, float refreshSpeed, float RotationAdded)
    //{
    //    while (true)
    //    {
    //        if (cylinderList[cylinderIndex].transform.localEulerAngles.x > maxRotation + 0.5f) //|| )
    //        {
    //            cylinderList[cylinderIndex].transform.Rotate(new Vector3(0,RotationAdded,0),Space.Self);
    //            yield return new WaitForSeconds(refreshSpeed);
    //        }
    //        else
    //        {
    //            StopCoroutine(currentRoutine);
    //            yield return new WaitForSeconds(0);
    //        }
    //    }
    //}

    public IEnumerator RotateCylinder(float maxRotation, float refreshSpeed, float RotationAdded)
    {
        newMaxRotation = maxRotation;
        while (true)
        {
            if (transform.localEulerAngles.x > newMaxRotation + 0.5f) 
            {
                checkRotation();
                Debug.Log(newMaxRotation);
                transform.Rotate(new Vector3(0, RotationAdded, 0), Space.Self);
                yield return new WaitForSeconds(refreshSpeed);
            }
            else
            {              
                StopCoroutine(currentRoutine);
                yield return new WaitForSeconds(0);
            }
        }
    }

    public void checkRotation()
    {
        if (transform.localEulerAngles.x > newMaxRotation)
        {
            newMaxRotation += 20;
        }
    }
}
