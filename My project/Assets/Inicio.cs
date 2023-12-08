using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
public class Inicio : MonoBehaviour
{
    // Start is called before the first frame update

    private string nombre;
    public void escenaMenu()
    {
        guardarUsuario();
        SceneManager.LoadScene("Menu");
    }
    public void guardarNombre(string input)
    {
        nombre = input;
        Debug.Log(nombre);
    }
    private void guardarUsuario()
    {
        ControllerDB db = new ControllerDB();
        string sqlQuery = "INSERT INTO usuario (nombre) VALUES ('" + nombre + "')";
        db.Query(sqlQuery);
    }
}
