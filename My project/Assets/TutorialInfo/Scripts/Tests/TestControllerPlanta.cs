using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
public class TestControllerPlanta
{
    // A Test behaves as an ordinary method
    private ControllerPlanta cPlanta;
    private GameObject plantaObj;
    [SetUp]
    public void SetUp()
    {
        plantaObj = new GameObject("ControllerPlanta");
        cPlanta = plantaObj.AddComponent<ControllerPlanta>();
    }
    [Test]
    public void TestCrecer()
    {
        int anterior = cPlanta.getEstadio();
        cPlanta.crecer();
        int actual = cPlanta.getEstadio();
        Assert.AreEqual(anterior + 1, actual);
    }

}
