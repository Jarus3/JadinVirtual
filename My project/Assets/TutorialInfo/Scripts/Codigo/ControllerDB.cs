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
        
    }

    public void CreateTable()
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
    public void llenarDatos(){
        // llenarDatosPlanta('Coca', 'Erythroxylum coca', 'Planta de la familia de las liliáceas, de hojas carnosas, lanceoladas, con espinas en los bordes, flores amarillas y fruto capsular, que se cría en las regiones cálidas y se usa en medicina y en cosmética.', '0', 'En la medicina tradicional andina y amazónica como: analgésico gástrico y anorexígeno, contra el dolor de las hemorragias menstruales, contra picaduras de arácnidos e insectos, carminativo, antidiarreico, contra el mal de altura o soroche, contra el cansancio', '1');
        // llenarDatosPlanta('Cantuta tricolor', 'Cantua buxifolia', 'Planta perenne muy ramificada y de aspecto muy vistoso que mide entre 2 y 3 m de alto. Sus pequeñas hojas son ásperas, alternas y tienen forma lanceolada-elípticas. Sus flores no tienen olor, crecen en racimos terminales, con corona tubular, cáliz corto y colores muy llamativos, generalmente blanco, amarillo, rosado y rojo intenso.', '0', 'Es una planta ornamental que se cultiva por sus flores coloridas. También tiene propiedades medicinales como antiinflamatorio, cicatrizante y antiespasmódico.', '2');
        // llenarDatosPlanta('Durazno', 'Prunus persica', 'Árbol caducifolio encorvado y muy ramificado con tallos que alcanza los 8 m. De hojas lanceoladas alternas bordes dentados tiene abundantes flores axilares de tonalidades rosáceas o blancas. Su fruto es una drupa carnosa de agradable sabor y aroma.', '0', 'Es un árbol frutal que produce duraznos dulces y jugosos. También tiene usos medicinales como diurético laxante antiinflamatorio antidiabético antiviral antibacteriano antifúngico.', '3');
        // llenarDatosPlanta('Uri uri', 'Arctostaphylos uva-ursi', 'Planta arbustiva o pequeña árbolada con hojas compuestas por folíolos ovalados dentados. Sus flores son pequeñas blancas o rosadas agrupadas en espigas terminales. Su fruto es una cápsula leñosa con semillas aladas.', '0', 'Es una planta medicinal que se usa como astringente antiséptico antiinflamatorio digestivo hepático diurético depurativo laxante antiespasmódico antitumoral.', '4');
        // llenarDatosPlanta('Sewenqa','Cortaderia jubata','Es una especie de gramínea conocida por varios nombres comunes, incluidos hierba de la pampa de los Andes y plumeros. Es similar a su pariente ampliamente difundido, el plumero de las pampas Cortaderia selloana, pero puede desarrollarse más alto, llegando a medir hasta siete metros de alto.','0','Tiene varios usos medicinales, como antiinflamatorio, cicatrizante, antiespasmódico y digestivo. También se usa como forraje para el ganado y como abono orgánico para los cultivos.','123456789');
        
        Query("INSERT INTO planta (nombre,nombreCientifico,descripcion,estadio,usosMedicinales,codigoQR,fecha_escaneo) VALUES ('Coca', 'Erythroxylum coca', 'Planta de la familia de las liliáceas, de hojas carnosas, lanceoladas, con espinas en los bordes, flores amarillas y fruto capsular, que se cría en las regiones cálidas y se usa en medicina y en cosmética.', '0', 'En la medicina tradicional andina y amazónica como: analgésico gástrico y anorexígeno, contra el dolor de las hemorragias menstruales, contra picaduras de arácnidos e insectos, carminativo, antidiarreico, contra el mal de altura o soroche, contra el cansancio', 'Coca','2023-12-18');");
        Query("INSERT INTO planta (nombre,nombreCientifico,descripcion,estadio,usosMedicinales,codigoQR,fecha_escaneo) VALUES ('Cantuta tricolor', 'Cantua buxifolia', 'Planta perenne muy ramificada y de aspecto muy vistoso que mide entre 2 y 3 m de alto. Sus pequeñas hojas son ásperas, alternas y tienen forma lanceolada-elípticas. Sus flores no tienen olor, crecen en racimos terminales, con corona tubular, cáliz corto y colores muy llamativos, generalmente blanco, amarillo, rosado y rojo intenso.', '0', 'Es una planta ornamental que se cultiva por sus flores coloridas. También tiene propiedades medicinales como antiinflamatorio, cicatrizante y antiespasmódico.', 'Kantuta','2023-12-18');");
        Query("INSERT INTO planta (nombre,nombreCientifico,descripcion,estadio,usosMedicinales,codigoQR,fecha_escaneo) VALUES ('Sewenka', 'Prunus persica', 'Árbol caducifolio encorvado y muy ramificado con tallos que alcanza los 8 m. De hojas lanceoladas alternas bordes dentados tiene abundantes flores axilares de tonalidades rosáceas o blancas. Su fruto es una drupa carnosa de agradable sabor y aroma.', '0', 'Es un árbol frutal que produce duraznos dulces y jugosos. También tiene usos medicinales como diurético laxante antiinflamatorio antidiabético antiviral antibacteriano antifúngico.', 'Sewenka','2023-12-18');");
        Query("INSERT INTO planta (nombre,nombreCientifico,descripcion,estadio,usosMedicinales,codigoQR,fecha_escaneo) VALUES ('Uri uri', 'Arctostaphylos uva-ursi', 'Planta arbustiva o pequeña árbolada con hojas compuestas por folíolos ovalados dentados. Sus flores son pequeñas blancas o rosadas agrupadas en espigas terminales. Su fruto es una cápsula leñosa con semillas aladas.', '0', 'Es una planta medicinal que se usa como astringente antiséptico antiinflamatorio digestivo hepático diurético depurativo laxante antiespasmódico antitumoral.', 'Uri Uri','2023-12-18');");
        Query("INSERT INTO planta (nombre,nombreCientifico,descripcion,estadio,usosMedicinales,codigoQR,fecha_escaneo) VALUES ('Durazno','Cortaderia jubata','Es una especie de gramínea conocida por varios nombres comunes, incluidos hierba de la pampa de los Andes y plumeros. Es similar a su pariente ampliamente difundido, el plumero de las pampas Cortaderia selloana, pero puede desarrollarse más alto, llegando a medir hasta siete metros de alto.','0','Tiene varios usos medicinales, como antiinflamatorio, cicatrizante, antiespasmódico y digestivo. También se usa como forraje para el ganado y como abono orgánico para los cultivos.','Durazno','2023-12-18');");
    }
    public void llenarDatosUsuario(string nombre){
        string aux = "INSERT INTO usuario (nombre) VALUES ('"+nombre+"');";
        Query(aux);
    }
    public void llenarDatosPlanta(string nombre,string nombreCientifico,string descripcion,int estadio,string usosMedicinales,string codigoQR){
        string aux = "INSERT INTO planta (nombre,nombreCientifico,descripcion,estadio,usosMedicinales,codigoQR) VALUES ('"+nombre+"','"+nombreCientifico+"','"+descripcion+"','"+estadio+"','"+usosMedicinales+"','"+codigoQR+"');";
        Query(aux);
    }
    public Planta getInformacionPlanta(string nombre){
        string aux = "SELECT * FROM planta WHERE nombre = '"+nombre+"';";
        GameObject plantaObj = new GameObject("Planta");
        Planta aux2=plantaObj.AddComponent<Planta>();;
        using (var connection = new SqliteConnection(dbName))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = aux;
                using (IDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        aux2.Inicializar(reader["nombre"].ToString(),reader["nombreCientifico"].ToString(),reader["descripcion"].ToString(),int.Parse(reader["estadio"].ToString()),reader["usosMedicinales"].ToString(),reader["codigoQR"].ToString());
                    }
                }
            }

            connection.Close();
        }
        return aux2;
    }

    public int getEstadio(string codigoQR){
        string aux = "SELECT estadio FROM planta WHERE codigoQR = '"+codigoQR+"';";
        int estadio = 0;
        using (var connection = new SqliteConnection(dbName))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = aux;
                using (IDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        estadio = int.Parse(reader["estadio"].ToString());
                    }
                }
            }

            connection.Close();
        }
        return estadio;
    }

    public string getFecha(string codigoQR){
        string aux = "SELECT fecha_escaneo FROM planta WHERE codigoQR = '"+codigoQR+"';";
        string fecha = "";
        using (var connection = new SqliteConnection(dbName))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = aux;
                using (IDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        fecha = reader["fecha_escaneo"].ToString();
                    }
                }
            }

            connection.Close();
        }
        return fecha;
    }
}

