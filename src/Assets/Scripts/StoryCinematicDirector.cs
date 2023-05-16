using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class StoryCinematicDirector : MonoBehaviour
{
    [SerializeField]
    private PlayableDirector summonOgreCinematic;

    void Start()
    {
        //SubscribeToStoryEvents();
    }

    // void SubscribeToStoryEvents()
    // {
    //     InteractableWizard.OnClickWizardSummonsOgre += PlaySummonOgreCinematic;
    // }

    // private void PlaySummonOgreCinematic()
    // {
    //     summonOgreCinematic.Play();
    //     InteractableWizard.OnClickWizardSummonsOgre -= PlaySummonOgreCinematic;
    // }

}
