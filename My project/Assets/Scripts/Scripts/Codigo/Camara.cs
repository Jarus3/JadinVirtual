using UnityEngine;

public class Camara : MonoBehaviour
{
    public float velocidadMovimiento = 2f;
    public float zoomSpeed = 1f;

    private static Camera mainCamera;

    private Vector2 lastTouchPosition1;
    private Vector2 lastTouchPosition2;
    private float lastDistance;

    void Start()
    {
        if (mainCamera == null)
        {
            mainCamera = Camera.main;
        }
    }

    public static void SetMainCamera(Camera camera)
    {
        mainCamera = camera;
    }

    void Update()
    {
        ManejarEntradaTactil();
    }

    public void ManejarEntradaTactil()
    {
        if (Input.touchCount == 1)
        {
            Touch singleTouch = Input.GetTouch(0);

            switch (singleTouch.phase)
            {
                case TouchPhase.Moved:
                    MoverCamara(singleTouch.deltaPosition);
                    break;
                case TouchPhase.Stationary:
                    break;
                case TouchPhase.Ended:
                    break;
            }
        }
        else if (Input.touchCount == 2)
        {
            Touch touch1 = Input.GetTouch(0);
            Touch touch2 = Input.GetTouch(1);

            Vector2 currentTouchPosition1 = touch1.position;
            Vector2 currentTouchPosition2 = touch2.position;

            float currentDistance = Vector2.Distance(currentTouchPosition1, currentTouchPosition2);

            if (touch1.phase == TouchPhase.Moved || touch2.phase == TouchPhase.Moved)
            {
                float deltaDistance = lastDistance - currentDistance;
                Zoom(deltaDistance);
            }

            lastTouchPosition1 = currentTouchPosition1;
            lastTouchPosition2 = currentTouchPosition2;
            lastDistance = currentDistance;
        }
    }

    public void MoverCamara(Vector2 deltaPos)
    {
        Vector3 direccionMovimiento = new Vector3(-deltaPos.x, 0, -deltaPos.y);

        if (mainCamera != null)
        {
            direccionMovimiento = mainCamera.transform.TransformDirection(direccionMovimiento);
            direccionMovimiento.y = 0;

            transform.Translate(direccionMovimiento * velocidadMovimiento * Time.deltaTime, Space.World);
        }
        else
        {
            Debug.LogError("No se ha establecido la cámara principal.");
        }
    }

    public void Zoom(float deltaDistance)
    {
        mainCamera.fieldOfView += deltaDistance * zoomSpeed * Time.deltaTime;
        mainCamera.fieldOfView = Mathf.Clamp(mainCamera.fieldOfView, 10f, 121f);
    }

    public static Camera GetMainCamera()
    {
        return mainCamera;
    }
}
