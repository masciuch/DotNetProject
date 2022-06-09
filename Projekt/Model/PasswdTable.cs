using System.ComponentModel;

namespace Projekt.Model
{
    public class PasswdTable
    {
        private static PasswdTable _instance;

        public static PasswdTable Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PasswdTable();
                }

                return _instance;
            }
            set
            {
                _instance = value;
            }
        }

        private BindingList<Password> _passwords;

        public BindingList<Password> Passwords
        {
            get
            {
                if(_passwords == null)
                {
                    _passwords = new BindingList<Password>();
                }

                return _passwords;
            }
            set
            {
                _passwords = value;
            }
        }
    }
}
