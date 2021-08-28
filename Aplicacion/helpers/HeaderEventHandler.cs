﻿using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Events;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.helpers
{
    public class HeaderEventHandler : IEventHandler
    {
        Image Img;
        public HeaderEventHandler(Image img)
        {
            Img = img;
        }
        public void HandleEvent(Event @event)
        {
            PdfDocumentEvent docEvent = (PdfDocumentEvent)@event;
            PdfDocument pdfDoc = docEvent.GetDocument();
            PdfPage page = docEvent.GetPage();

            PdfCanvas canvas1 = new PdfCanvas(page.NewContentStreamBefore(), page.GetResources(), pdfDoc);
            Rectangle rootArea = new Rectangle(35, page.GetPageSize().GetTop() - 75, page.GetPageSize().GetWidth() - 70, 55);
            new Canvas(canvas1, pdfDoc, rootArea).Add(getTable());

            //Rectangle rootArea = new Rectangle(35, page.GetPageSize().GetTop() - 70, page.GetPageSize().GetRight() - 70, 50);
            //Canvas canvas = new Canvas(page, rootArea);
            //canvas
            //    .Add(getTable(docEvent))
            //    .ShowTextAligned("Este es el encabezado de pagina", 10, 0, TextAlignment.CENTER)
            //    .ShowTextAligned("Este es el pie de pagina", 10, 10, TextAlignment.CENTER)
            //    .ShowTextAligned("Texto agregado", 612, 0, TextAlignment.RIGHT)
            //    .Close();
        }

        private Table getTable()
        {
            float[] cellWidth = { 20f, 80f };
            Table tableEvent = new Table(UnitValue.CreatePercentArray(cellWidth)).UseAllAvailableWidth();

            Style styleCell = new Style()
                .SetBorder(Border.NO_BORDER);

            Style styleText = new Style()
                .SetTextAlignment(TextAlignment.RIGHT).SetFontSize(10f);

            Cell cell = new Cell().Add(Img.SetAutoScale(true));
                //.SetBorder(new SolidBorder(ColorConstants.BLACK, 1));

            tableEvent.AddCell(cell
                .AddStyle(styleCell)
                .SetTextAlignment(TextAlignment.LEFT));
            PdfFont bold = PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLD);
            cell = new Cell()
                .Add(new Paragraph("Reporte diario\n").SetFont(bold))
                .Add(new Paragraph("Hola\n").SetFont(bold))
                .Add(new Paragraph("Fecha de emisión: " + CustomTimeZone.DateNow().ToShortDateString()))
                .AddStyle(styleText).AddStyle(styleCell);
                //.SetBorder(new SolidBorder(ColorConstants.BLACK, 1));

            tableEvent.AddCell(cell);

            return tableEvent;
        }

    }
}
