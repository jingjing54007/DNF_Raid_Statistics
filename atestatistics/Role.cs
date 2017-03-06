using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atestatistics
{
    public class Role
    {
        public static string[] RoleTypes = { "帝王C", "晴天C", "震颤C", "舰炮C", "体奶", "精奶", "光兵", "斩铁", "咸鱼", "狗混子"};

        public string BelongTo { get; set; }
        public string RoleName {get; set;}
        
        public string RoleType { get; set; }
        public string RoleLevel { get; set; }
        public int TimesLeft { get; set; }


        public string ToString()
        {
            return BelongTo + "," + RoleName + "," + RoleType + "," + RoleLevel + "," + TimesLeft + "\n";
        }
        
        public void init()
        {
            TimesLeft = 3;
        }

        public void Decrease()
        {
            if (TimesLeft > 0)
            {
                TimesLeft--;
            }
        }

        public static Role FromString(string content)
        {
            content.Replace("，", ",");
            string[] pts = content.Split(new char[] { ',' });
            Role r = new Role();
            r.BelongTo = pts[0];
            r.RoleName = pts[1];
            r.RoleType = pts[2];
            r.RoleLevel = pts[3];
            r.TimesLeft = Int32.Parse(pts[4]);
            return r;
        }
    }
}
