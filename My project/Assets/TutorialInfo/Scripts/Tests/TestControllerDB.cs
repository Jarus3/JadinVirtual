using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestControllerDB
{
    // A Test behaves as an ordinary method
    ControllerDB db;
    GameObject dbObj = new GameObject("ControllerDB");
    [SetUp]
    public void SetUp()
    {
        dbObj.AddComponent<ControllerDB>();
        db = dbObj.GetComponent<ControllerDB>();
    }
    [Test]
    public void TestIniciar()
    {
        // Use the Assert class to test conditions
        Assert.AreEqual(db.dbName, "URI=file:DataBase.db");
    }
    [Test]
    public void TestAddPlanta(){
        string nombre = "Fresa";
        string nombreCientifico = "Ella es una fresa";
        string descripcion = "Planta de la familia de las liliáceas, de hojas carnosas, lanceoladas, con espinas en los bordes, flores amarillas y fruto capsular, que se cría en las regiones cálidas y se usa en medicina y en cosmética.";
        int estadio = 1;
        string usosMedicinales = "Es una planta que se utiliza para la piel";
        string codigoQR = "123456789";
        db.llenarDatosPlanta(nombre,nombreCientifico,descripcion,estadio,usosMedicinales,codigoQR);
        Planta planta;
        planta = db.getInformacionPlanta(nombre); 
        Assert.NotNull(planta.getNombre());
    }
    [Test]
    public void TestGetInformacionPlanta(){
        string nombre = "Aloe Vera";
        string nombreCientifico = "Aloe Vera";
        string descripcion = "Planta de la familia de las liliáceas, de hojas carnosas, lanceoladas, con espinas en los bordes, flores amarillas y fruto capsular, que se cría en las regiones cálidas y se usa en medicina y en cosmética.";
        int estadio = 1;
        string usosMedicinales = "Es una planta que se utiliza para la piel";
        string codigoQR = "123456789";
        db.llenarDatosPlanta(nombre,nombreCientifico,descripcion,estadio,usosMedicinales,codigoQR);
        Planta planta;
        planta = db.getInformacionPlanta(nombre); 
        Assert.AreEqual(planta.getNombre(), nombre);
        Assert.AreEqual(planta.getNombreCientifico(), nombreCientifico);
        Assert.AreEqual(planta.getDescripcion(), descripcion);
        Assert.AreEqual(planta.getEstadio(), estadio);
        Assert.AreEqual(planta.getUsosMedicinales(), usosMedicinales);
        Assert.AreEqual(planta.getCodigoQR(), codigoQR);
    }

    // [Test]
    // public void TestGetEstadio{
    //     int estadio = 0;
    //     int estadioCoca = db.getEstadio("Coca");
    //     Assert.AreEqual(estadio,estadioCoca);
    // }
    // public void TestAddUsuario(){
    //     string nombre = "Jarus";
    //     db.llenarDatosUsuario(nombre);
    //     string query = "SELECT * FROM usuario WHERE nombre = 'Jarus'";
    //     db.Query(query);
    //     Assert.AreEqual(db.reader.GetString(1), nombre);
    // }
}
