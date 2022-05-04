using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


List<float> list = new List<float>();


float timer = 5f;


list.Add(timer);

Console.WriteLine(list[0]);
list[0] -= 1;
Console.WriteLine(list[0]);
Console.WriteLine(timer);