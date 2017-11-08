
Public Class welcome
    Protected db As New db
    Protected Sub LoadQuestions()
        db.sql = "SELECT * FROM questions ORDER BY created_at DESC;"
        db.fill(dgvQuestions)
    End Sub
    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
        LoadQuestions()
    End Sub

    Private Sub welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadQuestions()
    End Sub

    Private Sub CreateQuestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateQuestionToolStripMenuItem.Click
        CreateQuestion.ShowDialog()
        LoadQuestions()
    End Sub

    Private Sub UpdateQuestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateQuestionToolStripMenuItem.Click
        Dim updateQuestionForm As New UpdateQuestion(getQuestionId())
        updateQuestionForm.ShowDialog()
        LoadQuestions()
    End Sub

    Public Function getQuestionId() As Integer
        Return getQuestionValue("id")
    End Function

    Public Function getQuestionValue(ByVal column As String)
        Return dgvQuestions.Item(column, dgvQuestions.CurrentRow.Index).Value
    End Function

    Private Sub DeleteQuestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteQuestionToolStripMenuItem.Click
        Dim confirmed As Integer = MessageBox.Show("Are you sure you want to delete this?", "Delete", MessageBoxButtons.YesNoCancel)

        If confirmed = DialogResult.Yes Then
            db.sql = "DELETE FROM questions WHERE id = @question_id"
            db.bind("@question_id", getQuestionId())
            db.execute()
            LoadQuestions()
        End If
    End Sub

    Private Sub ShowFNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowFNameToolStripMenuItem.Click

        db.sql = "SELECT 
	[isys4283-2017fa].[dbo].[questions].[id]
      ,[isys4283-2017fa].[dbo].[users].[username]
      ,[first_name]
      ,[last_name]
	  ,[question]
      ,[user_login]
      ,[created_at]
      ,[updated_at]
      ,[invalid]
	  	  

  FROM [isys4283-2017fa].[dbo].[users] JOIN [isys4283-2017fa].[dbo].[questions]
  ON [isys4283-2017fa].[dbo].[users].[username] = [isys4283-2017fa].[dbo].[questions].[user_login]
  ORDER BY created_at DESC"
        db.fill(dgvQuestions)
        db.execute()

    End Sub
End Class