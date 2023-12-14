using UnityEngine;
public class MainScript : MonoBehaviour
{
    // Referencias a los otros scripts
    private MostrarInfo mostrar;
    private Planta planta;
    private GameObject dbObj;
    private ControllerDB controllerDB;

    void Start()
    {
        dbObj = GameObject.Find("ControladorJardin");
        controllerDB = dbObj.GetComponent<ControllerDB>();
        GameObject otherObject1 = GameObject.Find("Canvas");
        GameObject otherObject2 = GameObject.Find("NombreDelObjeto2");

        mostrar = otherObject1.GetComponent<MostrarInfo>();
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    GameObject touchedObject = hit.transform.gameObject;
                    if (touchedObject.name == "coca")
                    {
                        planta = controllerDB.getInformacionPlanta("Coca");
                        mostrar.MostrarInformacion(planta);
                    }
                    else if (touchedObject.name == "sewenqa")
                    {
                        planta = controllerDB.getInformacionPlanta("Sewenqa");
                        mostrar.MostrarInformacion(planta);
                    }
                    else if (touchedObject.name == "kantuta")
                    {
                        planta = controllerDB.getInformacionPlanta("Cantuta tricolor");
                        mostrar.MostrarInformacion(planta);
                    }
                    else if (touchedObject.name == "durazno")
                    {
                        planta = controllerDB.getInformacionPlanta("Durazno");
                        mostrar.MostrarInformacion(planta);
                    }
                    else if (touchedObject.name == "uri uri")
                    {
                        planta = controllerDB.getInformacionPlanta("Uri uri");
                        mostrar.MostrarInformacion(planta);
                    }
                }
            }
        }
    }
}
