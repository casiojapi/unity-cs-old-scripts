﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeatingBg : MonoBehaviour
{
    public float speed;
    
    public float endX;
    public float startX;
    // Start is called before the first frame update
      void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x <= endX) {
            Vector2 pos = new Vector2(startX, transform.position.y);
            transform.position = pos;
        }
    }
}
