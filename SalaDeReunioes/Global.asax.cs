using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using MongoDB.Driver;
using MongoDB.Bson;
using System.IO;
using System.Data;

namespace SalaDeReunioes
{
    public class Global : System.Web.HttpApplication
    {
        
       

        protected void Application_Start(object sender, EventArgs e)
        {
            //Dia dia = new Dia();
            //dia.CriarTabelas();

                int count = 0;

            string connectionString = "mongodb://localhost:27017";
        
       // MongoClient client = new MongoClient(connectionString);
      //  IMongoDatabase db = client.GetDatabase("SalaDeReunioes");
          

           /* System.IO.StreamWriter file =new System.IO.StreamWriter(@"C:\Horarios.txt");
                
                foreach (Dia d in listaDias) {
                

                 file.WriteLine(d.dia + "/" + d.hora + "/" + d.disponibilidade + "/" + d.pessoa); 
                  }
            
            file.Close();*/




        } 

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}