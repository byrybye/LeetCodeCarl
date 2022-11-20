// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;

Console.WriteLine("Hello, World!");
//new LeetCode.Code704().Test();
//new LeetCode.Code209().Test();
var reuslt = new LeetCode.Code59().GenerateMatrix(3);
Console.WriteLine(JsonConvert.SerializeObject(reuslt));