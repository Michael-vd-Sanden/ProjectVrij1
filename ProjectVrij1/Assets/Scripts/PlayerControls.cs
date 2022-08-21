using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] SceneSelect scenes;
    public Camera cam;

    [SerializeField] GameObject flashlight;
    private bool flashIsOn = false;

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

                AnimationTrigger trigger = hit.collider.GetComponent<AnimationTrigger>();
                if(trigger != null)
                {
                    trigger.pulledCable();
                }

                CylinderRotation rotation = hit.collider.GetComponent<CylinderRotation>();
                if (rotation != null)
                {
                    rotation.currentRoutine = StartCoroutine(rotation.RotateCylinder(20f, 0.09f, 5f));
                }

                HeadCollectable head = hit.collider.GetComponent<HeadCollectable>();
                if (head != null)
                {
                    head.pickUpHead();
                }

                StatueComplete statue = hit.collider.GetComponent<StatueComplete>();
                if (statue != null)
                {
                    statue.giveHead();
                }

                VoiceLines voice = hit.collider.GetComponent<VoiceLines>();
                {
                    if (voice != null)
                    {
                        voice.PlaySound();
                    }
                }
            }
        }

        if(Input.GetKeyDown(KeyCode.F))
        {
            flashIsOn = !flashIsOn;
            flashlight.SetActive(flashIsOn);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "End")
        {
            scenes.loadStartScene();
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
