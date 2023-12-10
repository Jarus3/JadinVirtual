using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public float velocidadMovimiento = 5f;
    private static Camera mainCamera;
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
            Touch toque = Input.GetTouch(0);

            switch (toque.phase)
            {
                case TouchPhase.Moved:
                    MoverCamara(toque.deltaPosition);
                    break;
                case TouchPhase.Stationary:
                    break;
                case TouchPhase.Ended:
                    break;
            }
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
}