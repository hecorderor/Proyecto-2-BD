using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data;
using System.Net.Mail;
using System.Net;

namespace SistemaVentas
{
    class Conexion
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        MailMessage correos = new MailMessage();
        SmtpClient envios = new SmtpClient();
        

        public Conexion()
        {
            try
            {
                cnn = new SqlConnection("Data Source = DESKTOP-LE92SRN\\SQLEXPRESS; Initial Catalog = master; Integrated Security = True; ");
                cnn.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No conectado" + ex.ToString());

            }
        }

            public void llenarItemsClientes(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("Select IdCliente from Cliente", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["IdCliente"].ToString());
                }
                dr.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("No se llenó el combobox" + ex.ToString());
            }
        }

        public void llenarItemsEjVentas(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("Select IdPersonal from Personal where Puesto = 'EV'", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["IdPersonal"].ToString());
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se llenó el combobox" + ex.ToString());
            }
        }

        public void llenarItemsProductos(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("Select Descripción from CatalogoProductos", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["Descripción"].ToString());
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se llenó el combobox" + ex.ToString());
            }
        }
        public void llenarItemsPedidos(String ejecutivo, ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("Select IdFactura from Pedidos where ejVentas = '"+ejecutivo+"'", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["IdFactura"].ToString());
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se llenó el combobox" + ex.ToString());
            }
        }
        public void llenarItemsConfirmados(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("Select IdFactura from Pedidos where Estado = 'Confirmado'", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["IdFactura"].ToString());
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se llenó el combobox" + ex.ToString());
            }
        }
        public void llenarItemsRevisados(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("Select IdFactura from Pedidos where Estado = 'Revisado'", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["IdFactura"].ToString());
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se llenó el combobox" + ex.ToString());
            }
        }
        public void cargarPedidos(String ejecutivo, DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select * from Pedidos where ejVentas='"+ejecutivo+"'", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo llenar" + ex.ToString());

            }
        }
        public void cargarPedidosConfirmados(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select * from Pedidos where Estado = 'Confirmado'", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar" + ex.ToString());

            }
        }
        public void cargarPedidosRevisados(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select * from Pedidos where Estado = 'Revisado'", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar" + ex.ToString());

            }
        }

        public void cargarPedidosTodos(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select * from Pedidos", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar" + ex.ToString());

            }
        }

        public void cargarProductos(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select * from CatalogoProductos", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar" + ex.ToString());

            }
        }

        public void CambiarEstadoPedido(String idfactura)
        {
            try
            {
                cmd = new SqlCommand("UPDATE Pedidos SET Estado = 'Revisado' WHERE IdFactura = "+idfactura+"", cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se ejecutó." + ex.ToString());

            }
        }
        public void CambiarEstadoCancelado(String idfactura)
        {
            try
            {
                cmd = new SqlCommand("UPDATE Pedidos SET Estado = 'Cancelado' WHERE IdFactura = " + idfactura + "", cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ejecutó." + ex.ToString());

            }
        }
        public void CambiarEstadoConfirmado(String idfactura)
        {
            try
            {
                cmd = new SqlCommand("UPDATE Pedidos SET Estado = 'Confirmado' WHERE IdFactura = " + idfactura + "", cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ejecutó." + ex.ToString());

            }
        }
        public void CambiarEstadoRechazado(String idfactura)
        {
            try
            {
                cmd = new SqlCommand("UPDATE Pedidos SET Estado = 'Rechazado' WHERE IdFactura = " + idfactura + "", cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ejecutó." + ex.ToString());

            }
        }
        public void CambiarEstadoReprocesadp(String idfactura)
        {
            try
            {
                cmd = new SqlCommand("UPDATE Pedidos SET Estado = 'Reprocesado' WHERE IdFactura = " + idfactura + "", cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ejecutó." + ex.ToString());

            }
        }




    }
    }


