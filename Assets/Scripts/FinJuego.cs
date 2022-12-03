using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinJuego : MonoBehaviour
{

    public void cambiarEscena(int index_escena)
    {
        SceneManager.LoadScene(index_escena);
    }
}
