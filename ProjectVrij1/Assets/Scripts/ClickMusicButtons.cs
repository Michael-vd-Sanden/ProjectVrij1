using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMusicButtons : MonoBehaviour
{
    [SerializeField] private AudioSource sound;
    [SerializeField] private CheckAnswer checker;

    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    public void PlaySound()
    {
        sound.Play();
        checker.NotePlayed(sound.name);
    }
}
