Imports System

Module Program
    Dim Timer As Timers.Timer = New Timers.Timer()

    Dim Value As String = ""
    Dim PressedKey As ConsoleKeyInfo
    Dim Stopped As Boolean = False

    Sub Main(args As String())
        Console.WriteLine()
        Console.WriteLine("'##::::'##::::'###::::'##::::'##::::'##::::'##::::'###::::'##::::'##:")
        Console.WriteLine(" ###::'###:::'## ##:::. ##::'##::::: ##:::: ##:::'## ##:::. ##::'##::")
        Console.WriteLine(" ####'####::'##:. ##:::. ##'##:::::: ##:::: ##::'##:. ##:::. ##'##:::")
        Console.WriteLine(" ## ### ##:'##:::. ##:::. ###::::::: #########:'##:::. ##:::. ###::::")
        Console.WriteLine(" ##. #: ##: #########::: ## ##:::::: ##.... ##: #########::: ## ##:::")
        Console.WriteLine(" ##:.:: ##: ##.... ##:: ##:. ##::::: ##:::: ##: ##.... ##:: ##:. ##::")
        Console.WriteLine(" ##:::: ##: ##:::: ##: ##:::. ##:::: ##:::: ##: ##:::: ##: ##:::. ##:")
        Console.WriteLine("..:::::..::..:::::..::..:::::..:::::..:::::..::..:::::..::..:::::..::")
        Console.WriteLine()
        Console.WriteLine("                A console written by Aiden Chadwick")
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("Type ?help for information on the default commands.")
        Console.WriteLine()

        While Stopped = False
            Console.Write(" > ")
            Value = Console.ReadLine()

            Console.WriteLine()
            AnalyzeCommand(Value)
        End While
    End Sub

    Private Sub AnalyzeCommand(Command As String)
        Dim PrefixFound As Boolean = False
        Dim BaseFound As Boolean = False

        Dim Pieces As ArrayList = New ArrayList()
        Pieces.AddRange(Command.Split(" "))
        Dim Base As String = Pieces.Item(0)
        Dim Prefix As Char = Base(0)
        Base = Mid(Base, 2)
        Dim Args As String() = Pieces.GetRange(1, Pieces.Count - 1).ToArray(GetType(String))

        If Prefix = CChar("?") Then
            PrefixFound = True

            If Base = "help" Then
                BaseFound = True

                Console.WriteLine(" - Command Help -")
                Console.WriteLine()
                Console.WriteLine("Module: Default")
                Console.WriteLine("Prefix: '?'")
                Console.WriteLine()
                Console.WriteLine("Command name: Help")
                Console.WriteLine("Desc: Shows help for all commands in the module.")
                Console.WriteLine("Syntax: help")
                Console.WriteLine()
                Console.WriteLine(" -   Page 1/1   -")
            End If
            If Base = "stop" Then
                BaseFound = True

                Console.WriteLine("Stopping console...")
                Console.WriteLine()
                Console.WriteLine("Press [Enter] or [Esc] to close.")
                Console.WriteLine("Otherwise, press any other key.")
                Console.WriteLine()
                Console.Write(" >> ")

                PressedKey = Console.ReadKey()
                If PressedKey.Key = ConsoleKey.Enter Or PressedKey.Key = ConsoleKey.Escape Then
                    Stopped = True
                End If
                Console.WriteLine()
            End If
        End If

        If PrefixFound = False Then
            Console.WriteLine("Error: No module found from prefix. [EC#0001]")
        End If
        If BaseFound = False Then
            Console.WriteLine("Error: No command found from base. [EC#0002]")
        End If

        Console.WriteLine()
    End Sub
End Module
