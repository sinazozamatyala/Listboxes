<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnDeleteSelected = New Button()
        btnAdd = New Button()
        btnRemove = New Button()
        btnClear = New Button()
        ListBox1 = New ListBox()
        SuspendLayout()
        ' 
        ' btnDeleteSelected
        ' 
        btnDeleteSelected.Location = New Point(253, 199)
        btnDeleteSelected.Name = "btnDeleteSelected"
        btnDeleteSelected.Size = New Size(94, 29)
        btnDeleteSelected.TabIndex = 0
        btnDeleteSelected.Text = "Delete Selected"
        btnDeleteSelected.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(253, 52)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 29)
        btnAdd.TabIndex = 1
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        btnRemove.Location = New Point(253, 128)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(94, 29)
        btnRemove.TabIndex = 2
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(253, 269)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 3
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Items.AddRange(New Object() {"iPhone", "Huawei", "Samsung", "Sony", "Alcatel"})
        ListBox1.Location = New Point(66, 47)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(171, 244)
        ListBox1.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ListBox1)
        Controls.Add(btnClear)
        Controls.Add(btnRemove)
        Controls.Add(btnAdd)
        Controls.Add(btnDeleteSelected)
        ForeColor = SystemColors.Highlight
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnDeleteSelected As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents ListBox1 As ListBox

End Class
