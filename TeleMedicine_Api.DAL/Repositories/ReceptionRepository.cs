using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleMedicine_Api.DAL.Interfaces;

namespace TeleMedicine_Api.DAL.Repositories
{
    public class ReceptionRepository: IReceptionRepository
    {
        public string TestReception()
        {
            return "Test is success from repository..";
        }
    }
}
