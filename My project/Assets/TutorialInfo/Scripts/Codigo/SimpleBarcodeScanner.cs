using UnityEngine;
using Vuforia;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SimpleBarcodeScanner : MonoBehaviour
{
    public TMPro.TextMeshProUGUI barcodeAsText;
    private string barcodeText;
    string[] codigosEspecificos = { "Coca", "Kantuta", "Sewenka", "Durazno", "Uri Uri" };
    BarcodeBehaviour mBarcodeBehaviour;
    void Start()
    {
        mBarcodeBehaviour = GetComponent<BarcodeBehaviour>();
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
        foreach (string codigo in codigosEspecificos)
        {
            if (barcodeText == codigo)
            {
                SceneManager.LoadScene("Jardin");
                break;
            }
        }
    }
}