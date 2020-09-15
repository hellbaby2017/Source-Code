using System.Windows.Forms;

namespace SVP.Presentador
{
    public class Exportar 
    {
        public static void exportarexcel(DevExpress.XtraGrid.GridControl malla)
        {
            SaveFileDialog dlgguardar = new SaveFileDialog();
            dlgguardar.Filter = "Ficheros Excel (*.xls)|*.xls|Todos (*.*)|*.*";
            dlgguardar.FilterIndex = 1;
            dlgguardar.RestoreDirectory = true;
            if (dlgguardar.ShowDialog() == DialogResult.OK)
            malla.ExportToXls(dlgguardar.FileName);
               }

        public static void exportarpdf(DevExpress.XtraGrid.GridControl malla)
        {
            SaveFileDialog dlgguardar = new SaveFileDialog();
            dlgguardar.Filter = "Ficheros Adobe Acrobat (*.pdf)|*.pdf|Todos (*.*)|*.*";
            dlgguardar.FilterIndex = 1;
            dlgguardar.RestoreDirectory = true;
            if (dlgguardar.ShowDialog() == DialogResult.OK)
                malla.ExportToPdf(dlgguardar.FileName);
        }
        public static void exportarhtml(DevExpress.XtraGrid.GridControl malla)
        {
            SaveFileDialog dlgguardar = new SaveFileDialog();
            dlgguardar.Filter = "Ficheros HTML (*.html)|*.html|Todos (*.*)|*.*";
            dlgguardar.FilterIndex = 1;
            dlgguardar.RestoreDirectory = true;
            if (dlgguardar.ShowDialog() == DialogResult.OK)
                malla.ExportToHtml(dlgguardar.FileName);
        }

    }
}
