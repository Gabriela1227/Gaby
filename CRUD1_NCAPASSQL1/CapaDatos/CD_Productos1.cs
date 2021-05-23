﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Productos1
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
            

        }

        public void Insertar(string nombre, string desc, string marca, double precio, int stock)
        {
            comando.Connection = conexion.AbrirConexion();
            //PROCEDIMIENTO
            comando.CommandText = "InsertarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre",nombre);
            comando.Parameters.AddWithValue("@desc",desc);
            comando.Parameters.AddWithValue("@marca",marca);
            comando.Parameters.AddWithValue("@precio",precio);
            comando.Parameters.AddWithValue("@stock",stock);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Editar(string nombre, string desc, string marca, double precio, int stock, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre",nombre);
            comando.Parameters.AddWithValue("@desc",desc);
            comando.Parameters.AddWithValue("@marca",marca);
            comando.Parameters.AddWithValue("@precio",precio);
            comando.Parameters.AddWithValue("@stock",stock);
            comando.Parameters.AddWithValue("@id",id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarProductos";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idpro", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

    }
}
