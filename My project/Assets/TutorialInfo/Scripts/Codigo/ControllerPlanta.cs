using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Planta;

public class ControllerPlanta : MonoBehaviour
{
    private Planta planta;
    private GameObject plantaObj;
    // Start is called before the first frame update
    public void Inicializar()
    {
        plantaObj = new GameObject("Planta");
        planta = plantaObj.AddComponent<Planta>();
        planta.Inicializar("1", "2", "3", 0, "4", "5");
    }

    public void crecer()
    {
        int nuevo=planta.getEstadio()+1;
        planta.setEstadio(nuevo);
    }
    public Planta getPlanta()
    {
        return planta;
    }
    public int getEstadio()
    {
        return planta.getEstadio();
    }
}
