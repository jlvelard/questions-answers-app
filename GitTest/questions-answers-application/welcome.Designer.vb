<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class welcome
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
        Me.welcomeMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateQuestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateQuestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteQuestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowFNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvQuestions = New System.Windows.Forms.DataGridView()
        Me.welcomeMenuStrip.SuspendLayout()
        CType(Me.dgvQuestions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'welcomeMenuStrip
        '
        Me.welcomeMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadToolStripMenuItem, Me.CreateQuestionToolStripMenuItem, Me.UpdateQuestionToolStripMenuItem, Me.DeleteQuestionToolStripMenuItem, Me.ShowFNameToolStripMenuItem})
        Me.welcomeMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.welcomeMenuStrip.Name = "welcomeMenuStrip"
        Me.welcomeMenuStrip.Size = New System.Drawing.Size(1014, 24)
        Me.welcomeMenuStrip.TabIndex = 0
        Me.welcomeMenuStrip.Text = "MenuStrip1"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(140, 20)
        Me.LoadToolStripMenuItem.Text = "Load Recent Questions"
        '
        'CreateQuestionToolStripMenuItem
        '
        Me.CreateQuestionToolStripMenuItem.Name = "CreateQuestionToolStripMenuItem"
        Me.CreateQuestionToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.CreateQuestionToolStripMenuItem.Text = "Create Question"
        '
        'UpdateQuestionToolStripMenuItem
        '
        Me.UpdateQuestionToolStripMenuItem.Name = "UpdateQuestionToolStripMenuItem"
        Me.UpdateQuestionToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.UpdateQuestionToolStripMenuItem.Text = "Update Question"
        '
        'DeleteQuestionToolStripMenuItem
        '
        Me.DeleteQuestionToolStripMenuItem.Name = "DeleteQuestionToolStripMenuItem"
        Me.DeleteQuestionToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.DeleteQuestionToolStripMenuItem.Text = "Delete Question"
        '
        'ShowFNameToolStripMenuItem
        '
        Me.ShowFNameToolStripMenuItem.Name = "ShowFNameToolStripMenuItem"
        Me.ShowFNameToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.ShowFNameToolStripMenuItem.Text = "Show Name"
        '
        'dgvQuestions
        '
        Me.dgvQuestions.AllowUserToAddRows = False
        Me.dgvQuestions.AllowUserToDeleteRows = False
        Me.dgvQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQuestions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvQuestions.Location = New System.Drawing.Point(0, 24)
        Me.dgvQuestions.Name = "dgvQuestions"
        Me.dgvQuestions.ReadOnly = True
        Me.dgvQuestions.Size = New System.Drawing.Size(1014, 586)
        Me.dgvQuestions.TabIndex = 1
        '
        'welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 610)
        Me.Controls.Add(Me.dgvQuestions)
        Me.Controls.Add(Me.welcomeMenuStrip)
        Me.MainMenuStrip = Me.welcomeMenuStrip
        Me.Name = "welcome"
        Me.Text = "Welcome"
        Me.welcomeMenuStrip.ResumeLayout(False)
        Me.welcomeMenuStrip.PerformLayout()
        CType(Me.dgvQuestions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents welcomeMenuStrip As MenuStrip
    Friend WithEvents LoadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvQuestions As DataGridView
    Friend WithEvents CreateQuestionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateQuestionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteQuestionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowFNameToolStripMenuItem As ToolStripMenuItem
End Class
