namespace WebAppSales.Models.ViewModels //nome projeto paste principal e subparta, esse � o endere�o de arquivo errorview models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
