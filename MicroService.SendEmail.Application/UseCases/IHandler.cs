using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MicroService.SendEmail.Application.UseCases
{
    public interface IHandler<T,R>
    where T : ICommand
    {
    }
}
