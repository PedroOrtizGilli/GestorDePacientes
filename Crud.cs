using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using System.Text;

namespace GestorDePaciente
{
    internal class Crud
    {
        public class Paciente
        {
            public int Id { get; set; }
            public string Nombre { get; set; } 
            public string DNI { get; set; } 
            public string? ObraSocial { get; set; }
            public string? Mail { get; set; }
            public string? Telefono { get; set; }
            public int Edad { get; set; }
            public string? Descripcion { get; set; }

        }

        public class Receta
        {
            public int Id { get; set; }
            public int PacienteId { get; set; }
            public string NombreArchivo { get; set; }
            public string RutaArchivo { get; set; }
            public DateTime? FechaEmision { get; set; }
            public string? Descripcion { get; set; }

        }

        public class PacienteDAO
        {

            public static int Insertar(Paciente paciente)
            {
                using (var conn = DatabaseHelper.ObtenerConexion())
                {
                    conn.Open();

                    string query = @"INSERT INTO Pacientes (Nombre, DNI, ObraSocial, Mail, Telefono, Edad, Descripcion)
                                    VALUES
                                    (@Nombre, @DNI, @ObraSocial, @Mail, @Telefono, @Edad, @Descripcion);
                                    SELECT last_insert_rowid();";

                    using (var cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", paciente.Nombre);
                        cmd.Parameters.AddWithValue("@DNI", paciente.DNI ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@ObraSocial", paciente.ObraSocial ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Mail", paciente.Mail ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Telefono", paciente.Telefono ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Edad", paciente.Edad);
                        cmd.Parameters.AddWithValue("@Descripcion", paciente.Descripcion ?? (object)DBNull.Value);

                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }

            public static List<Paciente> ObtenerTodos()
            {
                var pacientes = new List<Paciente>();

                using (var conn = DatabaseHelper.ObtenerConexion())
                {
                    conn.Open();

                    string query = "SELECT * FROM Pacientes ORDER BY Id";

                    using (var cmd = new SqliteCommand(query, conn))
                    using (var lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            pacientes.Add(new Paciente
                            {
                                Id = Convert.ToInt32(lector["Id"]),
                                Nombre = lector["Nombre"].ToString(),
                                DNI = lector["DNI"] != DBNull.Value ? lector["DNI"].ToString() : null,
                                ObraSocial = lector["ObraSocial"] != DBNull.Value ? lector["ObraSocial"].ToString() : null,
                                Mail = lector["Mail"] != DBNull.Value ? lector["Mail"].ToString() : null,
                                Telefono = lector["Telefono"] != DBNull.Value ? lector["Telefono"].ToString() : null,
                                Edad = Convert.ToInt32(lector["Edad"]),
                                Descripcion = lector["Descripcion"] != DBNull.Value ? lector["Descripcion"].ToString() : null
                            });
                        }
                    }
                }

                return pacientes;
            }

            public static Paciente ObtenerPorId(int id)
            {
                using (var conn = DatabaseHelper.ObtenerConexion())
                {
                    conn.Open();

                    string query = "SELECT * FROM Pacientes WHERE Id = @Id";

                    using (var cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);

                        using (var lector = cmd.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new Paciente
                                {
                                    Id = Convert.ToInt32(lector["Id"]),
                                    Nombre = lector["Nombre"].ToString(),
                                    DNI = lector["DNI"] != DBNull.Value ? lector["DNI"].ToString() : null,
                                    ObraSocial = lector["ObraSocial"] != DBNull.Value ? lector["ObraSocial"].ToString() : null,
                                    Mail = lector["Mail"] != DBNull.Value ? lector["Mail"].ToString() : null,
                                    Telefono = lector["Telefono"] != DBNull.Value ? lector["Telefono"].ToString() : null,
                                    Edad = Convert.ToInt32(lector["Edad"]),
                                    Descripcion = lector["Descripcion"] != DBNull.Value ? lector["Descripcion"].ToString() : null
                                };
                            }
                        }
                    }
                }

                return null;
            }

