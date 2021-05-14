using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuMusic : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject music;
    void Start()
    {
        Instantiate(music, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
