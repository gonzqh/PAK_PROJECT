using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class reiniciarKinectCuadro : MonoBehaviour
{
    public GameObject CuadroReiniciar;
    // Use this for initialization


    public void cambiarEscena()
    {
        SceneManager.LoadScene("Scene");

    }

    void Start()
    {
        if (LoginController.KinectErrorDetected == 1)
            CuadroReiniciar.SetActive(true);
        else
            CuadroReiniciar.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }
}


