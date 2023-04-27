using BilllingSystemPoc.Models;

namespace BilllingSystemPoc.Services
{
    public class ProjectService
    {
        public ProjectService() { }

        public List<InvoiceModel> GetInvoiceDetailsByProjectId(int? projectid)
        {
            if (projectid != null)
            {
                Project project = new Project();
                if (project.InvoiceModel.type == 0) { 

                
                }

                return new List<InvoiceModel>();
            }
        }
    }
}
