using System.Collections.Generic;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_Score
    {
        public static List<DTO_Score> loadscore(string id)
        {
            // Load Score
            return DAL_Score.loadscore(id);
        }
    }
}
