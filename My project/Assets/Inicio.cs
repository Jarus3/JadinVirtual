using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
public class Inicio : MonoBehaviour
{
    // Start is called before the first frame update

    private string nombre="Player";
    private GameObject gdb;
    private ControllerDB db;
    void Start()
    {
        gdb=GameObject.Find("ControladorInicio");
        db = gdb.GetComponent<ControllerDB>();
    }
    public void escenaMenu()
    {
        iniciarDB();
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
        db.llenarDatosUsuario(nombre);
    }
    private void iniciarDB()
    {
        db.CreateTable();
        db.llenarDatos();
    }
}
