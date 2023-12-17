using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usuario : MonoBehaviour
{
    public string nombre;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Inicializar(string nombre)
    {
        this.nombre=nombre;
    }
    public void setNombre(string nombre)
    {
        this.nombre=nombre;
    }
    public string getNombre()
    {
        return this.nombre;
    }
}
