<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.writeButton = New System.Windows.Forms.Button()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.initButton = New System.Windows.Forms.Button()
        Me.downButton = New System.Windows.Forms.Button()
        Me.upButton = New System.Windows.Forms.Button()
        Me.inputTextBox = New System.Windows.Forms.RichTextBox()
        Me.outputTextBox = New System.Windows.Forms.RichTextBox()
        Me.portComboBox = New System.Windows.Forms.ComboBox()
        Me.baudComboBox = New System.Windows.Forms.ComboBox()
        Me.tuneTextBox = New System.Windows.Forms.RichTextBox()
        Me.out = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fanButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SerialPort2 = New System.IO.Ports.SerialPort(Me.components)
        Me.BarCheckBox = New System.Windows.Forms.CheckBox()
        Me.FiberCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'writeButton
        '
        Me.writeButton.Location = New System.Drawing.Point(206, 148)
        Me.writeButton.Name = "writeButton"
        Me.writeButton.Size = New System.Drawing.Size(99, 42)
        Me.writeButton.TabIndex = 0
        Me.writeButton.Text = "WRITE"
        Me.writeButton.UseVisualStyleBackColor = True
        '
        'closeButton
        '
        Me.closeButton.Location = New System.Drawing.Point(911, 368)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(173, 51)
        Me.closeButton.TabIndex = 1
        Me.closeButton.Text = "CLOSE"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'initButton
        '
        Me.initButton.Location = New System.Drawing.Point(875, 33)
        Me.initButton.Name = "initButton"
        Me.initButton.Size = New System.Drawing.Size(173, 51)
        Me.initButton.TabIndex = 2
        Me.initButton.Text = "INIT"
        Me.initButton.UseVisualStyleBackColor = True
        '
        'downButton
        '
        Me.downButton.Location = New System.Drawing.Point(113, 348)
        Me.downButton.Name = "downButton"
        Me.downButton.Size = New System.Drawing.Size(129, 41)
        Me.downButton.TabIndex = 3
        Me.downButton.Text = "BACK"
        Me.downButton.UseVisualStyleBackColor = True
        '
        'upButton
        '
        Me.upButton.Location = New System.Drawing.Point(113, 284)
        Me.upButton.Name = "upButton"
        Me.upButton.Size = New System.Drawing.Size(129, 38)
        Me.upButton.TabIndex = 4
        Me.upButton.Text = "FWD"
        Me.upButton.UseVisualStyleBackColor = True
        '
        'inputTextBox
        '
        Me.inputTextBox.Location = New System.Drawing.Point(12, 148)
        Me.inputTextBox.Name = "inputTextBox"
        Me.inputTextBox.Size = New System.Drawing.Size(188, 42)
        Me.inputTextBox.TabIndex = 5
        Me.inputTextBox.Text = ""
        '
        'outputTextBox
        '
        Me.outputTextBox.Location = New System.Drawing.Point(12, 226)
        Me.outputTextBox.Name = "outputTextBox"
        Me.outputTextBox.Size = New System.Drawing.Size(215, 40)
        Me.outputTextBox.TabIndex = 6
        Me.outputTextBox.Text = ""
        '
        'portComboBox
        '
        Me.portComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.portComboBox.FormattingEnabled = True
        Me.portComboBox.Location = New System.Drawing.Point(705, 39)
        Me.portComboBox.Name = "portComboBox"
        Me.portComboBox.Size = New System.Drawing.Size(148, 24)
        Me.portComboBox.TabIndex = 7
        '
        'baudComboBox
        '
        Me.baudComboBox.AllowDrop = True
        Me.baudComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.baudComboBox.FormattingEnabled = True
        Me.baudComboBox.Items.AddRange(New Object() {"9600", "115200", "250000"})
        Me.baudComboBox.Location = New System.Drawing.Point(705, 123)
        Me.baudComboBox.Name = "baudComboBox"
        Me.baudComboBox.Size = New System.Drawing.Size(148, 24)
        Me.baudComboBox.TabIndex = 8
        '
        'tuneTextBox
        '
        Me.tuneTextBox.Location = New System.Drawing.Point(12, 317)
        Me.tuneTextBox.Name = "tuneTextBox"
        Me.tuneTextBox.Size = New System.Drawing.Size(95, 34)
        Me.tuneTextBox.TabIndex = 9
        Me.tuneTextBox.Text = ""
        '
        'out
        '
        Me.out.AutoSize = True
        Me.out.Location = New System.Drawing.Point(12, 197)
        Me.out.Name = "out"
        Me.out.Size = New System.Drawing.Size(62, 17)
        Me.out.TabIndex = 10
        Me.out.Text = "Location"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Input"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(703, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Select Port"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(703, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Select Baud Rate"
        '
        'fanButton
        '
        Me.fanButton.Location = New System.Drawing.Point(897, 102)
        Me.fanButton.Name = "fanButton"
        Me.fanButton.Size = New System.Drawing.Size(163, 73)
        Me.fanButton.TabIndex = 14
        Me.fanButton.Text = "FAN ON/OFF"
        Me.fanButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Fine Tune"
        '
        'BarCheckBox
        '
        Me.BarCheckBox.AutoSize = True
        Me.BarCheckBox.Checked = True
        Me.BarCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BarCheckBox.Location = New System.Drawing.Point(168, 81)
        Me.BarCheckBox.Name = "BarCheckBox"
        Me.BarCheckBox.Size = New System.Drawing.Size(93, 21)
        Me.BarCheckBox.TabIndex = 23
        Me.BarCheckBox.Text = "Bar Stage"
        Me.BarCheckBox.UseVisualStyleBackColor = True
        '
        'FiberCheckBox
        '
        Me.FiberCheckBox.AutoSize = True
        Me.FiberCheckBox.Checked = True
        Me.FiberCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FiberCheckBox.Location = New System.Drawing.Point(12, 81)
        Me.FiberCheckBox.Name = "FiberCheckBox"
        Me.FiberCheckBox.Size = New System.Drawing.Size(127, 21)
        Me.FiberCheckBox.TabIndex = 24
        Me.FiberCheckBox.Text = "Fiber/I.S. Stage"
        Me.FiberCheckBox.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(10, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 25)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Select a motor"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 431)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.FiberCheckBox)
        Me.Controls.Add(Me.BarCheckBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.fanButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.out)
        Me.Controls.Add(Me.tuneTextBox)
        Me.Controls.Add(Me.baudComboBox)
        Me.Controls.Add(Me.portComboBox)
        Me.Controls.Add(Me.outputTextBox)
        Me.Controls.Add(Me.inputTextBox)
        Me.Controls.Add(Me.upButton)
        Me.Controls.Add(Me.downButton)
        Me.Controls.Add(Me.initButton)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.writeButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents writeButton As System.Windows.Forms.Button
    Friend WithEvents closeButton As System.Windows.Forms.Button
    Friend WithEvents initButton As System.Windows.Forms.Button
    Friend WithEvents downButton As System.Windows.Forms.Button
    Friend WithEvents upButton As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents inputTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents outputTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents portComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents baudComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents tuneTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents out As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fanButton As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SerialPort2 As System.IO.Ports.SerialPort
    Friend WithEvents BarCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FiberCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
