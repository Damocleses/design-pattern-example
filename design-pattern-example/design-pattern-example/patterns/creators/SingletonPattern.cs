using design_pattern_example.common;
using design_pattern_example.entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace design_pattern_example.creators.patterns
{
    public class SingletonPattern
    {
        #region 饿汉式写法
        //private static SingletonPattern _singletonInstance = new SingletonPattern();

        //private SingletonPattern()
        //{

        //}

        //public static SingletonPattern GetInstance()
        //{
        //    return _singletonInstance;
        //}
        #endregion

        #region 懒汉式写法
        private static SingletonPattern _singletonInstance;
  

        private SingletonPattern()
        {

        }

        private static readonly object singleton_lock = new object();
        /// <summary>
        /// 获取单例
        /// </summary>
        /// <param name="useLock">是否使用锁，演示使用</param>
        /// <returns></returns>
        public static SingletonPattern GetInstance(bool useLock = true)
        {
            if(useLock)
            {
                SingletonPattern.CreateInstanceWithLock();
            } else
            {
                SingletonPattern.CreateInstanceWithoutLock();
            }

            return _singletonInstance;
        }

        /// <summary>
        /// 双重校验，提升性能
        /// </summary>
        private static void CreateInstanceWithLock()
        {
            if (_singletonInstance is null)
            {
                lock (singleton_lock)
                {
                    if (_singletonInstance is null)
                    {
                        Console.WriteLine("singleton created with lock");
                        _singletonInstance = new SingletonPattern();
                    }
                }
            }
        }

        private static void CreateInstanceWithoutLock()
        {
            if (_singletonInstance is null)
            {
                Console.WriteLine("singleton created without lock");
                _singletonInstance = new SingletonPattern();
            }
        }


        public static void DestroySingleton()
        {
            _singletonInstance = null;
        }
        #endregion

    }
}
