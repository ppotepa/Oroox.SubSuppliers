namespace Oroox.SubSuppliers.Experimentals
{
    using System;

    public class Program
	{
		class Person
		{
			string Name { get; set; }
		}
		public static void Main()
		{
			Console.WriteLine(typeof(Person).GUID);
		}
	}
}
