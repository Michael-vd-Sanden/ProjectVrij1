using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAnswer : MonoBehaviour
{
    private bool note1 = false;
    private bool note2 = false;
    private bool note3 = false;
    private bool note4 = false;
    private bool note5 = false;
    private bool note6 = false;
    private bool note7 = false;
    private bool note8 = false;

    public ParticleSystem particles;

    void Start()
    {
        
    }

    void Update()
    {

    }

    public void NotePlayed(string note)
    {
        switch (note)
        {
            case "ToneD": 
                if (note1 && note7) 
                { 
                    note8 = true; 
                    Debug.Log("YOU DID IT");
                    particles.Play();
                    SetAllToFalse();
                };
                    if (!note1) {           //We beginnen opnieuw
                        SetAllToFalse(); 
                        note1 = true;
                    };
                break;
            case "ToneFis": if (note2 && note6) { note7 = true; };
                if (note1) { note2 = true; }
                else { SetAllToFalse(); };
                break;
            case "ToneA": 
                if (note2) { note3 = true; }
                else { SetAllToFalse(); };
                break;
            case "ToneF":
                if (note3) { note4 = true; } 
                else { SetAllToFalse(); };
                break;
            case "ToneGis":
                if (note4) { note5 = true; }
                else { SetAllToFalse(); };
                break;
            case "ToneE":
                if (note5) { note6 = true; }
                else { SetAllToFalse();  };
                break;
        }
    }

    public void SetAllToFalse()
    {
        note1 = false;
        note2 = false;
        note3 = false;
        note4 = false;
        note5 = false;
        note6 = false;
        note7 = false;
        note8 = false;
    }
}
