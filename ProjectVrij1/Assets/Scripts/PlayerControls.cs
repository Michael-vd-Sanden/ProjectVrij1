using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public Camera cam;

    void Start()
    {
        cam = GetComponentInChildren<Camera>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 5f))
            {
                ClickMusicButtons interactable = hit.collider.GetComponent<ClickMusicButtons>();
                if (interactable != null) // hit 
                {
                    //press button
                    interactable.PlaySound();
                }
            }
        }
    }
}
