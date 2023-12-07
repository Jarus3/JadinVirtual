using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Usuario;
public class ControllerUsuario : MonoBehaviour
{
    // Start is called before the first frame update
    Usuario usuario;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addPlanta(Planta planta)
    {
        usuario.plantas.Add(planta);
    }

    public void setNombre(string nombre)
    {
        usuario.nombre = nombre;
    }
    public string getNombre()
    {
        return usuario.nombre;
    }
    public ArrayList getPlantas()
    {
        return usuario.plantas;
    }
    public Planta getPlanta(int index)
    {
        return (Planta)usuario.plantas[index];
    }
    public string ScanQR()
    {
        return "1";
    }
}
