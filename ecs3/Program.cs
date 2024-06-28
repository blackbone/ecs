// See https://aka.ms/new-console-template for more information

using ecs3;

Console.WriteLine("Hello, World!");


var s1 = new Storage1<Component>();
var s2 = new Storage2<Component>();

ref var c1 = ref s1.Ref(0);
ref var c2 = ref s2.Ref(0);

struct Component
{
    private int a;
}