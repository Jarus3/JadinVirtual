using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planta : MonoBehaviour
{
    private string nombre;
    private string descripcion;
    private string nombreCientifico;
    private int estadio;
    private string usosMedicinales;
    private string codigoQR;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Inicializar(string nombre, string nombreCientifico, string descripcion, int estadio, string usosMedicinales, string codigoQR)
    {
        this.nombre = nombre;
        this.nombreCientifico = nombreCientifico;
        this.descripcion = descripcion;
        this.estadio = estadio;
        this.usosMedicinales = usosMedicinales;
        this.codigoQR = codigoQR;
    }
    public Planta()
    {
        this.nombre = "";
        this.nombreCientifico = "";
        this.descripcion = "";
        this.estadio = 0;
        this.usosMedicinales = "";
        this.codigoQR = "";
    }

    public string getNombre()
    {
        return nombre;
    }
    public string getNombreCientifico()
    {
        return nombreCientifico;
    }
    public string getDescripcion()
    {
        return descripcion;
    }
    public int getEstadio()
    {
        return estadio;
    }
    public string getUsosMedicinales()
    {
        return usosMedicinales;
    }
    public string getCodigoQR()
    {
        return codigoQR;
    }
    public void setNombre(string nombre)
    {
        this.nombre = nombre;
    }
    public void setNombreCientifico(string nombreCientifico)
    {
        this.nombreCientifico = nombreCientifico;
    }
    public void setDescripcion(string descripcion)
    {
        this.descripcion = descripcion;
    }
    public void setEstadio(int estadio)
    {
        this.estadio = estadio;
    }
    public void setUsosMedicinales(string usosMedicinales)
    {
        this.usosMedicinales = usosMedicinales;
    }
    public void setCodigoQR(string codigoQR)
    {
        this.codigoQR = codigoQR;
    }

}
