﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class framerateLimit : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        Application.targetFrameRate = 60;
    }
}