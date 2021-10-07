using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.InputFiles;

namespace Custom_Winform_For_Telegram_Bot_Api
{
    public partial class Form1 : Form
    {
        private static string apiToken = "your_api_token";
        private static string chatId = "@your_chat_id";
        private string filePath = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSendMessage_Click_1(object sender, EventArgs e)
        {
            TelegramBotClient Bot = new TelegramBotClient(apiToken);
            Bot.SendTextMessageAsync(chatId, txtMessage.Text);
        }

        private async void btnSendDocument_Click_1(object sender, EventArgs e)
        {
            var fileName = filePath.Split('\\').Last();

            using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                TelegramBotClient Bot = new TelegramBotClient(apiToken);
                InputOnlineFile fileContentOnline = new InputOnlineFile(fileStream);
                await Bot.SendDocumentAsync(chatId, fileContentOnline, null, fileName);
            }
        }

        private void btnSelectDocument_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                }
            }

            txtFileName.Text = filePath.Split('\\').Last();
        }
    }
}