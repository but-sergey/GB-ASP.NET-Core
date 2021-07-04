using System.Collections.Generic;

namespace WebStore.Interfaces.TestAPI
{
    interface IValuesService
    {
        IEnumerable<string> GetAll();

        string GetByIndex(int index);

        void Add(string value);

        void Edit(int index, string str);

        void Delete(int index);
    }
}
