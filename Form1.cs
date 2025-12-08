using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Bitmap
{
    public partial class Form1 : Form
    {
        private bool[] bitmapArray = new bool[64]; // array para almacenar los 64bits 
        private const int SQUARE_SIZE = 25; // tamaño de cada cuadro en el data matrix
        private bool mostrarNumeros = true; // control si se muestran numeros o colores

        // Campos predeterminados segun el MTI
        private readonly Dictionary<string, string> camposPredeterminados = new Dictionary<string, string>
        {
            { "0100", "2, 3, 4, 7, 11, 12, 13, 41, 49" },    
            { "0200", "2, 3, 4, 7, 11, 12, 13, 41, 48, 49, 62" } 
        };

        public Form1()
        {
            InitializeComponent();
            InicializarFormulario();
        }

        private void InicializarFormulario()
        {
            // seleccionar el primer MTI por defecto
            cmbMTI.SelectedIndex = 0;

            // cargar campos predeterminados del MTI seleccionado
            CargarCamposPredeterminados();

            // agregar evento al cambio de MTI
            cmbMTI.SelectedIndexChanged += CmbMTI_SelectedIndexChanged;
        }

        private void CmbMTI_SelectedIndexChanged(object sender, EventArgs e)
        {
            // cargar campos predeterminados cuando cambia el MTI
            CargarCamposPredeterminados();
        }

        private void CargarCamposPredeterminados()
        {
            if (cmbMTI.SelectedItem != null)
            {
                string mtiSeleccionado = cmbMTI.SelectedItem.ToString();

                if (camposPredeterminados.ContainsKey(mtiSeleccionado))
                {
                    txtCampos.Text = camposPredeterminados[mtiSeleccionado];
                }
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                // validar que se haya seleccionado un MTI
                if (cmbMTI.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor seleccione un MTI (0100 o 0200).", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que se hayan ingresado campos
                if (string.IsNullOrWhiteSpace(txtCampos.Text))
                {
                    MessageBox.Show("Por favor ingrese la lista de campos.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // parse a los campos ingresados
                List<int> campos = ParsearCampos(txtCampos.Text);

                if (campos.Count == 0)
                {
                    MessageBox.Show("No se encontraron campos válidos. Ingrese números del 1 al 64 separados por coma.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // generar bitmap
                GenerarBitmap(campos);

                // mostrar
                MostrarResultados();
                mostrarNumeros = false;

                // redibujar el datamatrix
                pnlDataMatrix.Invalidate();

                MessageBox.Show("Bitmap generado exitosamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el bitmap: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<int> ParsearCampos(string texto)
        {
            List<int> campos = new List<int>();
            HashSet<int> camposUnicos = new HashSet<int>();

            // separar por comas
            string[] partes = texto.Split(new char[] { ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string parte in partes)
            {
                if (int.TryParse(parte.Trim(), out int campo))
                {
                    // validar que el campo este en el rango valido o del 1-64
                    if (campo >= 1 && campo <= 64)
                    {
                        // evitar duplicados
                        if (!camposUnicos.Contains(campo))
                        {
                            campos.Add(campo);
                            camposUnicos.Add(campo);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"El campo {campo} está fuera del rango válido (1-64) y será ignorado.",
                            "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            // ordenar los campos
            campos.Sort();

            return campos;
        }

        private void GenerarBitmap(List<int> campos)
        {
            // inicializar el array en false en los bits en 0
            for (int i = 0; i < 64; i++)
            {
                bitmapArray[i] = false;
            }

            // encender los bits correspondientes a los campos
            foreach (int campo in campos)
            {
                bitmapArray[campo - 1] = true;
            }
        }

        private void MostrarResultados()
        {
            // generar la cadena binaria
            string binario = GenerarCadenaBinaria();
            txtBitmapBinario.Text = binario;

            // generar la cadena hexadecimal
            string hexadecimal = GenerarCadenaHexadecimal();
            txtBitmapHex.Text = hexadecimal;

            // generar el mensaje completo (MTI + Bitmap)
            string mti = cmbMTI.SelectedItem.ToString();
            txtMensajeCompleto.Text = $"{mti}{hexadecimal}";
        }

        private string GenerarCadenaBinaria()
        {
            string binario = "";

            // generar la cadena en grupos de 8 bits
            for (int i = 0; i < 64; i++)
            {
                binario += bitmapArray[i] ? "1" : "0";

                // agregar espacio cada 8 bits menos el final
                if ((i + 1) % 8 == 0 && i < 63)
                {
                    binario += " ";
                }
            }

            return binario;
        }

        private string GenerarCadenaHexadecimal()
        {
            string hexadecimal = "";

            // convertir cada grupo de 4 bits a hexadecimal
            for (int i = 0; i < 64; i += 4)
            {
                int valor = 0;

                for (int j = 0; j < 4; j++)
                {
                    if (bitmapArray[i + j])
                    {
                        valor += (int)Math.Pow(2, 3 - j);
                    }
                }

                // convertir a hexadecimal
                hexadecimal += valor.ToString("X");
            }

            return hexadecimal;
        }

        private void pnlDataMatrix_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // limpiar el panel
            g.Clear(Color.White);

            int bitIndex = 0;

            // dibujar las 8 filas
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    int x = col * (SQUARE_SIZE + 5) + 10;
                    int y = row * (SQUARE_SIZE + 5) + 10;

                    Color colorCuadro;

                    if (mostrarNumeros)
                    {
                        // Modo inicial: todos blancos
                        colorCuadro = Color.White;
                    }
                    else
                    {
                        // negro = 1 blanco = 0
                        colorCuadro = bitmapArray[bitIndex] ? Color.Black : Color.White;
                    }

                    // dibujar el cuadro
                    using (SolidBrush brush = new SolidBrush(colorCuadro))
                    {
                        g.FillRectangle(brush, x, y, SQUARE_SIZE, SQUARE_SIZE);
                    }

                    // el borde
                    using (Pen pen = new Pen(Color.Gray, 1))
                    {
                        g.DrawRectangle(pen, x, y, SQUARE_SIZE, SQUARE_SIZE);
                    }

                    if (mostrarNumeros)
                    {
                        string numBit = (bitIndex + 1).ToString();
                        using (Font font = new Font("Arial", 8, FontStyle.Bold))
                        {
                            SizeF textSize = g.MeasureString(numBit, font);
                            float textX = x + (SQUARE_SIZE - textSize.Width) / 2;
                            float textY = y + (SQUARE_SIZE - textSize.Height) / 2;

                            using (SolidBrush textBrush = new SolidBrush(Color.Black))
                            {
                                g.DrawString(numBit, font, textBrush, textX, textY);
                            }
                        }
                    }

                    bitIndex++;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // restaurar campos predeterminados segun el MTI seleccionado
            CargarCamposPredeterminados();

            // limpiar resultados
            txtBitmapBinario.Clear();
            txtBitmapHex.Clear();
            txtMensajeCompleto.Clear();

            // eeinicia el bitmap
            for (int i = 0; i < 64; i++)
            {
                bitmapArray[i] = false;
            }

            mostrarNumeros = true;

            // refrescar el data matrix
            pnlDataMatrix.Invalidate();
        }
    }
}