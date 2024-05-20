using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace RentCarDocument
{
        internal class Agreement
        {
            public Client client { set; get; } = null;
            public Reservation reservation { set; get; } = null;
            public Location pickUpLocation { set; get; } = null;
            public Location returnLocation { set; get; } = null;
            public Accessories accessories { set; get; } = null;
            public Car car { set; get; } = null;
            private readonly string pathToDocument = @"C:\Users\Szymon\Desktop\FOCP\RentCarAgreementGenerator\AgreementDocument\Umowa_Najmu.docx";

            public async void GenerateDocument()
            {
                if (File.Exists(pathToDocument))
                {
                    string newFilePath = $@"C:\Users\Szymon\Desktop\FOCP\RentCarAgreementGenerator\GeneratedAgreements\umowa{reservation.reservationNumber}.docx";

                    using (WordprocessingDocument originalDoc = WordprocessingDocument.Open(pathToDocument, false))
                    {
                        MakeCopyOfTemplateDocument(originalDoc, newFilePath);

                        using (WordprocessingDocument newDoc = WordprocessingDocument.Open(newFilePath, true))
                        {
                            await UpdateDocument(newDoc);
                            newDoc.Save();

                            if (File.Exists(newFilePath))
                            {
                                MessageBox.Show("Dokument został wygenerowany pomyślnie", "Sukces!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                AddReservationToDataBase();
                            }
                            else
                            {
                                MessageBox.Show("Błąd podczas generowania dokumentu", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            private void AddReservationToDataBase()
            {
                DataBase dataBase = new DataBase();

                string cost = reservation.price.ToString().Replace(",", ".");
                string query = $"INSERT INTO carrentaldatabase.reservations (reservationId, reservationBeginDate, reservationEndDate, reservationCost, reservationCarId) VALUES ('{reservation.reservationNumber}', '{reservation.pickUpDate}', '{reservation.returnDate}','{cost}','{car.carId}');";
                dataBase.NonReturnQuery(query);

                dataBase.CloseConnection();
            }
            private void MakeCopyOfTemplateDocument(WordprocessingDocument originalDoc, string newFilePath)
            {
                // Tworzymy nowy dokument DOCX
                using (WordprocessingDocument newDoc = WordprocessingDocument.Create(newFilePath, WordprocessingDocumentType.Document))
                {
                    // Kopiujemy zawartość oryginalnego dokumentu do nowego dokumentu
                    foreach (var part in originalDoc.Parts)
                    {
                        OpenXmlPart newPart = newDoc.AddPart(part.OpenXmlPart, part.RelationshipId);
                    }
                }
            }
            private async Task UpdateDocument(WordprocessingDocument wordDoc)
            {
                if (wordDoc != null)
                {
                    await Task.Run(() => UpdateClient(wordDoc));
                    await Task.Run(() => UpdateReservation(wordDoc));
                    await Task.Run(() => UpdateLocation(wordDoc));
                    await Task.Run(() => UpdateCar(wordDoc));
                    await Task.Run(() => UpdateAccessories(wordDoc));
                }
            }
            private void ReplaceTextInDocx(WordprocessingDocument wordDoc, string searchText, string replaceText)
            {
                foreach (var text in wordDoc.MainDocumentPart.Document.Body.Descendants<Text>())
                {
                    if (text.Text.Contains(searchText))
                    {
                        text.Text = text.Text.Replace(searchText, replaceText);
                    }
                }
            }
            private void UpdateClient(WordprocessingDocument wordDoc)
            {
                const string clientToReplace = "_CLIENTDATA_";
                string clientFromAgreement = $"{client.name} {client.surname}";
                ReplaceTextInDocx(wordDoc, clientToReplace, clientFromAgreement);

                const string phoneToReplace = "_PHONENUMBER_";
                string phoneFromAgreement = $"{client.phoneNumber}";
                ReplaceTextInDocx(wordDoc, phoneToReplace, phoneFromAgreement);

                const string emailToReplace = "_EMAIL_";
                string emailFromAgreement = $"{client.email}";
                ReplaceTextInDocx(wordDoc, emailToReplace, emailFromAgreement);
            }
            private void UpdateReservation(WordprocessingDocument wordDoc)
            {
                const string reservationNumberToReplace = "_NUMBER_";
                string reservationNumberFromAgreement = reservation.reservationNumber.ToString();
                ReplaceTextInDocx(wordDoc, reservationNumberToReplace, reservationNumberFromAgreement);

                const string pickUpDateToReplace = "_PICKUPDATE_";
                string pickUpDateFromAgreement = reservation.pickUpDate.ToString("yyyy-MM-dd");
                ReplaceTextInDocx(wordDoc, pickUpDateToReplace, pickUpDateFromAgreement);

                const string returnDateToReplace = "_RETURNDATE_";
                string returnDateFromAgreement = reservation.returnDate.ToString("yyyy-MM-dd");
                ReplaceTextInDocx(wordDoc, returnDateToReplace, returnDateFromAgreement);

                const string pickUpTimeToReplace = "_PICKUPTIME_";
                string pickUpTimeFromAgreement = reservation.pickUpDate.ToString("HH:mm");
                ReplaceTextInDocx(wordDoc, pickUpTimeToReplace, pickUpTimeFromAgreement);

                const string returnTimeToReplace = "_RETURNTIME_";
                string returnTimeFromAgreement = reservation.returnDate.ToString("HH:mm");
                ReplaceTextInDocx(wordDoc, returnTimeToReplace, returnTimeFromAgreement);

                const string reservationLengthToReplace = "_LENGTH_";
                string reservationLengthFromAgreement = $"{reservation.GetReservationPeriodinDays().ToString()} dni";
                ReplaceTextInDocx(wordDoc, reservationLengthToReplace, reservationLengthFromAgreement);

                const string reservationCostToReplace = "_PRICE_";
                string reservationCostFromAgreement = reservation.price.ToString();
                ReplaceTextInDocx(wordDoc, reservationCostToReplace, reservationCostFromAgreement);
            }
            private void UpdateLocation(WordprocessingDocument wordDoc)
            {
                const string pickUpCityToReplace = "_PICKUPCITY_";
                string pickUpCityFromAgreement = $"{pickUpLocation.city} {pickUpLocation.street} {pickUpLocation.postalCode}";
                ReplaceTextInDocx(wordDoc, pickUpCityToReplace, pickUpCityFromAgreement);

                const string returnCityToReplace = "_RETURNCITY_";
                string returnCityFromAgreement = $"{returnLocation.city} {returnLocation.street} {returnLocation.postalCode}";
                ReplaceTextInDocx(wordDoc, returnCityToReplace, returnCityFromAgreement);
            }
            private void UpdateCar(WordprocessingDocument wordDoc)
            {
                const string carToReplace = "_CARNAME_";
                string carFromAgreement = $"{car.carBrand} {car.carModel}";
                ReplaceTextInDocx(wordDoc, carToReplace, carFromAgreement);

                const string registrationToReplace = "_REGISTRATION_";
                string registrationFromAgreement = $"{car.carRegistration}";
                ReplaceTextInDocx(wordDoc, registrationToReplace, registrationFromAgreement);
            }
            private void UpdateAccessories(WordprocessingDocument wordDoc)
            {
                const string accessoriesToReplace = "_ACCESSORIES_";
                string accessoriesFromAgreement = string.Empty;

                int accessoriesCount = 0;

                if (accessories.insurance)
                {
                    accessoriesFromAgreement += "Pełne ubezpieczenie, ";
                    accessoriesCount++;
                }
                if (accessories.navi)
                {
                    accessoriesFromAgreement += "Nawigacja, ";
                    accessoriesCount++;
                }
                if (accessories.kilometerLimit)
                {
                    accessoriesFromAgreement += "Brak limitu kilometrów, ";
                    accessoriesCount++;
                }
                if (accessoriesCount >= 2)
                {
                    accessoriesFromAgreement += "\n";
                }

                if (accessories.carSeat)
                {
                    accessoriesFromAgreement += "Fotelik samochodowy, ";
                }
                if (accessoriesCount >= 2)
                {
                    accessoriesFromAgreement += "\n";
                }
                if (accessories.abroad)
                {
                    accessoriesFromAgreement += "Wyjazd za granicę, ";
                }
                ReplaceTextInDocx(wordDoc, accessoriesToReplace, accessoriesFromAgreement);

                const string limitToReplace = "_KILOMETERLIMIT_";
                string limitFromAgreement = "250km";

                if (accessories.kilometerLimit)
                {
                    limitFromAgreement = "Brak limitu.";
                }
                ReplaceTextInDocx(wordDoc, limitToReplace, limitFromAgreement);

                if (accessories.insurance)
                {
                    string symbolToReplace = "_$";
                    string symbolFromAgreement = "X";
                    ReplaceTextInDocx(wordDoc, symbolToReplace, symbolFromAgreement);

                    symbolToReplace = "_!";
                    symbolFromAgreement = " ";
                    ReplaceTextInDocx(wordDoc, symbolToReplace, symbolFromAgreement);

                    symbolToReplace = "_DEPOSIT_";
                    symbolFromAgreement = "100";
                    ReplaceTextInDocx(wordDoc, symbolToReplace, symbolFromAgreement);
                }
                else
                {
                    string symbolToReplace = "_$";
                    string symbolFromAgreement = " ";
                    ReplaceTextInDocx(wordDoc, symbolToReplace, symbolFromAgreement);

                    symbolToReplace = "_!";
                    symbolFromAgreement = "X";
                    ReplaceTextInDocx(wordDoc, symbolToReplace, symbolFromAgreement);

                    symbolToReplace = "_DEPOSIT_";
                    symbolFromAgreement = "500";
                    ReplaceTextInDocx(wordDoc, symbolToReplace, symbolFromAgreement);
                }

                if (accessories.abroad)
                {
                    const string cerToReplace = "_CER_";
                    const string cerFromAgreement = "TAK";
                    ReplaceTextInDocx(wordDoc, cerToReplace, cerFromAgreement);
                }
                else {

                    const string textToReplace = "_CER_";
                    const string textFromAgreement = "NIE";
                    ReplaceTextInDocx(wordDoc, textToReplace, textFromAgreement);

                }
            }

        }
}


