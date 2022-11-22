// See https://aka.ms/new-console-template for more information
using LeetCode707;
using Newtonsoft.Json;

Console.WriteLine("Hello, World!");
//new LeetCode.Code704().Test();
//new LeetCode.Code209().Test();
//var reuslt = new LeetCode.Code59().GenerateMatrix(3);
//Console.WriteLine(JsonConvert.SerializeObject(reuslt));

//new MyLinkedList().Test();
var list = new MyLinkedList();
list.AddAtTail(1);
list.AddAtTail(2);
list.AddAtTail(3);
list.AddAtTail(4);
list.DeleteAtIndex(3);
list.DeleteAtIndex(0);
list.AddAtIndex(0, 5);
list.AddAtIndex(3, 6);
list.Print();