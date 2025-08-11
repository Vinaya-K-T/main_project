using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_potholedete.entities
{
    public class et_budget
    {
        public string project_phase {  get; set; }
        public string complaint_name {  get; set; }
        public string allocated_amount {  get; set; }
        public string expense_type { get; set; }
        public string entry_date {  get; set; }
        public string status {  get; set; }
        public string reason { get; set; }
        public string cid {  get; set; }
    }
}
