using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InveTime.Commands.Base
{
    class LambdaCommand : Command
    {
        private readonly Action<object> _Exequte;
        private readonly Func<object, bool> _CanExequte;

        public LambdaCommand(Action<object> Exequte, Func<object, bool> CanExequte = null)
        {
            _Exequte = Exequte ?? throw new ArgumentNullException(nameof(Execute));
            _CanExequte = CanExequte;
        }

        public override bool CanExecute(object parameter) => _CanExequte?.Invoke(parameter) ?? true;

        public override void Execute(object parameter) => _Exequte(parameter);
    }
}
