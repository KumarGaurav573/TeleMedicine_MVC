using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleMedicine_Api.BLL.Interfaces;
using TeleMedicine_Api.DAL.Interfaces;

namespace TeleMedicine_Api.BLL.BusinessServices
{
    public class ReceptionBS : IReceptionBS
    {
        private readonly IReceptionRepository _receptionRepository;
        public ReceptionBS(IReceptionRepository receptionRepository)
        {
            if (_receptionRepository == null)
            {
                _receptionRepository = receptionRepository;
            }
        }
        public string TestReception()
        {
            return _receptionRepository.TestReception();
        }
    }
}
