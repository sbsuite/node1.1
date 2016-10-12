using System.Threading.Tasks;
using node2_1;

namespace node1_1
{
   public class ModelExportService
   {
      private readonly IReportingServices _reportingServices;

      public ModelExportService(node2_1.IReportingServices reportingServices)
      {
         _reportingServices = reportingServices;
      }

      public Task<bool> ExportModel(Model model, string fileName)
      {
         var table = model.ToDataTable();
         return Task.Run(() => _reportingServices.Report(table, fileName));
      }
   }
}