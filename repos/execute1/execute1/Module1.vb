
Imports execute1


Module Module1

    Sub Main()

        Console.WriteLine(" vamos a ejecutar snort ,por favor introduce los siguientes datos:")
        Console.WriteLine(" por favor introduce el path del ejecutable snort")
        Dim pathsnort As String = Console.ReadLine()
        Console.WriteLine(" introduce el path de las firmas")
        Dim pathfirmas As String = Console.ReadLine()
        Console.WriteLine(" introduce el path del fichero pcap")
        Dim pathpcap As String = Console.ReadLine()

        Dim proces As New Process()
        'proces.StartInfo.FileName = (pathsnort) & ("-r") & (pathfirmas) & ("-r") & (pathpcap)
        'proces.StartInfo.FileName = (pathsnort) & _("-l") & _(pathpcap)
        proces.StartInfo.FileName = pathsnort & (pathpcap)
        proces.Start()

        ' Console.ReadLine()
    End Sub




End Module
