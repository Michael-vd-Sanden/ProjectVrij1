using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatueComplete : MonoBehaviour
{
    [SerializeField] private HeadCollectable head;
    [SerializeField] private GameObject headObject;

    public void giveHead()
    {
        if (head.isInInventory)
        {
            headObject.SetActive(true);
        }
    }
}
