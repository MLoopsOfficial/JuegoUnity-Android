using UnityEngine;
using System; 
using System.Collections;
using System.Collections.Generic;  
using UnityEngine.UI;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;

public class ConexionMongoDB : MonoBehaviour {
	[Header ("Parametros MongoDB")]
	string stringConexion = "mongodb://admin:a12345@ds147451.mlab.com:47451/scary-monsters";
	public Text contenedorMsj;

	[Header ("SourceTextBoxes")]
	public InputField campoNombre;
	public InputField campoPass;
	public ControladorPaisRegBandera pReg;
    void Start()
	{
		//Esto es para que este objeto jamas se destruya en un cambio de escena
		DontDestroyOnLoad(this.gameObject);
		//Conexion con Mongo DB Inicial
		conectarBD ();

	}
	//Conectar la BD
	void conectarBD()
	{
		MongoClient client = new MongoClient (stringConexion);
		var db = client.GetServer ();
		var bd = db.GetDatabase ("scary-monsters");
		var jugadores = bd.GetCollection ("jugadores");
		if (jugadores == null) {
			contenedorMsj.text = "Hubo un problema con el servidor\n verifica tu internet";
		} else {
			contenedorMsj.text = "Conexion Establecida con Exito";
		}
	}
	//Inserta un Registro
	public void insertarDoc()
	{
		MongoClient client = new MongoClient (stringConexion);
		var db = client.GetServer ();
		var bd = db.GetDatabase ("scary-monsters");
		var jugadores = bd.GetCollection ("jugadores");
		//Conversion de Text a String
		var nombreJugador = campoNombre.text.ToString();
		var passwordJugador = campoPass.text.ToString();
		var paisJugador = pReg.pais;

		//Insercion en MLab
		var jug = new BsonDocument {
			{ "posicion","0" },
			{ "jugador",nombreJugador},
			{ "password",passwordJugador},
			{ "pais",paisJugador },
			{ "puntiacion","0"}
		};
		jugadores.Insert (jug);
		campoNombre.text = "";
		campoPass.text = "";
	}
	//Funcion Buscar Todos
	public void buscarTodos()
	{
		MongoClient client = new MongoClient (stringConexion);
		var db = client.GetServer ();
		var bd = db.GetDatabase ("scary-monsters");
		var jugadores = bd.GetCollection ("jugadores");
		foreach (var document in jugadores.FindAll()) {
			Debug.Log ("Lista: \n" + document);
		}
	}
}
