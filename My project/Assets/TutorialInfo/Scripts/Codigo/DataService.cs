using SQLite4Unity3d;
using UnityEngine;
#if !UNITY_EDITOR
using System.Collections;
using System.IO;
#endif
using System.Collections.Generic;

public class DataService  {

	private SQLiteConnection _connection;

	public DataService(string DatabaseName){

#if UNITY_EDITOR
            var dbPath = string.Format(@"Assets/StreamingAssets/{0}", DatabaseName);
#else
        // check if file exists in Application.persistentDataPath
        var filepath = string.Format("{0}/{1}", Application.persistentDataPath, DatabaseName);

        if (!File.Exists(filepath))
        {
            Debug.Log("Database not in Persistent path");
            // if it doesn't ->
            // open StreamingAssets directory and load the db ->

#if UNITY_ANDROID 
            var loadDb = new WWW("jar:file://" + Application.dataPath + "!/assets/" + DatabaseName);  // this is the path to your StreamingAssets in android
            while (!loadDb.isDone) { }  // CAREFUL here, for safety reasons you shouldn't let this while loop unattended, place a timer and error check
            // then save to Application.persistentDataPath
            File.WriteAllBytes(filepath, loadDb.bytes);
#elif UNITY_IOS
                 var loadDb = Application.dataPath + "/Raw/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
                // then save to Application.persistentDataPath
                File.Copy(loadDb, filepath);
#elif UNITY_WP8
                var loadDb = Application.dataPath + "/StreamingAssets/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
                // then save to Application.persistentDataPath
                File.Copy(loadDb, filepath);

#elif UNITY_WINRT
		var loadDb = Application.dataPath + "/StreamingAssets/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
		// then save to Application.persistentDataPath
		File.Copy(loadDb, filepath);
		
#elif UNITY_STANDALONE_OSX
		var loadDb = Application.dataPath + "/Resources/Data/StreamingAssets/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
		// then save to Application.persistentDataPath
		File.Copy(loadDb, filepath);
#else
	var loadDb = Application.dataPath + "/StreamingAssets/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
	// then save to Application.persistentDataPath
	File.Copy(loadDb, filepath);

#endif

            Debug.Log("Database written");
        }

        var dbPath = filepath;
#endif
            _connection = new SQLiteConnection(dbPath, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create);
        Debug.Log("Final PATH: " + dbPath);     

	}

	public void CreateDB(){
		_connection.DropTable<Plant> ();
		_connection.CreateTable<Plant> ();

		_connection.InsertAll (new[]{
			new Plant{
				id = 1,
				nombre = "Coca",
				nombreCientifico = "Erythroxylum coca",
				estadio = 0,
				usosMedicinales = "En la medicina tradicional andina y amazónica como: analgésico gástrico y anorexígeno, contra el dolor de las hemorragias menstruales, contra picaduras de arácnidos e insectos, carminativo, antidiarreico, contra el mal de altura o soroche, contra el cansancio",
				codigoQR = "Coca",
				descripcion = "Planta de la familia de las liliáceas, de hojas carnosas, lanceoladas, con espinas en los bordes, flores amarillas y fruto capsular, que se cría en las regiones cálidas y se usa en medicina y en cosmética.",
				fechaEscaneo = "2019-05-01"
			},
			new Plant{
				id = 2,
				nombre = "Kantuta",
				nombreCientifico = "Cantua buxifolia",
				estadio = 0,
				usosMedicinales = "En la medicina tradicional andina y amazónica como: analgésico gástrico y anorexígeno, contra el dolor de las hemorragias menstruales, contra picaduras de arácnidos e insectos, carminativo, antidiarreico, contra el mal de altura o soroche, contra el cansancio",
				codigoQR = "Kantuta",
				descripcion = "Planta de la familia de las liliáceas, de hojas carnosas, lanceoladas, con espinas en los bordes, flores amarillas y fruto capsular, que se cría en las regiones cálidas y se usa en medicina y en cosmética.",
				fechaEscaneo = "2019-05-01"
			},
			new Plant{
				id = 3,
				nombre = "Sewenka",
				nombreCientifico = "Cantua buxifolia",
				estadio = 0,
				usosMedicinales = "En la medicina tradicional andina y amazónica como: analgésico gástrico y anorexígeno, contra el dolor de las hemorragias menstruales, contra picaduras de arácnidos e insectos, carminativo, antidiarreico, contra el mal de altura o soroche, contra el cansancio",
				codigoQR = "Sewenka",
				descripcion = "Planta de la familia de las liliáceas, de hojas carnosas, lanceoladas, con espinas en los bordes, flores amarillas y fruto capsular, que se cría en las regiones cálidas y se usa en medicina y en cosmética.",
				fechaEscaneo = "2019-05-01"
			},
			new Plant{
				id = 4,
				nombre = "Durazno",
				nombreCientifico = "Cantua buxifolia",
				estadio = 0,
				usosMedicinales = "En la medicina tradicional andina y amazónica como: analgésico gástrico y anorexígeno, contra el dolor de las hemorragias menstruales, contra picaduras de arácnidos e insectos, carminativo, antidiarreico, contra el mal de altura o soroche, contra el cansancio",
				codigoQR = "Durazno",
				descripcion = "Planta de la familia de las liliáceas, de hojas carnosas, lanceoladas, con espinas en los bordes, flores amarillas y fruto capsular, que se cría en las regiones cálidas y se usa en medicina y en cosmética.",
				fechaEscaneo = "2019-05-01"
			},
			new Plant{
				id = 5,
				nombre = "Uri Uri",
				nombreCientifico = "Cantua buxifolia",
				estadio = 0,
				usosMedicinales = "En la medicina tradicional andina y amazónica como: analgésico gástrico y anorexígeno, contra el dolor de las hemorragias menstruales, contra picaduras de arácnidos e insectos, carminativo, antidiarreico, contra el mal de altura o soroche, contra el cansancio",
				codigoQR = "Uri Uri",
				descripcion = "Planta de la familia de las liliáceas, de hojas carnosas, lanceoladas, con espinas en los bordes, flores amarillas y fruto capsular, que se cría en las regiones cálidas y se usa en medicina y en cosmética.",
				fechaEscaneo = "2019-05-01"
			}
		});
	}

	public IEnumerable<Plant> GetPlants(){
		return _connection.Table<Plant>();
	}

	public Plant GetPlant(string nombre){
		return _connection.Table<Plant>().Where(x => x.nombre == nombre).FirstOrDefault();
	}
}
