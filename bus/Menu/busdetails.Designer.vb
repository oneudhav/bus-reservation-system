<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class busdetails
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.BusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(306, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bus Details"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(794, 501)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 31)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BusBindingSource
        '
        Me.BusBindingSource.DataMember = "bus"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.Location = New System.Drawing.Point(32, 88)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(831, 395)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Bus Number"
        Me.ColumnHeader1.Width = 191
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Bus Type"
        Me.ColumnHeader2.Width = 179
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Company Name"
        Me.ColumnHeader3.Width = 169
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Total Seat"
        Me.ColumnHeader4.Width = 131
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(32, 51)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 31)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Refresh"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'busdetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(888, 533)
        Me.ControlBox = False
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "busdetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bus Details"
        CType(Me.BusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

    Friend WithEvents BusBindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
