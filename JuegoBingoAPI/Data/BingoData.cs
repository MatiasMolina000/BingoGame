﻿using JuegoBingoAPI.Connection;
using Dapper;
using System.Data.SqlClient;
using JuegoBingoAPI.Models;

namespace JuegoBingoAPI.Data
{
    public class BingoData
    {
        public ResponseModel NewGame(PartidaModel partida)
        {
            using (var cnn = new SqlConnection(new ConnectionDB().ConnectionStringSQL()))
            {
                string query = $"INSERT INTO HistorialCartones (Fecha, EstadoId, UsuarioId) VALUES (GETDATE(), {partida.EstadoId}, '{partida.UsuarioId}'); SELECT SCOPE_IDENTITY()";

                ResponseModel response = new();
                try
                {
                    cnn.Open();
                    var partidaId = cnn.ExecuteScalar<int>(query);

                    response.Status = true;
                    response.Data = partidaId.ToString();
                }
                catch (Exception)
                {
                    response.Status = false;
                    response.Data = "";
                    throw;
                }
                finally
                {
                    cnn.Close();
                }
                return response;
            };
        }

        public ResponseModel NewGamePlayers(string insert)
        {

            using (var cnn = new SqlConnection(new ConnectionDB().ConnectionStringSQL()))
            {
                string query = $"INSERT INTO Cartones (NumeroCarton, JuegohistorialId, Numeros) VALUES ({insert})";

                ResponseModel response = new();
                try
                {
                    cnn.Open();
                    var partidaId = cnn.ExecuteScalar<string>(query);

                    response.Status = true;
                    response.Data = partidaId;
                }
                catch (Exception)
                {
                    response.Status = false;
                    throw;
                }
                finally
                {
                    cnn.Close();
                }
                return response;
            };
        }

        public ResponseModel LoadGame()
        {
            using (var cnn = new SqlConnection(new ConnectionDB().ConnectionStringSQL()))
            {
                string query = "SELECT hc.Id FROM HistorialCartones hc WITH(NOLOCK) INNER JOIN AspNetUsers u WITH(NOLOCK) ON hc.UsuarioId = u.ID AND hc.EstadoId = 1";

                ResponseModel response = new();

                try
                {
                    cnn.Open();
                    int partidaId = cnn.ExecuteScalar<int>(query);

                    response.Status = true;
                    response.Data = partidaId.ToString();
                    
                    
                }
                catch (Exception)
                {
                    response.Status = false;

                    throw;

                }
                finally
                {
                    cnn.Close();
                }
                return response;
            };
        }
    }
}
