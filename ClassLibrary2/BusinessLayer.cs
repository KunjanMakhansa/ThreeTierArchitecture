using System;
using ClassLibrary1;
using ClassLibrary3;


namespace ClassLibrary2
{
    

    public interface IBusinesLayer
    {
        void InsertUser(UserPL objPl);
        object SelectUser();
    }



    public class BussLayer : IBusinesLayer
    {
        IDataAccessLayer dl = new DataLayer();

        public void InsertUser(UserPL obPl)
        {
            dl.InsertData(obPl);
        }

        public object SelectUser()
        {
            return dl.SelectData();

        }
    }
}
