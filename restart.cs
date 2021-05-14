using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public GameObject restartSound;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Instantiate(restartSound, transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            Instantiate(restartSound, transform.position, Quaternion.identity);
        }
    }
}
