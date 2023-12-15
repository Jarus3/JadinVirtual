using UnityEngine;
using Vuforia;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Mono.Data.Sqlite;
using System.Data;
using System;
public class SimpleBarcodeScanner : MonoBehaviour
{
    public ControllerDB db;
    public TMPro.TextMeshProUGUI barcodeAsText;
    private string barcodeText;
    string[] codigosEspecificos = { "Coca", "Kantuta", "Sewenka", "Durazno", "Uri Uri" };
    BarcodeBehaviour mBarcodeBehaviour;
    void Start()
    {
        mBarcodeBehaviour = GetComponent<BarcodeBehaviour>();
        db = new ControllerDB();
    }

    // Update is called once per frame
    void Update()
    {
        if (mBarcodeBehaviour != null && mBarcodeBehaviour.InstanceData != null)
        {
            barcodeAsText.text = mBarcodeBehaviour.InstanceData.Text;
            barcodeText = mBarcodeBehaviour.InstanceData.Text;
            escenaChange(barcodeText);
        }
        else
        {
            barcodeAsText.text = "";
        }
    }
    public void escenaChange(string barcodeText)
    {
        int estadio = db.getEstadio(barcodeText);
        string fecha = db.getFecha(barcodeText);
        int diferencia = calcularFecha(fecha);

        // && diferencia >= 1

        foreach (string codigo in codigosEspecificos)
        {
            if (barcodeText == codigo && estadio < 3 && diferencia >= 1)
            {
                db.Query("UPDATE planta SET estadio = estadio + 1 WHERE codigoQR = '" + codigo + "';");
                db.Query("UPDATE planta SET fecha_escaneo = date('now') WHERE codigoQR = '" + codigo + "';");
                SceneManager.LoadScene("Jardin");
                break;
            }
        }
    }

    public int calcularFecha(string fecha){
        string fechaActual = DateTime.Now.ToString("yyyy-MM-dd");

        DateTime fechaBaseDeDatos = DateTime.ParseExact(fecha, "yyyy-MM-dd", null);
        DateTime fechaActualConvertida = DateTime.ParseExact(fechaActual, "yyyy-MM-dd", null);

        TimeSpan diferencia = fechaActualConvertida - fechaBaseDeDatos;

        return diferencia.Days;
    }
}