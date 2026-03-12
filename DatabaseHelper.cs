using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.IO;

namespace GestorDePaciente
{
    internal class DatabaseHelper
    {
        //Ruta de la base de datos
        private static string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GestorPacientes.db");

        //String de conexion
        private static string connectionString = $"Data Source={dbPath};Version=3;";

        //Se ejecuta al iniciar la app
        public static void InicializarBaseDatos()
        {
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);

                CrearTablas();
            }
        }

        //Crear las tablas
        private static void CrearTablas()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string crearPacientes = @"
                        CREATE TABLE IF NOT EXISTS Pacientes (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Nombre TEXT NOT NULL ,
                            DNI TEXT UNIQUE,
                            ObraSocial TEXT,
                            Mail TEXT,
                            Telefono TEXT,
                            Edad INTEGER,
                            Descripccion TEXT
                    )";

                string crearRecetas = @"
                        CREATE TABLE IF NOT EXISTS Recetas (
                            Id INTEGER PRIMARY KEY AUTOINCCREMENT,
                            PacienteId INTEGER NOT NULL,
                            NombreArchivo TEXT NOT NULL,
                            RutaArchivo TEXT NOT NULL,
                            FechaEmision DATE,
                            Descripcion TEXT,
                            FOREIGN KEY (PacienteId) REFERENCES Pacientes(Id)
                    )";

                //Ejecutar SQL para Pacientes y Recetas
                using (var cmd = new SQLiteCommand(crearPacientes, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = new SQLiteCommand(crearRecetas, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        
        //Auxiliar para obtener conexion
        public static SQLiteConnection ObtenerConexion()
        {
            return new SQLiteConnection(connectionString);
        }
    }
}
