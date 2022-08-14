using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatueComplete : MonoBehaviour
{
    [SerializeField] private HeadCollectable head;
    [SerializeField] private GameObject headObject;
    [SerializeField] private GameObject wall;
    [SerializeField] private GameObject mushrooms;

    public void giveHead()
    {
        if (head.isInInventory)
        {
            headObject.SetActive(true);
            wall.SetActive(false);
            mushrooms.SetActive(true);
        }
    }
}
