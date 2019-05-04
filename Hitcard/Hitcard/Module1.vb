Module Module1
    Dim Hit As String
    Dim HitFile As String = CurDir() & "\Hitcard.txt"
    Dim Index As Integer
    Sub Hitproc()
        Dim Exits As Char
        FileOpen(1, HitFile, OpenMode.Append)
        Do
            Console.WriteLine("请输入今日日期来打卡！")
            Hit = Console.ReadLine
            WriteLine(1, Hit)
            Console.WriteLine("退出？ 【Y/N】")
            Exits = Console.ReadLine
            If Exits = "y" Or Exits = "Y" Then
                Exit Do
            End If
        Loop
        FileClose(1)
    End Sub
    Sub ReadProc()
        Dim Card As String
        FileOpen(1, HitFile, OpenMode.Input)
        Console.WriteLine("打卡记录：")
        Do While Not EOF(1)
            Card = LineInput(1)
            Console.WriteLine(Card)
        Loop
        FileClose(1)
    End Sub
    Sub Main()
        Dim SureClear As Char
        Dim Request As Integer
        Console.WriteLine("欢迎使用Hticard软件！")
        Do
            Console.WriteLine("1. 打卡 2. 已打卡日期查看 3. 清零 4.退出")
            Request = Console.ReadLine
            If Request = 1 Then
                Call Hitproc()
            ElseIf Request = 2 Then
                Call ReadProc()
            ElseIf Request = 3 Then
                Console.WriteLine("确定清零？【Y/N】")
                SureClear = Console.ReadLine
                If SureClear = "y" Or SureClear = "Y" Then
                    FileOpen(1, HitFile, OpenMode.Output)
                    FileClose(1)
                Else

                End If
            Else
                Console.WriteLine("任意键退出：")
                Exit Do
            End If
        Loop
        Console.ReadLine()
    End Sub

End Module
