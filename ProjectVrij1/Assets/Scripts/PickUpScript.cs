using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    [SerializeField] private List<GameObject> itemList;
    private Camera cam;

    private void Start()
    {
        cam = GetComponentInChildren<Camera>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //RaycastHit hit;
            //Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            //if (Physics.Raycast(ray, out hit, 5f))
            //{
            //    "ClassName" item = hit.collider.GetComponent<"ClassName">();
            //    if (item != null) // hit 
            //    {
            //        foreach(GameObject g in itemList)
            //        {
            //            if(g.tag == item.tag)
            //            {
            //                item.isInInventory(true);
            //            }
            //        }
            //    }
            //}
        }
    }
}
