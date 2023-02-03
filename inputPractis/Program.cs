//基本的なコンソールアプリ
//メッセージを入力して表示するだけの簡単なプログラムでやんす

using System;

class Programm
{
    static void Main()
    {
        //自身の名前を表示する。
        Console.Write("私の名前は猫です。");

        //外部からの入力を受け付ける。
        Console.Write("あなたの名前は？");
        var name = Console.ReadLine();
        
        //入力結果を表示する。
        Console.WriteLine("{0}です", name);
    }
}

