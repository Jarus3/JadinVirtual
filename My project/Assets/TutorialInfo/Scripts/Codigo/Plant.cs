using SQLite4Unity3d;
public class Plant{
    [PrimaryKey, AutoIncrement]
	public int id { get; set; }
	public string nombre { get; set; }
	public string nombreCientifico { get; set; }
	public int estadio { get; set; }
    public string usosMedicinales { get; set; }
    public string codigoQR { get; set; }
    public string descripcion { get; set; }
    public string fechaEscaneo { get; set; }

	public override string ToString ()
	{
		return string.Format ("[Planta: Id={0}, Nombre={1}, NombreCientifico={2}, Estadio={3}, UsosMedicinales={4}, CodigoQR={5}, Descripcion={6}, FechaEscaneo={7}]",
         id, nombre, nombreCientifico, estadio, usosMedicinales, codigoQR, descripcion, fechaEscaneo);
	}
}