using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceLines : MonoBehaviour
{
    [SerializeField] private AudioSource sound;
    private MeshRenderer mesh;
    private BoxCollider boxCollider;

    void Start()
    {
        sound = GetComponent<AudioSource>();
        mesh = GetComponent<MeshRenderer>();
        boxCollider = GetComponent<BoxCollider>();
    }

    public void PlaySound()
    {
        sound.Play();
        mesh.enabled = false;
        boxCollider.enabled = false;
    }
}
