using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LogicaObjetivoFinal : MonoBehaviour
{
    public int numDeObjetivos;
    public TextMeshProUGUI textoMision;
    public GameObject botonDeMision;
    // Start is called before the first frame update
    void Start()
    {
        numDeObjetivos = GameObject.FindGameObjectsWithTag("objetivo").Length;
        textoMision.text = "Busca tus pertenencias perdidas" + "\n restantes: " + numDeObjetivos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "objetivo")
        {
            Destroy(other.transform.parent.gameObject);
            numDeObjetivos--;
            textoMision.text = "Buscar tus pertenencias perdidas" +
                "\n restantes: " + numDeObjetivos;
            if(numDeObjetivos <= 0)
            {
                textoMision.text = "Completaste la misión";
                botonDeMision.SetActive(true);
            }
        }
    }
}
