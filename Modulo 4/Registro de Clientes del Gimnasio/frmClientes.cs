using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Text.Json;

namespace GimnasioClientes
{
    public partial class frmClientes : Form
    {
        private List<Cliente> clientes = new List<Cliente>();
        private readonly string archivoClientes = "clientes.json";
        private int clienteSeleccionadoId = -1;

        public frmClientes()
        {
            InitializeComponent();

            // Primero cargar los items del ComboBox
            CargarItemsMembresia();

            // Luego el resto de la inicialización
            CargarClientes();
            ActualizarListaClientes();
            LimpiarCampos();
        }

        private void CargarItemsMembresia()
        {
            cmbMembresia.BeginUpdate(); // Para mejor rendimiento
            try
            {
                cmbMembresia.Items.Clear();
                string[] membresias = { "Básica", "Premium", "VIP", "Familiar", "Anual" };
                cmbMembresia.Items.AddRange(membresias);

                // Después de AddRange
                if (cmbMembresia.Items.Contains("Básica"))
                {
                    cmbMembresia.SelectedItem = "Básica";
                }

                // Establecer valor por defecto sin usar SelectedIndex
                cmbMembresia.Text = "Básica";
            }
            finally
            {
                cmbMembresia.EndUpdate();
            }
        }



        // Métodos auxiliares seguros para conversión
        private int SafeIntParse(string? input, int defaultValue = 0)
        {
            return int.TryParse(input, out int result) ? result : defaultValue;
        }

        private double SafeDoubleParse(string? input, double defaultValue = 0.0)
        {
            return double.TryParse(input, out double result) ? result : defaultValue;
        }

        private void CargarClientes()
        {
            if (File.Exists(archivoClientes))
            {
                try
                {
                    string json = File.ReadAllText(archivoClientes);
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true,
                        WriteIndented = true
                    };

                    var clientesCargados = JsonSerializer.Deserialize<List<Cliente>>(json, options);
                    clientes = clientesCargados ?? new List<Cliente>();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar clientes: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GuardarClientes()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(clientes, options);
                File.WriteAllText(archivoClientes, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar clientes: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarListaClientes()
        {
            if (lstClientes != null)
            {
                lstClientes.DataSource = null;
                lstClientes.DataSource = clientes;
                lstClientes.DisplayMember = "ToString";
            }
        }

        private void LimpiarCampos()
        {
            // Limpiar otros campos
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            dtpFechaInscripcion.Value = DateTime.Now;

            // Manejo seguro del ComboBox
            if (cmbMembresia.Items.Count > 0)
            {
                cmbMembresia.SelectedIndex = 0;
            }
            else
            {
                cmbMembresia.Text = "Básica"; // Alternativa segura
            }

            chkActivo.Checked = true;
            txtBuscar.Text = string.Empty;
            clienteSeleccionadoId = -1;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void MostrarDetallesCliente(Cliente? cliente)
        {
            if (cliente == null) return;

            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtTelefono.Text = cliente.Telefono;
            txtCorreo.Text = cliente.Correo;
            dtpFechaInscripcion.Value = cliente.FechaInscripcion;
            cmbMembresia.SelectedItem = cliente.Membresia;
            chkActivo.Checked = cliente.Activo;
            clienteSeleccionadoId = cliente.Id;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Nombre y Apellido son campos obligatorios", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Cliente nuevoCliente = new Cliente
                {
                    Id = clientes.Count > 0 ? clientes.Max(c => c.Id) + 1 : 1,
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    FechaInscripcion = dtpFechaInscripcion.Value,
                    Membresia = cmbMembresia.SelectedItem?.ToString() ?? "Básica",
                    Activo = chkActivo.Checked
                };

                clientes.Add(nuevoCliente);
                GuardarClientes();
                ActualizarListaClientes();
                LimpiarCampos();

                MessageBox.Show("Cliente registrado exitosamente", "Éxito",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar cliente: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedItem is Cliente clienteSeleccionado)
            {
                MostrarDetallesCliente(clienteSeleccionado);
            }
            else
            {
                MessageBox.Show("Por favor seleccione un cliente de la lista", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ActualizarListaClientes();
            LimpiarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = txtBuscar.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(criterio))
            {
                MessageBox.Show("Ingrese un nombre o apellido para buscar", "Búsqueda",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var resultados = clientes
                .Where(c => (c.Nombre?.ToLower()?.Contains(criterio) ?? false) ||
                           (c.Apellido?.ToLower()?.Contains(criterio) ?? false))
                .ToList();

            lstClientes.DataSource = null;
            lstClientes.DataSource = resultados;
            lstClientes.DisplayMember = "ToString";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionadoId == -1)
            {
                MessageBox.Show("Seleccione un cliente para modificar", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Nombre y Apellido son campos obligatorios", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var cliente = clientes.FirstOrDefault(c => c.Id == clienteSeleccionadoId);
                if (cliente != null)
                {
                    cliente.Nombre = txtNombre.Text.Trim();
                    cliente.Apellido = txtApellido.Text.Trim();
                    cliente.Telefono = txtTelefono.Text.Trim();
                    cliente.Correo = txtCorreo.Text.Trim();
                    cliente.FechaInscripcion = dtpFechaInscripcion.Value;
                    cliente.Membresia = cmbMembresia.SelectedItem?.ToString() ?? "Básica";
                    cliente.Activo = chkActivo.Checked;

                    GuardarClientes();
                    ActualizarListaClientes();

                    MessageBox.Show("Cliente actualizado exitosamente", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar cliente: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionadoId == -1)
            {
                MessageBox.Show("Seleccione un cliente para eliminar", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show("¿Está seguro de eliminar este cliente?", "Confirmar",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    clientes.RemoveAll(c => c.Id == clienteSeleccionadoId);
                    GuardarClientes();
                    ActualizarListaClientes();
                    LimpiarCampos();

                    MessageBox.Show("Cliente eliminado exitosamente", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar cliente: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstClientes.SelectedItem is Cliente clienteSeleccionado)
            {
                MostrarDetallesCliente(clienteSeleccionado);
            }
        }
    }
}