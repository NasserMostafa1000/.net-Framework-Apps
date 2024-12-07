using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystemDataAccessLayer
{
   
    public static class ClsSettings
    {
        public static string connectionString = "";
        public static void ErrorsToEventLog(Exception ex)
        {
            string source = "Bank System";
            string log = "Application";

            if (!EventLog.SourceExists(source))
            {
                EventLog.CreateEventSource(source, log);
            }

            EventLog.WriteEntry(source, ex.Message.ToString(), EventLogEntryType.Error);
            MessageBox.Show(ex.Message.ToString(), "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void CallMessageBoxForMissingOrWrongInformation()
        {
            MessageBox.Show("Missing Information OR Wrong Details,ensure compelete all details about employee", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void  CallMessageBoxForSuccessAdding()
        {
            MessageBox.Show("Adding done successfully", "Operation Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public static void CallMessageBoxForSuccessUpdates()
        {
            MessageBox.Show("Update done successfully", "Operation Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public static void CallMessageBoxForSuccessDeletion()
        {
            MessageBox.Show("Deletion done successfully", "Operation Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public static void CallMessageBoxForNotFound()
        {
            MessageBox.Show("Not found", " Not Found At The Lish", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

    }
}
