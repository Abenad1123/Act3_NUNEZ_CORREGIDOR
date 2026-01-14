<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.enroll_btn = New System.Windows.Forms.PictureBox()
        Me.go_back_btn = New System.Windows.Forms.PictureBox()
        Me.about_btn = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.enroll_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.go_back_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.about_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.enroll_btn, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.go_back_btn, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.about_btn, 5, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'enroll_btn
        '
        Me.enroll_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.enroll_btn.Image = Global.ACT3_NUÑEZ_CORREGIDOR.My.Resources.Resources.enroll_btn
        Me.enroll_btn.Location = New System.Drawing.Point(387, 30)
        Me.enroll_btn.MaximumSize = New System.Drawing.Size(236, 75)
        Me.enroll_btn.Name = "enroll_btn"
        Me.enroll_btn.Size = New System.Drawing.Size(114, 39)
        Me.enroll_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.enroll_btn.TabIndex = 0
        Me.enroll_btn.TabStop = False
        '
        'go_back_btn
        '
        Me.go_back_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.go_back_btn.Image = Global.ACT3_NUÑEZ_CORREGIDOR.My.Resources.Resources.go_back_btn
        Me.go_back_btn.Location = New System.Drawing.Point(523, 30)
        Me.go_back_btn.MaximumSize = New System.Drawing.Size(236, 75)
        Me.go_back_btn.Name = "go_back_btn"
        Me.go_back_btn.Size = New System.Drawing.Size(114, 39)
        Me.go_back_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.go_back_btn.TabIndex = 1
        Me.go_back_btn.TabStop = False
        '
        'about_btn
        '
        Me.about_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.about_btn.Image = Global.ACT3_NUÑEZ_CORREGIDOR.My.Resources.Resources.about_btn
        Me.about_btn.Location = New System.Drawing.Point(659, 30)
        Me.about_btn.MaximumSize = New System.Drawing.Size(236, 75)
        Me.about_btn.Name = "about_btn"
        Me.about_btn.Size = New System.Drawing.Size(114, 39)
        Me.about_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.about_btn.TabIndex = 2
        Me.about_btn.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ACT3_NUÑEZ_CORREGIDOR.My.Resources.Resources.main_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.Text = "De La Salle Santiago Zobel"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.enroll_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.go_back_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.about_btn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents enroll_btn As PictureBox
    Friend WithEvents go_back_btn As PictureBox
    Friend WithEvents about_btn As PictureBox
End Class
