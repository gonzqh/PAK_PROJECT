using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class regresarMenu : MonoBehaviour {

    public void regresarModuloAnterior() {
        string modulo = ModulosController.modulo;
        DestroyImmediate(Camera.main.gameObject);
        SceneManager.LoadScene("Scene");
    }
}
