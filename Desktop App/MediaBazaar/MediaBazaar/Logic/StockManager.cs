using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MediaBazaar.Data;
using MediaBazaar.Entities;

namespace MediaBazaar.Logic
{
    public class StockManager
    {
        private List<Product> stock;
        private readonly StockData stockData = new StockData();

        public StockManager()
        {
            stock = stockData.GetAllStock();
        }

        public void RefreshStock()
        {
            stock = stockData.GetAllStock();
        }

        public List<Product> GetUnderStocked()
        {
            RefreshStock();
            var list = new List<Product>();
            foreach (var p in stock)
            {
                if (p.MinProductQuantity > p.ProductQuantity)
                {
                    list.Add(p);
                }
            }

            return list;
        }

        public List<Product> GetAllStock()
        {
            return stock;
        }

        public Product GetProduct(int id)
        {
            foreach (var p in stock)
            {
                if (p.ProductId == id)
                {
                    return p;
                }
            }

            return null;
        }

        public void UpdateProduct(int productId, int quantity)
        {
            foreach (var product in stock)
            {
                if (product.ProductId == productId)
                {
                    product.ProductQuantity = quantity;
                    stockData.UpdateProduct(productId, quantity);
                }

            }
        }

        public void DeleteProduct(int id)
        {
            stock.Remove(GetProduct(id));
            stockData.DeleteProduct(id);

        }

        public void AddProduct(Product p)
        {
            stock.Add(p);
            stockData.AddProduct(p);
        }

        public void EditStock(int id, string pName, int pPrice, string pBrand, int pQuantity, int min)
        {
            stockData.EditProductDetails(id, pName, pPrice, pBrand, pQuantity, min);
        }

        public void ExportStockToPdf(PdfPTable pdfptable, String strPdfPath, string strHeader, DataGridView dataGrid)
        {

            FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Write the table
            PdfPTable table = new PdfPTable(dataGrid.Columns.Count);
            //Table header
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            //Font fntColumnHeader = new Font(btnColumnHeader, 10, 1, Color.WHITE);
            for (int j = 0; j < dataGrid.Columns.Count; j++)
            {
                table.AddCell(new Phrase(dataGrid.Columns[j].HeaderText));
            }
            table.HeaderRows = 1;
            //table Data
            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                for (int k = 0; k < dataGrid.Columns.Count; k++)
                {
                    if (dataGrid[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(dataGrid[k, i].Value.ToString()));
                    }
                }
            }

            document.Add(table);
            document.Close();
        }
    }
}