            public static List<Paciente> Buscar(string termino)
            {
                var pacientes = new List<Paciente>();

                using (var conn = DatabaseHelper.ObtenerConexion())
                {
                    conn.Open();

                    string query = @"SELECT * FROM Pacientes
                                    WHERE Nombre LIKE @Termino OR DNI LIKE @Termino
                                    ORDER BY Id";

                    using (var cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Termino", "%" + termino + "%");

                        using (var lector = cmd.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                pacientes.Add(new Paciente
                                {
                                    Id = Convert.ToInt32(lector["Id"]),
                                    Nombre = lector["Nombre"].ToString(),
                                    DNI = lector["DNI"] != DBNull.Value ? lector["DNI"].ToString() : null,
                                    ObraSocial = lector["ObraSocial"] != DBNull.Value ? lector["ObraSocial"].ToString() : null,
                                    Mail = lector["Mail"] != DBNull.Value ? lector["Mail"].ToString() : null,
                                    Telefono = lector["Telefono"] != DBNull.Value ? lector["Telefono"].ToString() : null,
                                    Edad = Convert.ToInt32(lector["Edad"]),
                                    Descripcion = lector["Descripcion"] != DBNull.Value ? lector["Descripcion"].ToString() : null
                                });
                            }
                        }
                    }

                }
                return pacientes;
            }

