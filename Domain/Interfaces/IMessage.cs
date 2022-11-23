using Domain.Interfaces.Generics;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IMessage : IGeneric<Message>
    {
        //Este método irá pertencer somente a essa classe, por isso não o implatamos no IGeneric
        //Assim podemos customizar
        Task<List<Message>> ListarMessage(Expression<Func<Message, bool>> exMessage);
    }
}
