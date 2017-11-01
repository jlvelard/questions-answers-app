<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateQuestion
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
        Me.tbUpdateQuestion = New System.Windows.Forms.TextBox()
        Me.btnUpdateQuestionSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbUpdateQuestion
        '
        Me.tbUpdateQuestion.Location = New System.Drawing.Point(13, 13)
        Me.tbUpdateQuestion.Multiline = True
        Me.tbUpdateQuestion.Name = "tbUpdateQuestion"
        Me.tbUpdateQuestion.Size = New System.Drawing.Size(600, 373)
        Me.tbUpdateQuestion.TabIndex = 0
        '
        'btnUpdateQuestionSubmit
        '
        Me.btnUpdateQuestionSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateQuestionSubmit.Location = New System.Drawing.Point(13, 393)
        Me.btnUpdateQuestionSubmit.Name = "btnUpdateQuestionSubmit"
        Me.btnUpdateQuestionSubmit.Size = New System.Drawing.Size(600, 80)
        Me.btnUpdateQuestionSubmit.TabIndex = 1
        Me.btnUpdateQuestionSubmit.Text = "Submit"
        Me.btnUpdateQuestionSubmit.UseVisualStyleBackColor = True
        '
        'UpdateQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 485)
        Me.Controls.Add(Me.btnUpdateQuestionSubmit)
        Me.Controls.Add(Me.tbUpdateQuestion)
        Me.Name = "UpdateQuestion"
        Me.Text = "UpdateQuestion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbUpdateQuestion As TextBox
    Friend WithEvents btnUpdateQuestionSubmit As Button
End Class
