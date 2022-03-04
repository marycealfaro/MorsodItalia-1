using System;

namespace MorsodItalia.WebAdmin.Controllers
{
    internal class HttPostedFileBase
    {
        public string FileName { get; internal set; }

        internal void SaveAs(string path)
        {
            throw new NotImplementedException();
        }
    }
}