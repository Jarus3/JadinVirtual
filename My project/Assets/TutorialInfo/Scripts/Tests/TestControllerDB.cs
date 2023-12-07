using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestControllerDB
{
    // A Test behaves as an ordinary method
    ControllerDB db = new ControllerDB();
    [Test]
    public void TestIniciar()
    {
        // Use the Assert class to test conditions
        Assert.AreEqual(db.dbName, "URI=file:DataBase.db");
    }
}
