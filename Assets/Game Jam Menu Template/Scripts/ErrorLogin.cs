using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ErrorLogin : MonoBehaviour
{
    public GameObject CuadroReiniciar;
    // Use this for initialization


    public void cambiarEscena()
    {
        SceneManager.LoadScene("Log-Reg");

    }

    void Start()
    {
        if (LoginController.KinectErrorDetected == 3)
            CuadroReiniciar.SetActive(true);
        else
            CuadroReiniciar.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
     }
}


