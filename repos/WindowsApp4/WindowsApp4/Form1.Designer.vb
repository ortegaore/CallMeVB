<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PerformanceCounter1 = New System.Diagnostics.PerformanceCounter()
        Me.PerformanceCounter2 = New System.Diagnostics.PerformanceCounter()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerformanceCounter2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PerformanceCounter1
        '
        Me.PerformanceCounter1.CategoryName = "Disco lógico"
        Me.PerformanceCounter1.CounterName = "% de espacio disponible"
        Me.PerformanceCounter1.InstanceName = "HarddiskVolume1"
        Me.PerformanceCounter1.MachineName = "JOSEORTEGA"
        '
        'PerformanceCounter2
        '
        Me.PerformanceCounter2.CategoryName = "Disco lógico"
        Me.PerformanceCounter2.CounterName = "% de espacio disponible"
        Me.PerformanceCounter2.InstanceName = "HarddiskVolume1"
        Me.PerformanceCounter2.MachineName = "JOSEORTEGA"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(75, 46)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(59, 13)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkLabel1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerformanceCounter2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PerformanceCounter1 As PerformanceCounter
    Friend WithEvents PerformanceCounter2 As PerformanceCounter
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
