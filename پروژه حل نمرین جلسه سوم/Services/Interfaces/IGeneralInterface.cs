using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace پروژه_حل_نمرین_جلسه_سوم.Services.Interfaces
{
    public interface IGeneralInterface<T>
    {
        void AddItem(T Add);
        void EditITem(T Edit);   
        void RemoveItem(T Remove);
        
    }
}
