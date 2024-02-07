using System;
using Menu.MenuColors;

namespace Menu
{
    namespace MenuSetting
    {
        public class Settings
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public class Bar
        {
            private readonly int kol = Enum.GetNames(typeof(MenuColor.Color)).Length;
            private int pos = 0;
            private int type;

            public Bar(int type)
            {
                this.type = type;
            }
        }
    }
}
