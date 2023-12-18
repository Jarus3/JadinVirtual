using Unity.VisualScripting;
using UnityEngine;
public class MainScript : MonoBehaviour
{
    private MostrarInfo mostrar;
    private GameObject dbObj;
    private ControllerDB controllerDB;
    private Planta coca;
    private Planta sewenqa;
    private Planta kantuta;
    private Planta durazno;
    private Planta uriuri;

    void Start()
    {
        dbObj = GameObject.Find("ControladorJardin");
        controllerDB = dbObj.GetComponent<ControllerDB>();
        GameObject otherObject1 = GameObject.Find("Canvas");

        mostrar = otherObject1.GetComponent<MostrarInfo>();
        coca=controllerDB.getInformacionPlanta("Coca");
        sewenqa=controllerDB.getInformacionPlanta("Sewenka");
        kantuta=controllerDB.getInformacionPlanta("Cantuta tricolor");
        durazno=controllerDB.getInformacionPlanta("Durazno");
        uriuri=controllerDB.getInformacionPlanta("Uri uri");
        iniciar();
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
                    diferenciar(touchedObject);
                }
            }
        }
    }
    public void iniciar()
    {
        setEscenario(GameObject.Find("cocab"),GameObject.Find("coca"),coca.getEstadio());
        setEscenario(GameObject.Find("sewenqab"),GameObject.Find("sewenqa"),sewenqa.getEstadio());
        setEscenario(GameObject.Find("kantutab"),GameObject.Find("kantuta"),kantuta.getEstadio());
        setEscenario(GameObject.Find("duraznob"),GameObject.Find("durazno"),durazno.getEstadio());
        setEscenario(GameObject.Find("uri urib"),GameObject.Find("uri uri"),uriuri.getEstadio());
    }
    private void diferenciar(GameObject touchedObject)
    {
        if (touchedObject.name == "coca" || touchedObject.name == "cocab")
        {
            mostrar.MostrarInformacion(coca);
        }
        else if (touchedObject.name == "sewenqa" || touchedObject.name == "sewenqab")
        {
            mostrar.MostrarInformacion(sewenqa);
        }
        else if (touchedObject.name == "kantuta" || touchedObject.name == "kantutab")
        {
            mostrar.MostrarInformacion(kantuta);
        }
        else if (touchedObject.name == "durazno" || touchedObject.name == "duraznob")
        {
            mostrar.MostrarInformacion(durazno);
        }
        else if (touchedObject.name == "uri uri" || touchedObject.name == "uri urib")
        {
            mostrar.MostrarInformacion(uriuri);
        }
    }
    private void setEscenario(GameObject brote,GameObject mayor, int estadio){
        Animator amayor = mayor.GetComponent<Animator>();
        Animator abrote = brote.GetComponent<Animator>();
        if(estadio==0){
            brote.SetActive(true);
            mayor.SetActive(false);
            abrote.SetInteger("estadiob",0);
        }else if(estadio==1){
            brote.SetActive(true);
            mayor.SetActive(false);
            abrote.SetInteger("estadiob",1);
        }else if(estadio==2){
            brote.SetActive(false);
            mayor.SetActive(true);
            amayor.SetInteger("estadio",2);
        }else{
            brote.SetActive(false);
            mayor.SetActive(true);
            amayor.SetInteger("estadio",3);
        }
    }
}
