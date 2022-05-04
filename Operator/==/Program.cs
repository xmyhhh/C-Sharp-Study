string a = "123";//值

Console.WriteLine(a == "123");

Console.WriteLine(a.Equals("123"));


char[] x = { '1', '2', '3' };

string b = new string(x);//引用

Console.WriteLine(b == "123");

Console.WriteLine(b.Equals("123"));