using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_20
{
    public interface IProcessState
    {
        public void ForwardGo(ProcessInfo pr);
        public void BackwardGo(ProcessInfo pr);
    }
    public class ProcessInfo
    {
        public IProcessState ProcessState { get; set; }

        public ProcessInfo(IProcessState SETprocessState)
        {
            ProcessState = SETprocessState;
        }

        public void ForwardGo()
        {
            ProcessState.ForwardGo(this);
        }

        public void BackwardGo()
        {
            ProcessState.BackwardGo(this);
        }

    }

    public class ProcessState0 : IProcessState
    {
        public void ForwardGo(ProcessInfo pr)
        {
            Console.WriteLine("Статус процесса повышен до 50%");
            pr.ProcessState = new ProcessState50();
        }
        public void BackwardGo(ProcessInfo pr)
        {
            Console.WriteLine("Статус процесса составляет 0% и так, куда ниже то?");
        }
    }

    public class ProcessState50 : IProcessState
    {
        public void ForwardGo(ProcessInfo pr)
        {
            Console.WriteLine("Статус процесса повышен до 100%");
            pr.ProcessState = new ProcessState100();
        }
        public void BackwardGo(ProcessInfo pr)
        {
            Console.WriteLine("Статус процесса понижен до 0%");
            pr.ProcessState = new ProcessState0();
        }
    }

    public class ProcessState100 : IProcessState
    {
        public void ForwardGo(ProcessInfo pr)
        {
            Console.WriteLine("Статус процесса составляет 100% и так, куда выше то?");

        }
        public void BackwardGo(ProcessInfo pr)
        {
            Console.WriteLine("Статус процесса понижен до 50%");
            pr.ProcessState = new ProcessState50();
        }
    }
}
