using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadCollectable : MonoBehaviour
{
    public bool isInInventory = false;

    public void pickUpHead()
    {
        this.gameObject.SetActive(false);
        isInInventory = true;
    }
}
