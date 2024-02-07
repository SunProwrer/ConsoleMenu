namespace Menu
{
    namespace MenuApplication
    {
        /// <summary>
        /// Ссылка на приложение (функцию)
        /// </summary>
        //public delegate void FuncApp();

        public class Application
        {
            /// <summary>
            /// На какой странице находится приложение
            /// </summary>
            public int Page;

            /// <summary>
            /// На какой позиции находится приложение
            /// </summary>
            public int Position;

            /// <summary>
            /// Название приложения (то, что напишется в меню)
            /// </summary>
            public string Message;

            public delegate void FuncApp();

            public Application()
            {

            }

            public Application(int Page, int Position, string Message)
            {
                this.Page = Page;
                this.Position = Position;
                this.Message = Message;
            }
        }
    }
}