using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckEasyAnswer : MonoBehaviour
{
    private bool note1 = false;
    private bool note2 = false;
    private bool note3 = false;
    private bool note4 = false;

    public ParticleSystem particles;


    public void NotePlayed(string note)
    {
        switch (note)
        {
            case "ToneD":
                note1 = true;
                break;
            case "ToneFis":
                if (note1) { note2 = true; }
                else { SetAllToFalse(); };
                break;
            case "ToneA":
                if (note2) { note3 = true; }
                else { SetAllToFalse(); };
                break;
            case "ToneF":
                if (note3) 
                { 
                    note4 = true;
                    Debug.Log("YOU DID IT");
                    particles.Play();
                    SetAllToFalse();
                }
                else { SetAllToFalse(); };
                break;

        }
    }

    public void SetAllToFalse()
    {
        note1 = false;
        note2 = false;
        note3 = false;
        note4 = false;
    }
}
