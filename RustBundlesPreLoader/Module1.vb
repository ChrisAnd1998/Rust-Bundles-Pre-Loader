Imports System.IO

Module Module1

    Sub Main()

        AddHandler AppDomain.CurrentDomain.ProcessExit, AddressOf OnClose

        Console.ForegroundColor = ConsoleColor.DarkRed

        Console.WriteLine("
_____________       ///////////////////////////////////////////////////////////
                    ///////////////////////////////////////////////////////////
  ______            ///////////////////////////////////////////////////////////
   __________       ///////////////////////////////////////////////////////////
                    //////////////////////////             ////////////////////
                    //////////////////////////            /////////////////////
 _______________    //////////////////////////            /////////////////////
                    ///////////////////////////          //////////////////////
           _______  ///////////////////////////          //////////////////////
______              ////////////////////////////         //////////////////////
                    ///////////////////////////////////////////////////////////
     _________      ////////////////////////////        ///////////////////////
      _____         ////////////////////////////        ///////////////////////
                    ///////    ////////////////////////////////////////////////
   _________        ///////            //    //////////////////////////////////
__________          ///////            //    ////    //////////////////////////
              ___   ///////            //    ////    //// /////////////////////
    _____           ///////            //    //////////     ///////////////////
                    ///////            //    ////////      // /////////////////
                    ///////    /////////////////////     //       /////////////
         ____       ////////////////////////////////// //            //////////
_________           ////////////////////////////////////                ///////
                    /////////////////////////////////////             /////////
          ________  ///////////////////////////////////////         ///////////
____                ////////////////////////////////////////      /////////////
      __            /////////////////////////////////////////   ///////////////
                    ///////////////////////////////////////////////////////////
   __________       ///////////////////////////////////////////////////////////
                    ///////////////////////////////////////////////////////////
")



        Console.ForegroundColor = ConsoleColor.Gray
        Console.WriteLine("")
        Console.WriteLine("Rust Bundles Pre-Loader by ChrisAnd1998")
        Console.WriteLine("")
        Console.WriteLine("##########################################################")


        System.Threading.Thread.Sleep(2000)
        Console.WriteLine("")

        If Not My.Computer.FileSystem.FileExists(Assets) Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine(Assets.ToString & " Not found!")
            Console.WriteLine("Ending within 3 seconds...")
            System.Threading.Thread.Sleep(3000)
            End
        Else
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(Assets.ToString & " Found!")

        End If

        If Not My.Computer.FileSystem.FileExists(Content) Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine(Content.ToString & " Not found!")
            Console.WriteLine("Ending within 3 seconds...")
            System.Threading.Thread.Sleep(3000)
            End
        Else
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(Content.ToString & " Found!")

        End If

        If Not My.Computer.FileSystem.FileExists(Monuments) Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine(Monuments.ToString & " Not found!")
            Console.WriteLine("Ending within 3 seconds...")
            System.Threading.Thread.Sleep(3000)
            End
        Else
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(Monuments.ToString & " Found!")

        End If

        If Not My.Computer.FileSystem.FileExists(Textures) Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine(Textures.ToString & " Not found!")
            Console.WriteLine("Ending within 3 seconds...")
            System.Threading.Thread.Sleep(3000)
            End
        Else
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(Textures.ToString & " Found!")

        End If

        If Not My.Computer.FileSystem.FileExists(Maps) Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine(Maps.ToString & " Not found!")
            Console.WriteLine("Ending within 3 seconds...")
            System.Threading.Thread.Sleep(3000)
            End
        Else
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(Maps.ToString & " Found!")

        End If

        Console.WriteLine("")

        Console.ForegroundColor = ConsoleColor.White

        Console.WriteLine("Loading Bundles...")
        Console.WriteLine("")

        Dim t1 As System.Threading.Thread = New System.Threading.Thread(AddressOf LoadAssets)
        t1.Start()

        Dim t2 As System.Threading.Thread = New System.Threading.Thread(AddressOf LoadContent)
        t2.Start()

        Dim t3 As System.Threading.Thread = New System.Threading.Thread(AddressOf LoadMonuments)
        t3.Start()

        Dim t4 As System.Threading.Thread = New System.Threading.Thread(AddressOf LoadTextures)
        t4.Start()

        Dim t5 As System.Threading.Thread = New System.Threading.Thread(AddressOf LoadMaps)
        t5.Start()
    End Sub


    Dim megabyte As Integer = (1024 * 1024)
    Dim Assets As String = System.IO.File.ReadAllLines("config.txt")(0)
    Dim Content As String = System.IO.File.ReadAllLines("config.txt")(1)
    Dim Monuments As String = System.IO.File.ReadAllLines("config.txt")(2)
    Dim Textures As String = System.IO.File.ReadAllLines("config.txt")(3)
    Dim Maps As String = System.IO.File.ReadAllLines("config.txt")(4)

    Sub LoadAssets()

        Dim theFilename = (Assets)
        Dim whereToStartReading As Long = 0

        Dim fileStram As FileStream = New FileStream(theFilename, FileMode.Open, FileAccess.Read)

        Dim buffer() As Byte = New Byte((megabyte) - 1) {}
        fileStram.Seek(whereToStartReading, SeekOrigin.Begin)
        Dim bytesRead As Integer = fileStram.Read(buffer, 0, megabyte)

        While (bytesRead > 0)
            ProcessChunk(buffer, bytesRead)
            bytesRead = fileStram.Read(buffer, 0, megabyte)

        End While

        Console.WriteLine("Assets Loaded!")

        System.Threading.Thread.Sleep(2000)


    End Sub

    Sub LoadContent()

        Dim theFilename = (Content)
        Dim whereToStartReading As Long = 0

        Dim fileStram As FileStream = New FileStream(theFilename, FileMode.Open, FileAccess.Read)

        Dim buffer() As Byte = New Byte((megabyte) - 1) {}
        fileStram.Seek(whereToStartReading, SeekOrigin.Begin)
        Dim bytesRead As Integer = fileStram.Read(buffer, 0, megabyte)

        While (bytesRead > 0)
            ProcessChunk(buffer, bytesRead)
            bytesRead = fileStram.Read(buffer, 0, megabyte)

        End While

        Console.WriteLine("Content Loaded!")

        System.Threading.Thread.Sleep(2000)


    End Sub

    Sub LoadMonuments()

        Dim theFilename = (Monuments)
        Dim whereToStartReading As Long = 0

        Dim fileStram As FileStream = New FileStream(theFilename, FileMode.Open, FileAccess.Read)

        Dim buffer() As Byte = New Byte((megabyte) - 1) {}
        fileStram.Seek(whereToStartReading, SeekOrigin.Begin)
        Dim bytesRead As Integer = fileStram.Read(buffer, 0, megabyte)

        While (bytesRead > 0)
            ProcessChunk(buffer, bytesRead)
            bytesRead = fileStram.Read(buffer, 0, megabyte)

        End While

        Console.WriteLine("Monuments Loaded!")

        System.Threading.Thread.Sleep(2000)


    End Sub

    Sub LoadTextures()

        Dim theFilename = (Textures)
        Dim whereToStartReading As Long = 0

        Dim fileStram As FileStream = New FileStream(theFilename, FileMode.Open, FileAccess.Read)

        Dim buffer() As Byte = New Byte((megabyte) - 1) {}
        fileStram.Seek(whereToStartReading, SeekOrigin.Begin)
        Dim bytesRead As Integer = fileStram.Read(buffer, 0, megabyte)

        While (bytesRead > 0)
            ProcessChunk(buffer, bytesRead)
            bytesRead = fileStram.Read(buffer, 0, megabyte)

        End While

        Console.WriteLine("Textures Loaded!")

        System.Threading.Thread.Sleep(2000)


    End Sub

    Sub LoadMaps()

        Dim theFilename = (Maps)
        Dim whereToStartReading As Long = 0

        Dim fileStram As FileStream = New FileStream(theFilename, FileMode.Open, FileAccess.Read)

        Dim buffer() As Byte = New Byte((megabyte) - 1) {}
        fileStram.Seek(whereToStartReading, SeekOrigin.Begin)
        Dim bytesRead As Integer = fileStram.Read(buffer, 0, megabyte)

        While (bytesRead > 0)
            ProcessChunk(buffer, bytesRead)
            bytesRead = fileStram.Read(buffer, 0, megabyte)

        End While

        Console.WriteLine("Maps Loaded!")

        System.Threading.Thread.Sleep(2000)


    End Sub

    Private Sub ProcessChunk(ByVal buffer() As Byte, ByVal bytesRead As Integer)
        ' Do the processing here
    End Sub

    Sub OnClose(sender As Object, e As EventArgs)

        Dim Rust As String

        Try
            Rust = System.IO.File.ReadAllLines("config.txt")(5)
            Console.WriteLine(Rust.ToString & " Found!")
        Catch
        End Try

        Console.ForegroundColor = ConsoleColor.Green

        Console.WriteLine("")
        Console.WriteLine("Done!")

        System.Threading.Thread.Sleep(1000)

    End Sub

End Module
