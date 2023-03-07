using System;
using System.IO;

class Test {
	public static void Main() {
		string path = @"Help.txt";
		if (!File.Exists(path)) {
			using (StreamWriter sw = File.CreateText(path)) {
				sw.WriteLine("Hello");
			}
		}

		using (StreamReader sr = File.OpenText(path)) {
			string s;
			while ((s = sr.ReadLine()) != null) {
				Console.WriteLine(s);
			}
		}
		
	}
}