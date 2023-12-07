using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;

public class ControllerDB : MonoBehaviour
{
    public static ControllerDB instance;
    public string dbName = "URI=file:DataBase.db";
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        CreateTable();
        Query("INSERT INTO usuario (nombre) VALUES ('Jarus');");
        Query("INSERT INTO planta (nombre,nombreCientifico,descripcion,estadio,usosMedicinales,codigoQR) VALUES ('Aloe Vera','Aloe Vera','Planta de la familia de las liliáceas, de hojas carnosas, lanceoladas, con espinas en los bordes, flores amarillas y fruto capsular, que se cría en las regiones cálidas y se usa en medicina y en cosmética.','1','Es una planta que se utiliza para la piel','123456789');");
    }

    private void CreateTable()
    {
        using (var connection = new SqliteConnection(dbName))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                string sqlcreation = "";


                sqlcreation += "CREATE TABLE IF NOT EXISTS planta(";
                sqlcreation += "id INTEGER PRIMARY KEY AUTOINCREMENT,";
                sqlcreation += "nombre     VARCHAR(50) NOT NULL,";
                sqlcreation += "nombreCientifico     VARCHAR(50) NOT NULL,";
                sqlcreation += "descripcion VARCHAR(500) NOT NULL,";
                sqlcreation += "estadio INTEGER NOT NULL,";
                sqlcreation += "usosMedicinales VARCHAR(500) NOT NULL,";
                sqlcreation += "codigoQR VARCHAR(50) NOT NULL";
                sqlcreation += ");";

                sqlcreation += "CREATE TABLE IF NOT EXISTS usuario(";
                sqlcreation += "id INTEGER PRIMARY KEY AUTOINCREMENT,";
                sqlcreation += "nombre     VARCHAR(50) NOT NULL";
                sqlcreation += ");";

                command.CommandText = sqlcreation;
                command.ExecuteNonQuery();
            }
        }
    }


    public void Query(string q)
    {
        using (var connection = new SqliteConnection(dbName))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = q;
                using (IDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Debug.Log("name: " + reader["name"] + " password: " + reader["password"]);

                    }
                }
            }

            connection.Close();
        }
    }
}

