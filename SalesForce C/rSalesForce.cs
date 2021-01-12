using System;
using Microsoft.Office.Tools.Ribbon;
using System.Drawing;


namespace Extract
{
    public partial class rSalesForce
    {
        private void rSalesForce_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application APP = Globals.CompoSalesForce.Application;

            APP.StatusBar = "Traitement en cours";
            APP.Worksheets.Add();
            APP.ActiveSheet.Cells(1, 1).value = "PM :";

            APP.ActiveSheet.Range("A1:A1").Interior.Color = Color.FromArgb(192, 0, 0);
            APP.ActiveSheet.Range("B1:B1").Interior.Color = Color.FromArgb(230, 230, 230);
            APP.ActiveSheet.Cells(1, 1).Font.Color = Color.FromArgb(255, 255, 255);

            APP.ActiveSheet.Cells(3, 8).value = "Cartouche";

            APP.ActiveSheet.Cells(4, 1).value = "N° Ligne";
            APP.ActiveSheet.Cells(4, 2).value = "Désignation Article";
            APP.ActiveSheet.Cells(4, 3).value = "Code Article";


            APP.ActiveSheet.Cells(1, 4).value = "E : Existant";
            APP.ActiveSheet.Cells(2, 4).value = "N : Nouveau";
            APP.ActiveSheet.Cells(3, 4).value = "M : Modification";
            APP.ActiveSheet.Cells(4, 4).value = "Type Produit (E,N,M)";

            APP.ActiveSheet.Cells(1, 5).value = "A : A chiffrer";
            APP.ActiveSheet.Cells(2, 5).value = "C : Chiffrer";
            APP.ActiveSheet.Cells(3, 5).value = "D : Décliné";
            APP.ActiveSheet.Cells(4, 5).value = "Statut (A,C,D)";

            APP.ActiveSheet.Cells(4, 6).value = "Prix Mini";
            APP.ActiveSheet.Cells(4, 7).value = "Deviseur";
            APP.ActiveSheet.Cells(4, 8).value = "N° Plan";
            APP.ActiveSheet.Cells(4, 9).value = "Indice";
            APP.ActiveSheet.Cells(4, 10).value = "Désignation";
            APP.ActiveSheet.Cells(4, 11).value = "Propriétaire";

            APP.ActiveSheet.Range("A4:K4").Interior.Color = Color.FromArgb(192, 0, 0);
            APP.ActiveSheet.Range("A4:K4").Font.Color = Color.FromArgb(255, 255, 255);
            APP.ActiveSheet.Range("A4:K4").Font.Bold  = true;
            APP.ActiveSheet.Range("H3:K3").Interior.Color = Color.FromArgb(192, 0, 0);
            APP.ActiveSheet.Range("H3:K3").Font.Color = Color.FromArgb(255, 255, 255);
            APP.ActiveSheet.Range("H3:K3").Font.Bold = true;

            APP.ActiveSheet.Range("H3:K3").Merge();
            APP.ActiveSheet.Range("H3:K3").Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            APP.ActiveSheet.Range("B4:K4").ColumnWidth = 25;
            APP.ActiveSheet.Range("D4:E4").ColumnWidth = 20;
            APP.ActiveSheet.Range("A4").ColumnWidth = 10;
            APP.ActiveSheet.Range("I4").ColumnWidth = 10;
            APP.ActiveSheet.Range("F4").ColumnWidth = 10;
            APP.ActiveSheet.Cells(1, 2).select();

            APP.StatusBar = "";
        }

        private void button3_Click(object sender, RibbonControlEventArgs e)
        {
            Common.GetToken();
        }
    }
}
