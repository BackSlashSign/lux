﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestoryEffect : MonoBehaviour {

    ParticleSystem particle;

    void Start()
    {
        particle = GetComponent<ParticleSystem>();
    }
    void Update()
    {
        if (!particle.isPlaying)
        {
            Destroy(this.gameObject);
        }
    }
}
