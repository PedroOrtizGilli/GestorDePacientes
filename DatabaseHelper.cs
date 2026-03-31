using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.Sqlite;
using System.IO;

namespace GestorDePaciente
{
    internal class DatabaseHelper
    {
        private static string carpetaDatos = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "GestorDePaciente"
        );

        private static string dbPath = Path.Combine(carpetaDatos, "GestorPacientes.db");
        private static string connectionString = $"Data Source={dbPath}";

        public static void InicializarBaseDatos()
        {
            Directory.CreateDirectory(carpetaDatos);
            if (!File.Exists(dbPath))
            {
                CrearTablas();
            }
        }

        //Crear las tablas
        private static void CrearTablas()
        {
            using (var conn = new SqliteConnection(connectionString))
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
                            Descripcion TEXT
                    )";

                string crearRecetas = @"
                        CREATE TABLE IF NOT EXISTS Recetas (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            PacienteId INTEGER NOT NULL,
                            NombreArchivo TEXT NOT NULL,
                            RutaArchivo TEXT NOT NULL,
                            FechaEmision DATE,
                            Descripcion TEXT,
                            FOREIGN KEY (PacienteId) REFERENCES Pacientes(Id)
                    )";

                //Ejecutar SQL para Pacientes y Recetas
                using (var cmd = new SqliteCommand(crearPacientes, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = new SqliteCommand(crearRecetas, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        
        //Auxiliar para obtener conexion
        public static SqliteConnection ObtenerConexion()
        {
            return new SqliteConnection(connectionString);
        }
    }
}
