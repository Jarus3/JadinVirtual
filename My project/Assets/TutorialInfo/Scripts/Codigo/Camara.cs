using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
public float velocidadMovimiento = 5f;
    void Update()
    {
        ManejarEntradaTactil();
    }

    void ManejarEntradaTactil()
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
                    // Puedes agregar lógica adicional para acciones cuando el dedo está en reposo.
                    break;
                case TouchPhase.Ended:
                    // Puedes agregar lógica adicional para acciones cuando el toque ha terminado.
                    break;
            }
        }   
    }

    void MoverCamara(Vector2 deltaPos)
    {
        Vector3 direccionMovimiento = new Vector3(deltaPos.x, 0, deltaPos.y);
        direccionMovimiento = Camera.main.transform.TransformDirection(direccionMovimiento);
        direccionMovimiento.y = 0;

        transform.Translate(direccionMovimiento * velocidadMovimiento * Time.deltaTime, Space.World);
    }   
}
