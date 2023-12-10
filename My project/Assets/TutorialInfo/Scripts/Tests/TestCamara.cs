using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestCamara
{


    [Test]
    public void TestNoMoverCamara()
    {
        GameObject camaraObject = new GameObject();
        Camara camaraScript = camaraObject.AddComponent<Camara>();

        Touch toque = new Touch { phase = TouchPhase.Stationary };

        camaraScript.ManejarEntradaTactil();

        Assert.AreEqual(Vector3.zero, camaraScript.transform.position);
    }

    [UnityTest]
    public IEnumerator TestMoverCamara()
    {
        GameObject camaraObject = new GameObject();
        Camara camaraScript = camaraObject.AddComponent<Camara>();

        Camera mainCamera = new GameObject().AddComponent<Camera>();

        Camara.SetMainCamera(mainCamera);

        Touch toque = new Touch { phase = TouchPhase.Moved, deltaPosition = new Vector2(2f, 3f) };

        camaraScript.ManejarEntradaTactil(); 
        camaraScript.MoverCamara(toque.deltaPosition); 

        yield return null;

        Assert.AreNotEqual(Vector3.zero, camaraScript.transform.position);
    }  
}
