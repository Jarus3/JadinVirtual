using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestPlanta
{
    GameObject plantaObj = new GameObject("Planta");
    Planta planta;

    private string nombre;
    private string descripcion;
    private string nombreCientifico;
    private int estadio;
    private string usosMedicinales;
    private string codigoQR;

    [SetUp]
    public void SetUp()
    {
        nombre="1";
        nombreCientifico="2";
        descripcion="3";
        estadio=0;
        usosMedicinales="4";
        codigoQR="5";
        planta = plantaObj.AddComponent<Planta>();
        planta.Inicializar(nombre, nombreCientifico, descripcion, estadio, usosMedicinales, codigoQR);
    }
    // A Test behaves as an ordinary method
    [Test]
    public void TestGetQR()
    {
        string actual = planta.getCodigoQR();
        Assert.AreEqual(codigoQR,actual);
    }
    [Test]
    public void TestGetNombre()
    {
        string actual = planta.getNombre();
        Assert.AreEqual(nombre,actual);
    }
    [Test]
    public void TestGetDescripcion()
    {
        string actual = planta.getDescripcion();
        Assert.AreEqual(descripcion,actual);
    }
    [Test]
    public void TestGetUsosMedicinales()
    {
        string actual = planta.getUsosMedicinales();
        Assert.AreEqual(usosMedicinales,actual);
    }
    [Test]
    public void TestGetEstadio()
    {
        int actual = planta.getEstadio();
        Assert.AreEqual(estadio,actual);
    }
    [Test]
    public void TestGetNombreCientifico()
    {
        string actual = planta.getNombreCientifico();
        Assert.AreEqual(nombreCientifico,actual);
    }
    [Test]
    public void TestSetQR()
    {
        string actual = "67";
        planta.setCodigoQR(actual);
        Assert.AreEqual(actual,planta.getCodigoQR());
    }
    [Test]
    public void TestSetNombre()
    {
        string actual = "68";
        planta.setNombre(actual);
        Assert.AreEqual(actual,planta.getNombre());
    }
    [Test]
    public void TestSetDescripcion()
    {
        string actual = "60";
        planta.setDescripcion(actual);
        Assert.AreEqual(actual,planta.getDescripcion());
    }
    [Test]
    public void TestSetUsosMedicinales()
    {
        string actual = "6";
        planta.setUsosMedicinales(actual);
        Assert.AreEqual(actual,planta.getUsosMedicinales());
    }
    [Test]
    public void TestSetEstadio()
    {
        int actual = 2;
        planta.setEstadio(actual);
        Assert.AreEqual(actual,planta.getEstadio());
    }
    [Test]
    public void TestSetNombreCientifico()
    {
        string actual = "61";
        planta.setNombreCientifico(actual);
        Assert.AreEqual(actual,planta.getNombreCientifico());
    }
    [Test]
    public void testInicializarNombre(){
        string actual = "Pera";
        planta.Inicializar(actual, nombreCientifico, descripcion, estadio, usosMedicinales, codigoQR);
        Assert.AreEqual(actual,planta.getNombre());
    }
    [Test]
    public void testInicializarNombreCientifico(){
        string actual = "Peraus";
        planta.Inicializar(nombre, actual, descripcion, estadio, usosMedicinales, codigoQR);
        Assert.AreEqual(actual,planta.getNombreCientifico());
    }
    [Test]
    public void testInicializarDescripcion(){
        string actual = "Peraus";
        planta.Inicializar(nombre, nombreCientifico, actual, estadio, usosMedicinales, codigoQR);
        Assert.AreEqual(actual,planta.getDescripcion());
    }
    [Test]
    public void testInicializarEstadio(){
        int actual = 1;
        planta.Inicializar(nombre, nombreCientifico, descripcion, actual, usosMedicinales, codigoQR);
        Assert.AreEqual(actual,planta.getEstadio());
    }
    [Test]
    public void testInicializarUsosMedicinales(){
        string actual = "Peraus";
        planta.Inicializar(nombre, nombreCientifico, descripcion, estadio, actual, codigoQR);
        Assert.AreEqual(actual,planta.getUsosMedicinales());
    }
    [Test]
    public void testInicializarCodigoQR(){
        string actual = "Peraus";
        planta.Inicializar(nombre, nombreCientifico, descripcion, estadio, usosMedicinales, actual);
        Assert.AreEqual(actual,planta.getCodigoQR());
    }
}
