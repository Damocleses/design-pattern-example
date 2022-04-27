using design_pattern_example.common;
using design_pattern_example.creators.patterns;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace design_pattern_example.runners.creators
{
    public class SingletonRunner : IRunner
    {
        public void Run()
        {
            Console.WriteLine("使用单线程(0)还是多线程(1)获取单例:");
            var threadInput = 0;
            int.TryParse(Console.ReadLine(), out threadInput);
            if(threadInput == 0)
            {
                this.SynchronizeRun();
            } else
            {
                this.RunAsync();
            }

            //
        }

        private void SynchronizeRun()
        {
            var s1 = SingletonPattern.GetInstance();
            var s2 = SingletonPattern.GetInstance();
            Console.WriteLine($"单线程获取实例, s1 == s2: {s1 == s2}\n");
        }

        private void RunAsync()
        {
            var input = StaticMethod.GetInput("是否使用线程锁(0/1):");
            var useLock = true;
            if(input == "1")
            {
                useLock = true;
            }
            else
            {
                useLock = false;
            }

            var tasks = new List<Task>();
            for (int i = 0; i < 100; i++)
            {
                tasks.Add(Task.Run(() =>
                {
                    var s = SingletonPattern.GetInstance(useLock);
                    Console.WriteLine($"线程ID-${Thread.CurrentThread.ManagedThreadId}, 多线程获取了一次实例");
                }));
            }
            Task.WaitAll(tasks.ToArray());

            var isDestroyed = StaticMethod.GetInput("是否销毁单例(0/1):");
            if(isDestroyed.Equals("1"))
            {
                SingletonPattern.DestroySingleton();
            }

        }
    }
}
