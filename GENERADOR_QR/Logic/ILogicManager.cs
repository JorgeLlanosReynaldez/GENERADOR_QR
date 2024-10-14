namespace GENERADOR_QR.Logic
{
    public interface ILogicManager
    {
        Task<string> GenerateQR(string submittedUrl);
    }
}
