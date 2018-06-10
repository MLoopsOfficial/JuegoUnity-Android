using UnityEngine;
using System; 
using System.Collections;
using System.Collections.Generic;  

using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;

public class ConexionMongoDB : MonoBehaviour {

    
   string stringConexion = "mongodb://<moises>:<Dx9857*01>@ds161580.mlab.com:61580/scary-monstersbd";
    void Start()
    {
        /*
         * Establecer conexion local
        
        string stringConexion = "mongodb://<dbuser>:<dbpassword>@ds153890.mlab.com:53890/jugadores";
       
        var coleccionJugadores = database.GetCollection("vrshop");//Solo cuando uses la coleccion la pones xD
         */
        MongoClient client = new MongoClient(stringConexion);
        var server = client.GetServer();
        var bd = server.GetDatabase("scary-monstersbd");

        Debug.Log("Conexion Establecida con éxito");

    }

}
