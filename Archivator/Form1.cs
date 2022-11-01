
using Ionic.Zip;

namespace Archivator
{
    public partial class Form1 : Form
    {
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

        public Form1()
        {
            InitializeComponent();
        }

        private void ChooseCatalog_Click(object sender, EventArgs e)
        {
           if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                CatalogInfo.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void SaveArchive_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Zip files (*.zip) | *.zip";
            if(CatalogInfo.Text != "" && saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ZipFile currentCatalog = new ZipFile(saveFileDialog.FileName);
                currentCatalog.AddDirectory(folderBrowserDialog.SelectedPath);
                currentCatalog.Save();
                MessageBox.Show("Архивация прошла успешно!", "Выполнено");
            }
        }
    }
}