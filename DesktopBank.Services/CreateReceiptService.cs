using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace DesktopBank.Services
{
    public class CreateReceiptService
    {
        public CreateReceiptService()
        {
        }



        public void CreateReceipt()
        {
            // Define the relative path to the image
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..","..", "..", "..", "DesktopBankUI", "Resources", "istic_logo.png");

            // Normalize the path to make it absolute
            string absoluteImagePath = Path.GetFullPath(imagePath);

            
            // Load the image from the relative directory
            byte[] imageBytes = File.ReadAllBytes(absoluteImagePath);

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(1, Unit.Centimetre);
                    page.PageColor(Colors.Grey.Lighten3);
                    page.DefaultTextStyle(x => x.FontSize(12).FontColor(Colors.Black));

                    page.Content()
                        .Padding(20)
                        .Column(column =>
                        {
                            // Header Section
                            column.Item().Row(row =>
                            {
                                row.ConstantItem(50).Image(imageBytes, ImageScaling.FitWidth);
                                row.RelativeItem().AlignCenter().Text("Transferencia enviada").SemiBold().FontSize(22).FontColor(Colors.Black);
                            });

                            column.Spacing(20);

                            // Amount and Date Section
                            column.Item().Border(1).BorderColor(Colors.Grey.Lighten1).Padding(10).Row(row =>
                            {
                                row.RelativeItem().Text("$2.394,71").SemiBold().FontSize(32).FontColor(Colors.Black);
                                row.ConstantItem(200).AlignRight().Text("06/05/2024 · 09:49 h");
                            });

                            column.Spacing(20);

                            // Sender and Receiver Information Section
                            column.Item().Border(1).BorderColor(Colors.Grey.Lighten1).Padding(10).Column(info =>
                            {
                                info.Item().Text(text =>
                                {
                                    text.Span("De: ").SemiBold();
                                    text.Line("MATIAS OJEDA").Bold();
                                    text.Line("CUIT xx-xxxxxxxx-x");
                                    text.Line("CBU 0140043211532952033258");
                                    text.Line("Cuenta en DesktopBank");
                                });

                                info.Spacing(10);

                                info.Item().Text(text =>
                                {
                                    text.Span("Para: ").SemiBold();
                                    text.Line("MATIAS OJEDA").Bold();
                                    text.Line("CUIT xx-xxxxxxxx-x");
                                    text.Line("CBU 0140043211532952033258");
                                    text.Line("Cuenta en DesktopBank");
                                });
                            });

                            column.Spacing(20);

                            // Concept and Operation Number Section
                            column.Item().Border(1).BorderColor(Colors.Grey.Lighten1).Padding(10).Column(concept =>
                            {
                                concept.Item().Text(text =>
                                {
                                    text.Span("Nota").Bold();
                                    text.Line("");
                                    text.Line("Sin nota");
                                });

                                concept.Spacing(10);

                                concept.Item().Text(text =>
                                {
                                    text.Span("N° de operación").Bold();
                                    text.Line("");
                                    text.Line("33577093552");
                                });
                            });
                        });

                });
            })
        .GeneratePdf("D:\\Relocate\\Desktop\\prueba.pdf");

        }

    }
}