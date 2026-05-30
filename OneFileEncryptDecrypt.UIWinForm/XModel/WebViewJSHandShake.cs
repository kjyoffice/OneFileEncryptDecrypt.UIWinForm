using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OneFileEncryptDecrypt.UIWinForm.XModel
{
    // https://learn.microsoft.com/en-us/dotnet/api/microsoft.web.webview2.core.corewebview2.addhostobjecttoscript?view=webview2-dotnet-1.0.3595.46
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    public class WebViewJSHandShake
    {
        private ProcessSupportX PSX { get; set; }
        private Func<string> GetLatestCryptoFileListAction { get; set; }
        private Func<string, string> DeleteLatestCryptoFileAction { get; set; }
        private Func<string, bool, string, string, string> CryptoLatestFileAction { get; set; }
        private Action<bool> NewCryptoNowAction { get; set; }
        private Action<string, bool, string, string> NewCryptoStartProcessAction { get; set; }
        private Func<string> GetSavedCryptoPasswordAction { get; set; }
        private Action<string> SetSaveCryptoPasswordAction { get; set; }
        private Func<string, bool, string> OpenFileOrDirectoryAction { get; set; }

        // -----------------------------------------------------------------

        public WebViewJSHandShake(
            ProcessSupportX psx, 
            Func<string> getLatestCryptoFileListAction, 
            Func<string, string> deleteLatestCryptoFileAction, 
            Func<string, bool, string, string, string> cryptoLatestFileAction, 
            Action<bool> newCryptoNowAction,
            Action<string, bool, string, string> newCryptoStartProcessAction,
            Func<string> getSavedCryptoPasswordAction,
            Action<string> setSaveCryptoPasswordAction,
            Func<string, bool, string> openFileOrDirectoryAction
        )
        {
            this.PSX = psx;
            this.GetLatestCryptoFileListAction = getLatestCryptoFileListAction;
            this.DeleteLatestCryptoFileAction = deleteLatestCryptoFileAction;
            this.CryptoLatestFileAction = cryptoLatestFileAction;
            this.NewCryptoNowAction = newCryptoNowAction;
            this.NewCryptoStartProcessAction = newCryptoStartProcessAction;
            this.GetSavedCryptoPasswordAction = getSavedCryptoPasswordAction;
            this.SetSaveCryptoPasswordAction = setSaveCryptoPasswordAction;
            this.OpenFileOrDirectoryAction = openFileOrDirectoryAction;
        }

        public string HelloMessage(string name)
        {
            return $"Hello~ {name}!";
        }

        public string GetLatestCryptoFileList()
        {
            return this.GetLatestCryptoFileListAction();
        }

        public string DeleteLatestCryptoFile(string fileID)
        {
            return this.DeleteLatestCryptoFileAction(fileID);
        }

        public string CryptoLatestFile(string fileID, bool isEncrypt, string cryptoPassword, string cryptoMode)
        {
            return this.CryptoLatestFileAction(fileID, isEncrypt, cryptoPassword, cryptoMode);
        }

        public void NewCryptoNow(bool isEncrypt)
        {
            this.NewCryptoNowAction(isEncrypt);
        }

        public void NewCryptoStartProcess(string filePath, bool isEncrypt, string cryptoPassword, string cryptoMode)
        {
            this.NewCryptoStartProcessAction(filePath, isEncrypt, cryptoPassword, cryptoMode);
        }

        public string GetSavedCryptoPassword()
        {
            return this.GetSavedCryptoPasswordAction();
        }

        public void SetSaveCryptoPassword(string cryptoPassword)
        {
            this.SetSaveCryptoPasswordAction(cryptoPassword);
        }

        public string OpenFileOrDirectory(string filePath, bool isOpenFile)
        {
            return this.OpenFileOrDirectoryAction(filePath, isOpenFile);
        }
    }
}
