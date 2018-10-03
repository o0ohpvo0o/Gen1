using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USA_Scanner.HomeModule
{
    public class HomeStatic
    {
        private static HomeStatic _instance;
        public static HomeStatic Instance => _instance ?? new HomeStatic();

        public readonly List<KeyValuePair<string, string>> country = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair<string, string>("United States","0")
        };

        public readonly List<KeyValuePair<string, string>> states = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair<string, string>("None","0"),
            new KeyValuePair<string, string>("Alabama (AL)","1"),
            new KeyValuePair<string, string>("Alaska (AK)","1"),
            new KeyValuePair<string, string>("Arizona (AZ)","1"),
            new KeyValuePair<string, string>("Arkansas (AR)","1"),
            new KeyValuePair<string, string>("California (CA)","1"),
            new KeyValuePair<string, string>("Colorado (CO)","1"),
            new KeyValuePair<string, string>("Connecticut (CT)","1"),
            new KeyValuePair<string, string>("Delaware (DE)","1"),
            new KeyValuePair<string, string>("Florida (FL)","1"),
            new KeyValuePair<string, string>("Georgia (GA)","1"),
            new KeyValuePair<string, string>("Hawaii (HI)","1"),
            new KeyValuePair<string, string>("Idaho (ID)","1"),
            new KeyValuePair<string, string>("Illinois (IL)","1"),
            new KeyValuePair<string, string>("Indiana (IN)","1"),
            new KeyValuePair<string, string>("Iowa (IA)","1"),
            new KeyValuePair<string, string>("Kansas (KS)","1"),
            new KeyValuePair<string, string>("Kentucky (KY)","1"),
            new KeyValuePair<string, string>("Louisiana (LA)","1"),
            new KeyValuePair<string, string>("Maine (ME)","1"),
            new KeyValuePair<string, string>("Maryland (MD)","1"),
            new KeyValuePair<string, string>("Massachusetts (MA)","1"),
            new KeyValuePair<string, string>("Michigan (MI)","1"),
            new KeyValuePair<string, string>("Minnesota (MN)","1"),
            new KeyValuePair<string, string>("Mississippi (MS)","1"),
            new KeyValuePair<string, string>("Missouri (MO)","1"),
            new KeyValuePair<string, string>("Montana (MT)","1"),
            new KeyValuePair<string, string>("Nebraska (NE)","1"),
            new KeyValuePair<string, string>("Nevada (NV)","1"),
            new KeyValuePair<string, string>("NewHampshire (NH)","1"),
            new KeyValuePair<string, string>("NewJersey (NJ)","1"),
            new KeyValuePair<string, string>("NewMexico (NM)","1"),
            new KeyValuePair<string, string>("NewYork (NY)","1"),
            new KeyValuePair<string, string>("NorthCarolina (NC)","1"),
            new KeyValuePair<string, string>("NorthDakota (ND)","1"),
            new KeyValuePair<string, string>("Ohio (OH)","1"),
            new KeyValuePair<string, string>("Oklahoma (OK)","1"),
            new KeyValuePair<string, string>("Oregon (OR)","1"),
            new KeyValuePair<string, string>("Pennsylvania (PA)","1"),
            new KeyValuePair<string, string>("RhodeIsland (RI)","1"),
            new KeyValuePair<string, string>("SouthCarolina (SC)","1"),
            new KeyValuePair<string, string>("SouthDakota (SD)","1"),
            new KeyValuePair<string, string>("Tennessee (TN)","1"),
            new KeyValuePair<string, string>("Texas (TX)","1"),
            new KeyValuePair<string, string>("Utah (UT)","1"),
            new KeyValuePair<string, string>("Vermont (VT)","1"),
            new KeyValuePair<string, string>("Virginia (VA)","1"),
            new KeyValuePair<string, string>("Washington (WA)","1"),
            new KeyValuePair<string, string>("WestVirginia (WV)","1"),
            new KeyValuePair<string, string>("Wisconsin (WI)","1"),
            new KeyValuePair<string, string>("Wyoming (WY)","1"),
        };

        public readonly List<KeyValuePair<string, string>> saveOptions = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair<string, string>("Excel","0"),
            new KeyValuePair<string, string>("Text","0")
        };
    }
}
