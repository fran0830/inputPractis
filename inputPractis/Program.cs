//基本的なコンソールアプリ
//メッセージを入力して表示するだけの簡単なプログラムでやんす

using System;

class Programm
{
    static void Main()
    {
        //入力を促すメッセージの表示をして、文字入力してもらう。
        Console.Write("あなたの名前はなんですか？:  ");
        var name = Console.ReadLine();

        //入力を促すメッセージの表示を行い、数値を入力してもらう
        Console.Write("あなたの年齢を入力して下さい。:  ");
        var age = int.Parse(Console.ReadLine());

        //メッセージの出力
        Console.WriteLine("{0}({1}歳) さん、ようこそお越しくださいました。", name, age);
    }
}

