using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;
using System.Data;

namespace Internet_Service_Provider.Classes
{
    public class PrintReportWord
    {

        
        public void PrintReport(DataTable dt)
        {
            
            string pathDocument = AppDomain.CurrentDomain.BaseDirectory + "Order.docx";

            using (DocX Document = DocX.Load(pathDocument))
            {

                BookmarkCollection bookmarks = Document.Bookmarks;
                //fio_subscriber
                Document.Bookmarks["number_order"].Paragraph.ReplaceText("[Номер_договора]", dt.Rows[0].ItemArray[0].ToString());
                Document.Bookmarks["number_contract"].Paragraph.ReplaceText("[Номер_договора]", dt.Rows[0].ItemArray[0].ToString());
                Document.Bookmarks["name_subscriber"].Paragraph.ReplaceText("[ФИО_клиента]", dt.Rows[0].ItemArray[1].ToString());
                Document.Bookmarks["fio_subscriber"].Paragraph.ReplaceText("[ФИО_заказчика]", dt.Rows[0].ItemArray[1].ToString());
                Document.Bookmarks["name_subscriber1"].Paragraph.ReplaceText("[ФИО]", dt.Rows[0].ItemArray[1].ToString());
                Document.Bookmarks["date_birth"].Paragraph.ReplaceText("[Дата_рождения]", DateTime.Parse(dt.Rows[0].ItemArray[2].ToString()).Date.ToShortDateString());
                Document.Bookmarks["address_sub"].Paragraph.ReplaceText("[Адрес_регистрации]", dt.Rows[0].ItemArray[3].ToString());
                Document.Bookmarks["address_pul"].Paragraph.ReplaceText("[Адрес_подключения]", dt.Rows[0].ItemArray[4].ToString());
                Document.Bookmarks["number_phone"].Paragraph.ReplaceText("[Телефон]", dt.Rows[0].ItemArray[5].ToString());
                Document.Bookmarks["tariff"].Paragraph.ReplaceText("[Тариф]", dt.Rows[0].ItemArray[6].ToString());
                Document.Bookmarks["price"].Paragraph.ReplaceText("[цена_тарифа]", dt.Rows[0].ItemArray[7].ToString());
                Document.Bookmarks["date_contract"].Paragraph.ReplaceText("[Дата_контракта]", DateTime.Parse(dt.Rows[0].ItemArray[8].ToString()).Date.ToShortDateString());
                Document.Bookmarks["serial_passport"].Paragraph.ReplaceText("[Серия]", dt.Rows[0].ItemArray[8].ToString());
                Document.Bookmarks["number_passport_footer"].Paragraph.ReplaceText("[Номер]", dt.Rows[0].ItemArray[9].ToString());
                Document.Bookmarks["who_footer"].Paragraph.ReplaceText("[Кем]", dt.Rows[0].ItemArray[10].ToString());
                Document.Bookmarks["date_passport_footer"].Paragraph.ReplaceText("[Выдан]", dt.Rows[0].ItemArray[11].ToString());
                Document.Bookmarks["adress_footer"].Paragraph.ReplaceText("[Адрес]", dt.Rows[0].ItemArray[3].ToString());
                Document.Bookmarks["number_phone_footer"].Paragraph.ReplaceText("[Моб_Тел]", dt.Rows[0].ItemArray[5].ToString());
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Text files(*.doc)|*.docx|All files(*.*)|*.*";
                saveFile.OverwritePrompt = true;
                saveFile.DefaultExt = "Text files(*.docx)";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    string filename = saveFile.FileName;
                    Document.SaveAs(filename);
                    MessageBox.Show("Документ сохранён!", "Сохранение документа");
                }
                
            }
        }

    }
}
