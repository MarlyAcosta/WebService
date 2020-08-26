using Org.BouncyCastle.Security;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Form1 : Form
    {
        List<SOAPService.City> c = new List<SOAPService.City>();
        List<SOAPService.City> cp = new List<SOAPService.City>();
        int PaginacionTotal = 0;
        int PaginacionActual = 0;
        int SizePaginacion = 25;
        SOAPService.Service1Client oClient = new SOAPService.Service1Client();
        public Form1()
        {
            InitializeComponent();
            
            PaginacionTotal = c.Count / SizePaginacion;
            cp = c.Skip(PaginacionActual * SizePaginacion).Take(SizePaginacion).ToList();
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Codigo Pais", "Codigo Pais");
            dataGridView1.Columns.Add("Distrito", "Distrito");
            dataGridView1.Columns.Add("Poblacion", "Poblacion");
            c = oClient.Datos().ToList();
            foreach (SOAPService.City ciu in cp)
            {
                dataGridView1.Rows.Add(ciu.Id, ciu.Name,ciu.CountryCode, ciu.District, ciu.Population);
            }
            label1.Text = "Pagina " + (PaginacionActual+1) + " de " + PaginacionTotal;
        }

        private void Primero_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            PaginacionActual = 0;
            cp = c.Skip(PaginacionActual * SizePaginacion).Take(SizePaginacion).ToList();
            foreach (SOAPService.City ciu in cp)
            {
                dataGridView1.Rows.Add(ciu.Id, ciu.Name, ciu.CountryCode, ciu.District, ciu.Population);
            }
            label1.Text = "Pagina " + (PaginacionActual + 1) + " de " + PaginacionTotal;
        }

        private void Anterior_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            PaginacionActual--;
            cp = c.Skip(PaginacionActual * SizePaginacion).Take(SizePaginacion).ToList();
            foreach (SOAPService.City ciu in cp)
            {
                dataGridView1.Rows.Add(ciu.Id, ciu.Name, ciu.CountryCode, ciu.District, ciu.Population);
            }
            label1.Text = "Pagina " + (PaginacionActual + 1) + " de " + PaginacionTotal;
        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            PaginacionActual++;
            cp = c.Skip(PaginacionActual * SizePaginacion).Take(SizePaginacion).ToList();
            foreach (SOAPService.City ciu in cp)
            {
                dataGridView1.Rows.Add(ciu.Id, ciu.Name, ciu.CountryCode, ciu.District, ciu.Population);
            }
            label1.Text = "Pagina " + (PaginacionActual + 1) + " de " + PaginacionTotal;
        }

        private void Ultimo_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            PaginacionActual = PaginacionTotal-1;
            cp = c.Skip(PaginacionActual * SizePaginacion).Take(SizePaginacion).ToList();
            foreach (SOAPService.City ciu in cp)
            {
                dataGridView1.Rows.Add(ciu.Id, ciu.Name, ciu.CountryCode, ciu.District, ciu.Population);
            }
            label1.Text = "Pagina " + (PaginacionActual + 1) + " de " + PaginacionTotal;
        }

        private void excel_Click(object sender, EventArgs e)
        {
            SLDocument sl = new SLDocument();
            int iR = 2;
            foreach(SOAPService.City cu in c)
            {
                sl.SetCellValue(iR, 1, cu.Id.ToString());
                sl.SetCellValue(iR, 2, cu.Name.ToString());
                sl.SetCellValue(iR, 3, cu.CountryCode.ToString());
                sl.SetCellValue(iR, 4, cu.District.ToString());
                sl.SetCellValue(iR, 5, cu.Population.ToString());
                iR++;
            }
            sl.SaveAs(@"C:\Users\Alex\Desktop\macosta3.xlsx");
            MessageBox.Show("Se ha exportado a excel los datos de todas las paginas");
        }

        private void excelP_Click(object sender, EventArgs e)
        {
            SLDocument sl = new SLDocument();
            int iR = 2;
            foreach (SOAPService.City cu in cp)
            {
                sl.SetCellValue(iR, 1, cu.Id.ToString());
                sl.SetCellValue(iR, 2, cu.Name.ToString());
                sl.SetCellValue(iR, 3, cu.CountryCode.ToString());
                sl.SetCellValue(iR, 4, cu.District.ToString());
                sl.SetCellValue(iR, 5, cu.Population.ToString());
                iR++;
            }
            sl.SaveAs(@"C:\Users\Alex\Desktop\macosta3Pagina.xlsx");
            MessageBox.Show("Se ha exportado a excel los datos de la pagina  "+(PaginacionActual+1));
        }
    }
}
