
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace Oanea_George_Lab5b.PhoneNumbersDataSetTableAdapters
{
    public partial class PhoneNumbersTableAdapter
    {
        public PhoneNumbersTableAdapter(String connectionString) { 
            this.ClearBeforeFill = true; 
            this.Connection = new System.Data.SqlClient.SqlConnection(connectionString); 
        }
    }
}