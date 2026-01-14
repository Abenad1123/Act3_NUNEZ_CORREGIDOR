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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.enroll_btn = New System.Windows.Forms.PictureBox()
        Me.acad_btn = New System.Windows.Forms.PictureBox()
        Me.about_btn = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.enroll_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.acad_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.about_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.enroll_btn, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.acad_btn, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.about_btn, 5, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.476674!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.736308!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.78702!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(942, 493)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'enroll_btn
        '
        Me.enroll_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.enroll_btn.Image = Global.ACT3_NUÑEZ_CORREGIDOR.My.Resources.Resources.enroll_btn
        Me.enroll_btn.Location = New System.Drawing.Point(455, 30)
        Me.enroll_btn.Name = "enroll_btn"
        Me.enroll_btn.Size = New System.Drawing.Size(135, 42)
        Me.enroll_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.enroll_btn.TabIndex = 0
        Me.enroll_btn.TabStop = False
        '
        'acad_btn
        '
        Me.acad_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.acad_btn.Image = Global.ACT3_NUÑEZ_CORREGIDOR.My.Resources.Resources.acad_calendar_btn
        Me.acad_btn.Location = New System.Drawing.Point(610, 30)
        Me.acad_btn.Name = "acad_btn"
        Me.acad_btn.Size = New System.Drawing.Size(135, 42)
        Me.acad_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.acad_btn.TabIndex = 1
        Me.acad_btn.TabStop = False
        '
        'about_btn
        '
        Me.about_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.about_btn.Image = Global.ACT3_NUÑEZ_CORREGIDOR.My.Resources.Resources.about_btn
        Me.about_btn.Location = New System.Drawing.Point(765, 30)
        Me.about_btn.Name = "about_btn"
        Me.about_btn.Size = New System.Drawing.Size(135, 42)
        Me.about_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.about_btn.TabIndex = 2
        Me.about_btn.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ACT3_NUÑEZ_CORREGIDOR.My.Resources.Resources.main_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(942, 493)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.enroll_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.acad_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.about_btn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents enroll_btn As PictureBox
    Friend WithEvents acad_btn As PictureBox
    Friend WithEvents about_btn As PictureBox
End Class
