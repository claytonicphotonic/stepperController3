Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel


Public Class Form1
    ' Shared SerialPort3 As New SerialPort 'note: if you see a "SerialPort2" at the bottom of the design no need to declare it here
    Dim myPort As Array
    Delegate Sub SetTextCallBack(ByVal [text] As String)

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        myPort = IO.Ports.SerialPort.GetPortNames()
        portComboBox.Items.AddRange(myPort)   'add a change here for github testing
        writeButton.Enabled = False
        closeButton.Enabled = False
        fanButton.Enabled = False

    End Sub

    Private Sub initButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles initButton.Click
        SerialPort2.PortName = portComboBox.Text
        SerialPort2.BaudRate = baudComboBox.Text
        SerialPort2.Open()

        initButton.Enabled = False
        writeButton.Enabled = True
        closeButton.Enabled = True
        fanButton.Enabled = True
    End Sub


    Private Sub writeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles writeButton.Click
        outputTextBox.Clear()
        SerialPort2.Write(inputTextBox.Text & vbCr)
        Dim Incoming As String = SerialPort2.ReadLine()
        RecievedText(Incoming)
        'Thread.Sleep(10)
        'RecievedText(SerialPort2.ReadExisting())

    End Sub

    Private Sub closeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeButton.Click
        SerialPort2.Close()
        initButton.Enabled = True
        writeButton.Enabled = False
        closeButton.Enabled = False
        fanButton.Enabled = False

    End Sub

    Public Sub RecievedText(ByVal [text] As String)

        If Me.outputTextBox.InvokeRequired Then
            Dim x As New SetTextCallBack(AddressOf RecievedText)
            Me.Invoke(x, New Object, {(text)})
        Else
            Me.outputTextBox.Text &= [text]
        End If
    End Sub

    Private Sub fanButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fanButton.Click
        SerialPort2.Write("F")
    End Sub

    Private Sub downButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles downButton.Click
        outputTextBox.Clear()
        SerialPort2.Write("-" + tuneTextBox.Text & vbCr)
        Dim Incoming As String = SerialPort2.ReadLine()
        RecievedText(Incoming)
    End Sub

    Private Sub upButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upButton.Click
        outputTextBox.Clear()
        SerialPort2.Write(tuneTextBox.Text & vbCr)
        Dim Incoming As String = SerialPort2.ReadLine()
        RecievedText(Incoming)
    End Sub
End Class
