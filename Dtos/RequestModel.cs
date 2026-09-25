public class ServiceRequestReportRequest
{
    public DateTime P_Start { get; set; }
    public DateTime P_Finish { get; set; }

    // optional เช่น "08:00:00"
    public string? P_Time_Start { get; set; }
    public string? P_Time_Finish { get; set; }
}