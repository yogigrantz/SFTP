using System.IO;
using System.Windows.Forms;

namespace SFTP;

public static class PopUpFolderSearch
{
    public static void PopupFile(TextBox textBox, string searchWildCard, bool storeFileName = false)
    {
        string outputFolder = RegistrySetting.GetRegistryValue(textBox.Name);
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            if (!string.IsNullOrEmpty(outputFolder))
                openFileDialog.InitialDirectory = outputFolder;
            else
                openFileDialog.InitialDirectory = textBox.Text;

            openFileDialog.Filter = $"{searchWildCard.Replace("*", "").Replace(".", "")} files ({searchWildCard})|{searchWildCard}";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(openFileDialog.FileName);
                if (storeFileName)
                    textBox.Text = fi.FullName;
                else
                    textBox.Text = fi.Directory.FullName;
                RegistrySetting.SetRegistryValue(textBox.Name, textBox.Text);
            }
        }
    }

    public static void PopupFile(Label textBox, string searchWildCard)
    {
        string outputFolder = RegistrySetting.GetRegistryValue(textBox.Name);
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            if (!string.IsNullOrEmpty(outputFolder))
                openFileDialog.InitialDirectory = outputFolder;
            else
                openFileDialog.InitialDirectory = textBox.Text;

            openFileDialog.Filter = $"{searchWildCard.Replace("*", "").Replace(".", "")} files ({searchWildCard})|{searchWildCard}";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(openFileDialog.FileName);
                textBox.Text = fi.Name;
                RegistrySetting.SetRegistryValue(textBox.Name, fi.FullName);
                RegistrySetting.SetRegistryValue($"{textBox.Name}Disp", fi.Name);
            }
        }
    }

    public static void Popup(this TextBox textBox)
    {
        string outputFolder = RegistrySetting.GetRegistryValue(textBox.Name);
        using (FolderBrowserDialog folder = new FolderBrowserDialog())
        {
            if (!string.IsNullOrEmpty(outputFolder))
                folder.SelectedPath = outputFolder;
            else
                folder.SelectedPath = textBox.Text;

            DialogResult r = folder.ShowDialog();
            if (r == DialogResult.OK)
            {
                textBox.Text = folder.SelectedPath;
                RegistrySetting.SetRegistryValue(textBox.Name, textBox.Text);
            }
        }
    }
}
