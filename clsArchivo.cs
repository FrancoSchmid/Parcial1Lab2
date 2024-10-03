using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryParcial1
{
    public class clsArchivo
    {
        String nombreC = "CATEGORIAS.dat";
        String nombreA = "ARTICULOS.dat";

        public void Cargar(ComboBox comboC)
        {
            StreamReader ADC = new StreamReader(nombreC);
            String linea = "";

            // Lee cada línea del archivo de categorías y las agrega a los ComboBox.
            while ((linea = ADC.ReadLine()) != null)
            {
                comboC.Items.Add(linea);
            }
        }

        public void Buscar(TextBox txtCod, Label descripcion, Label prec, Label categoria, Label stck, Label valStock)
        {

            String datoA = "";                      // Variable que almacenará cada línea del archivo de articulos.
            String[] vectorA = new String[5];       // Vector para almacenar los datos de cada articulos.
            StreamReader ADA = new StreamReader(nombreA);

            while ((datoA = ADA.ReadLine()) != null)
            {
                // Separar la línea en un vector usando ';' como delimitador
                vectorA = datoA.Split(';');

                // Verificar si la categoría del articulo  coincide con la seleccionada
                if (vectorA.Length == 5 && vectorA[0] == txtCod.Text)
                {
                    // Calcular el valor del stock
                    Double precio = Convert.ToDouble(vectorA[2]);
                    Int32 stock = Convert.ToInt32(vectorA[4]);
                    Double valorStock = precio * stock;

                    // Agregar los datos a la grilla
                    descripcion.Text = vectorA[1];
                    prec.Text = vectorA[2];
                    categoria.Text = vectorA[3];
                    stck.Text = vectorA[4];
                    valStock.Text = Convert.ToString(valorStock);
                }
            }

            ADA.Close();
            ADA.Dispose();

        }

        public void Mostrar(DataGridView grill, ComboBox comboC, TextBox TArticulos, TextBox TValorStock)
        {
            String datoA = "";                      // Variable que almacenará cada línea del archivo de articulos.

            String[] vectorA = new String[5];       // Vector para almacenar los datos de cada articulos.

            StreamReader ADC = new StreamReader(nombreC);
            StreamReader ADA = new StreamReader(nombreA);
            grill.Rows.Clear();

            Int32 TotalA = 0;       // Contador de la cantidad total de articulos.
            Double TotalVS = 0;     // Acumulador del valor total del stock.

            while ((datoA = ADA.ReadLine()) != null)
            {
                // Separar la línea en un vector usando ';' como delimitador
                vectorA = datoA.Split(';');

                // Verificar si la categoría del articulo  coincide con la seleccionada
                if (vectorA.Length == 5 && vectorA[2] == (string)comboC.SelectedItem)
                {
                    // Calcular el valor del stock
                    Double precio = Convert.ToDouble(vectorA[2]);
                    Int32 stock = Convert.ToInt32(vectorA[4]);
                    TotalA += stock;
                    Double valorStock = precio * stock;
                    TotalVS += valorStock;

                    // Agregar los datos a la grilla
                    grill.Rows.Add(vectorA[0], vectorA[1], vectorA[2], vectorA[4], valorStock);
                }
            }

            TArticulos.Text = Convert.ToString(TotalA);
            TValorStock.Text = Convert.ToString(TotalVS);

            ADC.Close();
            ADC.Dispose();

            ADA.Close();
            ADA.Dispose();
        }

        public void MostrarTodo(ListView lista)
        {
            String datoA = "";                      // Variable que almacenará cada línea del archivo de articulos.
            String[] vectorA = new String[5];       // Vector para almacenar los datos de cada articulos.
            StreamReader ADA = new StreamReader(nombreA);
            datoA = ADA.ReadLine();

            Int32 i = 0;
            Double valorStock;
            Double precio;
            Int32 stock;

            while ((datoA = ADA.ReadLine()) != null)
            {
                // Separar la línea en un vector usando ';' como delimitador
                vectorA = datoA.Split(';');

                if (vectorA.Length <= 5)
                {
                    precio = Convert.ToDouble(vectorA[2]);
                    stock = Convert.ToInt32(vectorA[4]);
                    valorStock = precio * stock;
                    string valorStockString = Convert.ToString(valorStock);

                    // Agregar la información a la lista (sin usar el índice i)
                    lista.Items.Add(new ListViewItem(new string[] { vectorA[0], vectorA[1], vectorA[2], vectorA[3], vectorA[4], valorStockString }));
                }

                i++;

            }

            ADA.Close();
            ADA.Dispose();
        }

        public void Exportar(DataGridView grilla)
        {
            String nombreArchivo = "DATOSEXPORTADOS.dat";

            // Crear el archivo CSV
            StreamWriter archivoCSV = new StreamWriter(nombreArchivo);

            // Escribir los encabezados de las columnas
            for (int i = 0; i < grilla.Columns.Count; i++)
            {
                archivoCSV.Write(grilla.Columns[i].HeaderText);

                // Añadir una coma entre columnas, excepto en la última columna
                if (i < grilla.Columns.Count - 1)
                {
                    archivoCSV.Write(",");
                }
            }

            archivoCSV.WriteLine();  // Terminar la línea de encabezado

            // Escribir los datos de las filas
            foreach (DataGridViewRow fila in grilla.Rows)
            {
                // Evitar escribir filas vacías
                if (!fila.IsNewRow)
                {
                    for (int i = 0; i < grilla.Columns.Count; i++)
                    {
                        archivoCSV.Write(fila.Cells[i].Value);

                        // Añadir una coma entre columnas, excepto en la última columna
                        if (i < grilla.Columns.Count - 1)
                        {
                            archivoCSV.Write(",");
                        }
                    }
                    archivoCSV.WriteLine();  // Terminar la línea de la fila
                }
            }

            // Cerrar el archivo CSV
            archivoCSV.Close();
            archivoCSV.Dispose();
        }
    }
}