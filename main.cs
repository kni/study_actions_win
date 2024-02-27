using static System.Console;
using System.Collections.Generic;
	
IEnumerable<int> Power(int number, int exponent) {
	int result = 1;
	for (int i = 0; i < exponent; i++) {
		Write("; ");
		yield return result *= number;
	}
}

IEnumerable<int> p = Power(2, 8);
foreach (int i in p) {
	Write("{0} ", i);
}
