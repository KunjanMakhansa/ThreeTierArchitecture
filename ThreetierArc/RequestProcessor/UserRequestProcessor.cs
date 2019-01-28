using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary3;


namespace ClassLibrary2
{

    public interface IUserRequestProcessor
    {
        void InsertUser(UserPL obPl);
        object SelectUser();
    }

    public class UserRequestProcessor : IUserRequestProcessor
    {
        IBusinesLayer businesLayer = new BussLayer();
        public void InsertUser(UserPL obPl)
        {
            businesLayer.InsertUser(obPl);
        }
        public object SelectUser()
        {
            return businesLayer.SelectUser();
        }
    }
}
