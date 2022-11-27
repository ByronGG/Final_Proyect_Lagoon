using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EasterEGG_TEST : MonoBehaviour
{

    public void cambiarEscena(int index_escena)
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(index_escena);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Scene scene = SceneManager.GetActiveScene();
            if(scene.buildIndex == 0)
            {
                cambiarEscena(3);
            }
            if(scene.buildIndex == 2)
            {
                cambiarEscena(3);
            }
        }
    }
}