            public static bool Actualizar(Paciente paciente)
            {
                using (var conn = DatabaseHelper.ObtenerConexion())
                {
                    conn.Open();

                    string query = @"UPDATE Pacientes
                                   SET Nombre = @Nombre,
                                       DNI = @DNI,
                                       ObraSocial = @ObraSocial,
                                       Mail = @Mail,
                                       Telefono = @Telefono,
                                       Edad = @Edad,
                                       Descripcion = @Descripcion
                                   WHERE Id = @Id";
                                   
                    using (var cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", paciente.Id);
                        cmd.Parameters.AddWithValue("@Nombre", paciente.Nombre);
                        cmd.Parameters.AddWithValue("@DNI", paciente.DNI);
                        cmd.Parameters.AddWithValue("@ObraSocial", paciente.ObraSocial);
                        cmd.Parameters.AddWithValue("@Mail", paciente.Mail);
                        cmd.Parameters.AddWithValue("@Telefono", paciente.Telefono);
                        cmd.Parameters.AddWithValue("@Edad", paciente.Edad);
                        cmd.Parameters.AddWithValue("@Descripcion", paciente.Descripcion);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }

            public static bool Eliminar(int id)
            {
                using (var conn = DatabaseHelper.ObtenerConexion())
                {
                    conn.Open();

                    string deleteRecetas = "DELETE FROM Recetas WHERE PacienteId = @Id";

                    using (var cmd = new SqliteCommand(deleteRecetas, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                    }

                    string deletePaciente = "DELETE FROM Pacientes WHERE Id = @Id";

                    using (var cmd = new SqliteCommand(deletePaciente, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
        }

        public class RecetaDAO
        {
            private static string carpetaRecetas = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Recetas");

            public static int Insertar(Receta receta, string archivoOrigen)
            {
                try
                {
                    string carpetaPaciente = System.IO.Path.Combine(carpetaRecetas, $"Paciente_{receta.PacienteId:D4}");
                    System.IO.Directory.CreateDirectory(carpetaPaciente);

                    string extension = System.IO.Path.GetExtension(archivoOrigen);
                    string nombreArchivo = $"receta_{DateTime.Now:yyyyMMdd_HHmmss}{extension}";
                    string rutaDestino = System.IO.Path.Combine(carpetaPaciente, nombreArchivo);

                    System.IO.File.Copy(archivoOrigen, rutaDestino, true);

                    string rutaRelativa = System.IO.Path.Combine("Recetas", $"Paciente_{receta.PacienteId:D4}", nombreArchivo);

                    using (var conn = DatabaseHelper.ObtenerConexion())
                    {
                        conn.Open();

                        string query = @"INSERT INTO Recetas (PacienteId, NombreArchivo, RutaArchivo, FechaEmision, Descripcion)
                                VALUES (@PacienteId, @NombreArchivo, @RutaArchivo, @FechaEmision, @Descripcion);
                                SELECT last_insert_rowid();";

                        using (var cmd = new SqliteCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@PacienteId", receta.PacienteId);
                            cmd.Parameters.AddWithValue("@NombreArchivo", nombreArchivo);
                            cmd.Parameters.AddWithValue("@RutaArchivo", rutaRelativa);
                            cmd.Parameters.AddWithValue("@FechaEmision", receta.FechaEmision?.ToString("yyyy-MM-dd") ?? DateTime.Now.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@Descripcion", receta.Descripcion ?? (object)DBNull.Value);

                            return Convert.ToInt32(cmd.ExecuteScalar());
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show($"Error en RecetaDAO.Insertar:\n{ex.Message}\n\n{ex.StackTrace}", "Error");
                    throw;
                }
            }

            public static List<Receta> ObtenerPorPaciente(int pacienteId)
            {
                var recetas = new List<Receta>();

                using (var conn = DatabaseHelper.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT * FROM Recetas WHERE PacienteId = @PacienteId ORDER BY FechaEmision DESC";

                    using (var cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PacienteId", pacienteId);

                        using (var lector = cmd.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                recetas.Add(new Receta
                                {
                                    Id = Convert.ToInt32(lector["Id"]),
                                    PacienteId = Convert.ToInt32(lector["PacienteId"]),
                                    NombreArchivo = lector["NombreArchivo"].ToString(),
                                    RutaArchivo = lector["RutaArchivo"].ToString(),
                                    FechaEmision = lector["FechaEmision"] != DBNull.Value
                                                  ? DateTime.Parse(lector["FechaEmision"].ToString())
                                                  : (DateTime?)null,
                                    Descripcion = lector["Descripcion"] != DBNull.Value ? lector["Descripcion"].ToString() : null
                                });
                            }
                        }
                    }
                }
                return recetas;
            }

            public static Receta ObtenerPorId(int recetaId)
            {
                using (var conn = DatabaseHelper.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT * FROM Recetas WHERE Id = @Id";

                    using (var cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", recetaId);

                        using (var lector = cmd.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new Receta
                                {
                                    Id = Convert.ToInt32(lector["Id"]),
                                    PacienteId = Convert.ToInt32(lector["PacienteId"]),
                                    NombreArchivo = lector["NombreArchivo"].ToString(),
                                    RutaArchivo = lector["RutaArchivo"].ToString(),
                                    FechaEmision = lector["FechaEmision"] != DBNull.Value
                                                  ? DateTime.Parse(lector["FechaEmision"].ToString())
                                                  : (DateTime?)null,
                                    Descripcion = lector["Descripcion"] != DBNull.Value ? lector["Descripcion"].ToString() : null
                                };
                            }
                        }
                    }
                }
                return null;
            }

            public static bool Eliminar(int recetaId)
            {
                try
                {
                    var receta = ObtenerPorId(recetaId);

                    if (receta == null)
                    {
                        System.Windows.Forms.MessageBox.Show("Receta no encontrada", "Error");
                        return false;
                    }

                    string rutaCompleta = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, receta.RutaArchivo);

                    if (System.IO.File.Exists(rutaCompleta))
                    {
                        System.IO.File.Delete(rutaCompleta);
                    }

                    using (var conn = DatabaseHelper.ObtenerConexion())
                    {
                        conn.Open();
                        string query = "DELETE FROM Recetas WHERE Id = @Id";

                        using (var cmd = new SqliteCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Id", recetaId);
                            return cmd.ExecuteNonQuery() > 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show($"Error al eliminar receta:\n{ex.Message}", "Error");
                    return false;
                }
            }

            public static void AbrirArchivo(int recetaId)
            {
                try
                {
                    var receta = ObtenerPorId(recetaId);

                    if (receta == null)
                    {
                        System.Windows.Forms.MessageBox.Show("Receta no encontrada", "Error");
                        return;
                    }

                    string rutaCompleta = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, receta.RutaArchivo);

                    if (!System.IO.File.Exists(rutaCompleta))
                    {
                        System.Windows.Forms.MessageBox.Show($"El archivo no existe:\n{rutaCompleta}", "Error");
                        return;
                    }

                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = rutaCompleta,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show($"Error al abrir archivo:\n{ex.Message}", "Error");
                }
            }
        }
    }
}
