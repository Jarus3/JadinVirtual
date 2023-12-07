using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
public class TestControllerPlanta
{
    // A Test behaves as an ordinary method
    [Test]
    public void TestCrecer()
    {
        ControllerPlanta planta = new ControllerPlanta();
        int anterior=planta.getEstadio();
        planta.crecer();
        int actual = planta.getEstadio();
        Assert.AreEqual(anterior+1,actual);
    }
    [Test]
    public void TestGetQR()
    {
        ControllerPlanta planta = new ControllerPlanta();
        string actual = planta.getQR();
        Assert.AreEqual("0",actual);
    }
    [Test]
    public void TestGetNombre()
    {
        ControllerPlanta planta = new ControllerPlanta();
        string actual = planta.getNombre();
        Assert.AreEqual("0",actual);
    }
    [Test]
    public void TestGetDescripcion()
    {
        ControllerPlanta planta = new ControllerPlanta();
        string actual = planta.getDescripcion();
        Assert.AreEqual("0",actual);
    }
    [Test]
    public void TestGetUsosMedicinales()
    {
        ControllerPlanta planta = new ControllerPlanta();
        string actual = planta.getUsosMedicinales();
        Assert.AreEqual("0",actual);
    }
    [Test]
    public void TestGetEstadio()
    {
        ControllerPlanta planta = new ControllerPlanta();
        int actual = planta.getEstadio();
        Assert.AreEqual(0,actual);
    }
}
