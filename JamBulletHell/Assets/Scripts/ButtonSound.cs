﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioSource buttonSound;

    public void ButtonNoise()
    {
        buttonSound.Play();
    }
}
