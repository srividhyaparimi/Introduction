using System;
namespace IntroductionToCsharp
{
	public delegate int SumDelegate(int a, int b);
	public delegate void Mydelegate();

	public class ReadWrite
	{
		public void Mymethod(int first, int second)
		{
			SumDelegate delObj = new SumDelegate((x, y) => { return x + y; });
			int result = delObj.Invoke(first, second);
			Console.WriteLine(result);

		}
	
	}
}
