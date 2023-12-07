using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Planta;

public class ControllerPlanta : MonoBehaviour
{
    Planta planta;
    // Start is called before the first frame update
    void Start()
    {
        planta = new Planta();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void crecer()
    {
        
    }
    public int getEstadio()
    {
        return planta.estadio;
    }
    public string getQR()
    {
        return "1";
    }
    public string getNombre()
    {
        return "1";
    }
    public string getDescripcion()
    {
        return "1";
    }
    public string getUsosMedicinales()
    {
        return "1";
    }
}
