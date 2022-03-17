﻿//creati un tip abstract de date care sa implementeze structura de date stiva

//pop -> intoarce elementul din vf stivei si il elimina
//push -> adauga element in stiva
//peek -> intoarce elementul din vf stivei fara al elimina
//count -> cate elemente sunt in stiva

//structura de date pe care o vom folosi pentru stocarea elementelor stivei va fi un vector
//daca stiva este plina si vrem sa introducem un nou element in stiva va trebui prima data sa dublam capacitatea stivei
//daca numarul de elemente din stiva este egal cu un sfert din capacitatea stivei atunci vom injumatati capacitatea stivei

Console.WriteLine("Hello World!");

MyStack s = new MyStack();

Random rnd = new Random();

for(int i = 0; i < 100; i++)
{
    s.Push(rnd.Next(100));
}

Console.WriteLine($"Numarul de elemente din stiva este {s.Count}.");

int sum = 0;
while(s.Count > 0)
{
    sum += s.Pop();
}

Console.WriteLine($"Numarul de elemente din stiva este {s.Count}.");

s.Push(1);
Console.WriteLine($"Elementul din vf stivei este: {s.Peek()}");