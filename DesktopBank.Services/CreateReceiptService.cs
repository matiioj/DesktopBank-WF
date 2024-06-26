using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopBank.BusinessObjects.Generated.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace DesktopBank.Services
{
    public class CreateReceiptService
    {
        private readonly FormatToReceiptService _formatToReceiptService;
        private readonly Account _sourceAccount;
        private readonly Account _destinationAccount;
        public CreateReceiptService(FormatToReceiptService formatToReceiptService, Account sourceAccount, Account destinationAccount)
        {
            _formatToReceiptService = formatToReceiptService;
            _sourceAccount = sourceAccount;
            _destinationAccount = destinationAccount;
        }



        public void CreateReceipt()
        {
            // Define the relative path to the image
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..","..", "..", "..", "DesktopBankUI", "Resources", "istic_logo.png");
            string absoluteImagePath = Path.GetFullPath(imagePath);
            byte[] imageBytes = File.ReadAllBytes(absoluteImagePath);

            var transferData = _formatToReceiptService.GenerateTransferReceiptData(_sourceAccount, _destinationAccount);


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
                                row.RelativeItem().Text(transferData["OperationAmount"]).SemiBold().FontSize(32).FontColor(Colors.Black);
                                row.ConstantItem(200).AlignRight().Text(transferData["OperationDate"]);
                            });

                            column.Spacing(20);

                            // Sender and Receiver Information Section
                            column.Item().Border(1).BorderColor(Colors.Grey.Lighten1).Padding(10).Column(info =>
                            {
                                info.Item().Text(text =>
                                {
                                    text.Span("De: ").SemiBold();
                                    text.Line(transferData["SenderName"]).Bold();
                                    text.Line(transferData["SenderCUIL"]);
                                    text.Line(transferData["SenderCBU"]);
                                    text.Line("Cuenta en DesktopBank");
                                });

                                info.Spacing(10);

                                info.Item().Text(text =>
                                {
                                    text.Span("Para: ").SemiBold();
                                    text.Line(transferData["ReceiverName"]).Bold();
                                    text.Line(transferData["ReceiverCUIL"]);
                                    text.Line(transferData["ReceiverCBU"]);
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
                                    text.Line(transferData["OperationNote"]);
                                });

                                concept.Spacing(10);

                                concept.Item().Text(text =>
                                {
                                    text.Span("N° de operación").Bold();
                                    text.Line("");
                                    text.Line(transferData["OperationNumber"]);
                                });
                            });
                        });

                });
            })
        .GeneratePdf("C:\\Users\\Franco Sistemas\\Desktop\\prueba.pdf");

        }

    }
}