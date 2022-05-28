using System.Collections.Generic;
using DAL;
using Entity;

namespace BLL
{
    public class RedService
    {
        readonly RedRepository redRepository;
        public RedService()
        {
            redRepository = new RedRepository();
        }

        public RedRepositoryResponse Consult(string route)
        {
            try
            {
                return new RedRepositoryResponse(redRepository.Consult(route));
            }
            catch (System.Exception e)
            {
                return new RedRepositoryResponse("Application Error: " + e.Message);
            }
        }
    }
    public class RedRepositoryResponse
    {
        public string Message { get; set; }
        public bool Error { get; set; }
        public Red Red { get; set; }
        public RedRepositoryResponse(string message)
        {
            Message = message;
            Error = true;
        }
        public RedRepositoryResponse(Red red)
        {
            Red = red;
            Error = false;
        }
    }
}
