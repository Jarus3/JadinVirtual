using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MostrarInfo : MonoBehaviour
{
    [SerializeField] private GameObject botonOcultar;
    [SerializeField] private GameObject informacion;
    [SerializeField] private GameObject nombre;
    [SerializeField] private GameObject nombreCientifico;
    [SerializeField] private GameObject descripcion;
    [SerializeField] private GameObject usosMedicinales;
    public void MostrarInformacion(Planta planta)
    {
        nombre.GetComponent<TextMeshProUGUI>().text = "Nombre: "+planta.getNombre();
        nombreCientifico.GetComponent<TextMeshProUGUI>().text = "Nombre Cientifico: "+planta.getNombreCientifico();
        descripcion.GetComponent<TextMeshProUGUI>().text = "Descripcion: "+planta.getDescripcion();
        usosMedicinales.GetComponent<TextMeshProUGUI>().text = "Usos Medicinales: "+planta.getUsosMedicinales();
        informacion.SetActive(true);
        botonOcultar.SetActive(false);
    }
    public void ocultarInformacion()
    {
        informacion.SetActive(false);
        botonOcultar.SetActive(true);
    }
}
