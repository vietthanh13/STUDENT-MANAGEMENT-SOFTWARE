using System.Collections.Generic;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_Pass
    {
        public static bool CheckDup(DTO_Pass DTOPass)
        {
            return DAL_Pass.CheckDup(DTOPass);
        }
        public static bool EditPass(DTO_Pass DTOPass)
        {
            return DAL_Pass.EditPass(DTOPass);
        }
    }
}
