using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

public class TestEscena
{

    [UnityTest]
    public IEnumerator TestEscenaJardin()
    {
        SceneManager.LoadScene("Jardin");
        yield return null;
        Assert.AreEqual("Jardin", SceneManager.GetActiveScene().name);
    }
    [UnityTest]
    public IEnumerator TestEscenaMenu()
    {
        SceneManager.LoadScene("Menu");
        yield return null;
        Assert.AreEqual("Menu", SceneManager.GetActiveScene().name);
    }

    [UnityTest]
    public IEnumerator TestEscenaQR()
    {
        SceneManager.LoadScene("QR");
        yield return null;
        Assert.AreEqual("QR", SceneManager.GetActiveScene().name);
    }

    [UnityTest]
    public IEnumerator TestEscenaInicio()
    {
        SceneManager.LoadScene("Inicio");
        yield return null;
        Assert.AreEqual("Inicio", SceneManager.GetActiveScene().name);
    }

    [UnityTest]
    public IEnumerator TestEscenaVision()
    {
        SceneManager.LoadScene("Vision");
        yield return null;
        Assert.AreEqual("Vision", SceneManager.GetActiveScene().name);
    }
}
