using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestControllerUsuario
{
    // A Test behaves as an ordinary method
    [Test]
    public void TestAddPlanta()
    {
        ControllerUsuario usuario = new ControllerUsuario();
        Planta planta = new Planta();
        usuario.addPlanta(planta);
        Assert.AreEqual(planta,usuario.getPlanta(0));
    }
    [Test]
    public void TestSetNombre()
    {
        ControllerUsuario usuario = new ControllerUsuario();
        usuario.setNombre("1");
        Assert.AreEqual("1",usuario.getNombre());
    }
    [Test]
    public void TestGetNombre()
    {
        ControllerUsuario usuario = new ControllerUsuario();
        usuario.setNombre("1");
        Assert.AreEqual("1",usuario.getNombre());
    }
    [Test]
    public void TestGetPlantas()
    {
        ControllerUsuario usuario = new ControllerUsuario();
        Planta planta = new Planta();
        usuario.addPlanta(planta);
        usuario.addPlanta(planta);
        ArrayList plantas = new ArrayList();
        plantas.Add(planta);
        plantas.Add(planta);
        Assert.AreEqual(plantas,usuario.getPlantas());
    }
    [Test]
    public void TestGetPlanta()
    {
        ControllerUsuario usuario = new ControllerUsuario();
        Planta planta = new Planta();
        usuario.addPlanta(planta);
        Assert.AreEqual(planta,usuario.getPlanta(0));
    }
    [Test]
    public void TestScanQR()
    {
        ControllerUsuario usuario = new ControllerUsuario();
        string actual = usuario.ScanQR();
        Assert.AreEqual("0",actual);
    }
}
