using System.Collections.Generic;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_InputScore
    {
        public static List<DTO_InputScore> loadscore(string id)
        {
            // Load Class
            return DAL_InputScore.loadscore(id);
        }
        public static bool EditScore(DTO_InputScore DTOInputScore, string id)
        {
            return DAL_InputScore.EditScore(DTOInputScore, id);
        }
    }
}
