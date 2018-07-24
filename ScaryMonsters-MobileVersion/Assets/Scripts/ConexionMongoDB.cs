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
	
	string msj = "Conexion Establecida con éxito";
	string stringConexion = "mongodb://admin:a12345@ds147451.mlab.com:47451/scary-monsters";
	public Text contenedorMsj;
    void Start()
	{
		MongoClient client = new MongoClient (stringConexion);
		var db = client.GetServer ();
		var bd = db.GetDatabase ("scary-monsters");
		var jugadores = bd.GetCollection ("jugadores");

		if (jugadores == null) {
			contenedorMsj.text = "NOOOOOOOOOOOO";
		} else {
			contenedorMsj.text = msj;
		}

	}
}
