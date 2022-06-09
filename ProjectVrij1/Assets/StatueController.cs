using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatueController : MonoBehaviour
{
    public List<GameObject> components = new List<GameObject>();
    
    [Serializable]
    public class PositionsList
    {
        public Vector3[] componentPositionsAsVectors;
    }

    public PositionsList[] positionsLists;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RotateStatue());
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator RotateStatue()
    {
        while (true)
        {
            int index = 0;
            for(int i = 0; i < positionsLists.Length; i++)
            {
                foreach(Vector3 positionsToRotateTo in positionsLists[i].componentPositionsAsVectors)
                {
                    components[index].transform.Rotate(positionsToRotateTo,Space.Self);
                    index += 1;
                }
            }
            yield return new WaitForSeconds(0.09f);
        }
    }
}
