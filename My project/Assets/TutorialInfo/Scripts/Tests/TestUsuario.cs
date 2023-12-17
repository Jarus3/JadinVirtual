using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestUsuario
{
    Usuario user;
    [SetUp]
    public void SetUp()
    {
        GameObject usuario = new GameObject();
        usuario.AddComponent<Usuario>();
        user = usuario.GetComponent<Usuario>();
    }
    // A Test behaves as an ordinary method
    [Test]
    public void testSetNombre()
    {
        string aux="Player";
        user.setNombre(aux);
        Assert.AreEqual(aux, user.getNombre());
    }
    [Test]
    public void testGetNombre()
    {
        string aux="Jarus";
        user.setNombre(aux);
        Assert.AreEqual(aux, user.getNombre());
    }
    [Test]
    public void testInicializar()
    {
        string aux="Jarus";
        user.Inicializar(aux);
        Assert.AreEqual(aux, user.getNombre());
    }
}
