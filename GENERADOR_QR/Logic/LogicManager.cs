using QRCoder;

namespace GENERADOR_QR.Logic
{
    public class LogicManager : ILogicManager
    {
        public async Task<string> GenerateQR(string submittedUrl)
        {
            try
            {
                QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
                QRCodeData qRData = qRCodeGenerator.CreateQrCode(submittedUrl, QRCodeGenerator.ECCLevel.Q);
                BitmapByteQRCode Qrr = new BitmapByteQRCode(qRData);
                byte[] qrcodeAs = Qrr.GetGraphic(20);
                var ms = new MemoryStream(qrcodeAs);
                return "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
