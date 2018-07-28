using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Options;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver.Core.Authentication.Sspi;
using MongoDB.Driver.Core.Bindings;
using MongoDB.Driver.Core.Clusters.ServerSelectors;
using MongoDB.Driver.Core.Configuration;
using MongoDB.Driver.Core.ConnectionPools;
using MongoDB.Driver.Core.Connections;
using MongoDB.Driver.Core.Events.Diagnostics;
using MongoDB.Driver.Core.Misc;
using MongoDB.Driver.Core.Operations.ElementNameValidators;
using MongoDB.Driver.Core.Servers;
using MongoDB.Driver.Core.WireProtocol.Messages.Encoders.BinaryEncoders;
using MongoDB.Driver.Core.WireProtocol.Messages.Encoders.JsonEncoders;
using MongoDB.Driver.Linq;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace SalaDeReunioes
{
    public class Dia
    {
        public ObjectId Id { get; set; }
        public string dia { get; set; }
        public string hora { get; set; }
        public string disponibilidade { get; set; }
        public string pessoa { get; set; }


                public void CriarTabelas()
                 {
            
             string connectionString = "mongodb://localhost:27017";
            var cliente = new MongoServer
           // MongoClient client = new MongoClient(connectionString);
           // IMongoDatabase db = client.GetDatabase("SalaDeReunioes");
          //  var collection = db.GetCollection<Dia>("Dias");
            var entity = new Dia()
            {
                dia = "Fulano",
                hora = "hora",
                disponibilidade = "dispo",
                pessoa = "pesso"
            };
           // collection.InsertOne(entity);
            //var id = entity.Id;


            
            /*List<Dia> lista = new List<Dia>();
            
            db.CreateCollection(name: "ListaDeHorarios");
            db.GetCollection<Dia>("ListaDeHorarios");
            Dia a = new Dia();

            for (int d = 1; d <31; d++)
            {
                for (int i = 8; i < 18; i++)
                {
                    if (d < 10)
                    {
                        a.dia = "0" + d.ToString() + "07";
                    }
                    else
                    {
                        a.dia = d.ToString() + "/07";
                    }
                    a.hora = i.ToString() + "-" + (i + 1).ToString() + "h";
                    a.disponibilidade = "livre";
                    a.pessoa = "-";

                    lista.Add(a);
                    */
                }
                public void Coletar()
        {
          /*  string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            IMongoDatabase db = client.GetDatabase("SalaDeReunioes");
            var collection = db.GetCollection<Dia>("Dias");
            var query = Queryable<Dia>.Equals(e => e.Id, Id);
            var entity = collection.Find<Dia>(query);
        }
                
            }

            //horarios.InsertMany(lista);
        
        }
    
