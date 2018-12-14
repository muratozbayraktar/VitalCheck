using System;
using System.Threading;

namespace VitalCheck.Core
{
	public abstract class Singleton<T> where T : class
	{
		private static readonly Lazy<T> lazy = new Lazy<T>(CreateInstanceOfT, LazyThreadSafetyMode.ExecutionAndPublication);

		public static T Instance
		{
			get { return lazy.Value; }
		}

		protected Singleton()
		{
		}

		private static T CreateInstanceOfT()
		{
			return Activator.CreateInstance(typeof(T), true) as T;
		}
	}
}