using iTextSharp.text;
using iTextSharp.text.pdf;
using ngxsis.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ngxsis.Web.Report
{
    public class ProfilReport
    {
        #region Declaration

        int _totalColumn = 2;
        Document _document;
        Font _fontStyle;
        PdfPTable _pdfTable = new PdfPTable(2);
        PdfPCell _pdfPcell;
        MemoryStream _memoryStream = new MemoryStream();
        List<ProfilViewModel> _profil = new List<ProfilViewModel>();

        #endregion

        public byte[] PrepareReport(List<ProfilViewModel> getProfil)
        {
            _profil = getProfil;
            #region
            _document = new Document(PageSize.A4, 0f, 0f, 0f, 0f);
            _document.SetPageSize(PageSize.A4);
            _document.SetMargins(20f, 20f, 20f, 20f);
            _pdfTable.WidthPercentage = 100;
            _pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            _fontStyle = FontFactory.GetFont("Tahoma", 8f, 1);
            PdfWriter.GetInstance(_document, _memoryStream);
            _document.Open();
            _pdfTable.SetWidths(new float[] { 150f, 150f });
            #endregion

            this.ReportHeader();
            this.ReportBody();
            _pdfTable.HeaderRows = 2;
            _document.Add(_pdfTable);
            _document.Close();
            return _memoryStream.ToArray();
        }
        private void ReportHeader()
        {
            _fontStyle = FontFactory.GetFont("Tahoma, 11f, 1");
            _pdfPcell = new PdfPCell(new Phrase("Kampus", _fontStyle));
            _pdfPcell.Colspan = _totalColumn;
            _pdfPcell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfPcell.Border = 0;
            _pdfPcell.BackgroundColor = BaseColor.WHITE;
            _pdfPcell.ExtraParagraphSpace = 0;
            _pdfTable.AddCell(_pdfPcell);
            _pdfTable.CompleteRow();

            _fontStyle = FontFactory.GetFont("Tahoma, 9f, 1");
            _pdfPcell = new PdfPCell(new Phrase("Mahasiswa", _fontStyle));
            _pdfPcell.Colspan = _totalColumn;
            _pdfPcell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfPcell.Border = 0;
            _pdfPcell.BackgroundColor = BaseColor.WHITE;
            _pdfPcell.ExtraParagraphSpace = 0;
            _pdfTable.AddCell(_pdfPcell);
            _pdfTable.CompleteRow();

        }
        private void ReportBody()
        {
            #region Table Header
            _fontStyle = FontFactory.GetFont("Tahoma, 8f, 1");
            _pdfPcell = new PdfPCell(new Phrase("PENDIDIKAN", _fontStyle));
            _pdfPcell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfPcell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfPcell.BackgroundColor = BaseColor.BLUE;
            _pdfPcell.ExtraParagraphSpace = 0;
            _pdfTable.AddCell(_pdfPcell);


            _pdfPcell = new PdfPCell(new Phrase(" ", _fontStyle));
            _pdfPcell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfPcell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfPcell.BackgroundColor = BaseColor.GRAY;
            _pdfPcell.ExtraParagraphSpace = 0;
            _pdfTable.AddCell(_pdfPcell);


            #endregion

            #region Table Body
            _fontStyle = FontFactory.GetFont("Tahoma", 8f, 0);
            int serialNumber = 1;
            foreach (ProfilViewModel item in _profil)
            {
                 _pdfPcell = new PdfPCell(new Phrase(serialNumber++.ToString(), _fontStyle));
                _pdfPcell.HorizontalAlignment = Element.ALIGN_CENTER;
                _pdfPcell.VerticalAlignment = Element.ALIGN_MIDDLE;
                _pdfPcell.BackgroundColor = BaseColor.WHITE;
                _pdfPcell.ExtraParagraphSpace = 0;
                _pdfTable.AddCell(_pdfPcell);

                _pdfPcell = new PdfPCell(new Phrase(item.TahunPendidikan, _fontStyle));
                _pdfPcell.HorizontalAlignment = Element.ALIGN_CENTER;
                _pdfPcell.VerticalAlignment = Element.ALIGN_MIDDLE;
                _pdfPcell.BackgroundColor = BaseColor.WHITE;
                _pdfPcell.ExtraParagraphSpace = 0;
                _pdfTable.AddCell(_pdfPcell);
            
            }
               
            #endregion
        }
    }
}