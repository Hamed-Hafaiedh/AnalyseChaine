<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        Label2 = New Label()
        chaineEntrer = New TextBox()
        maj = New Button()
        min = New Button()
        longu = New Button()
        remp = New Button()
        decop = New Button()
        chaineReturne = New TextBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Info
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(65, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(314, 41)
        Label1.TabIndex = 0
        Label1.Text = "Analyse d'une chaine"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Info
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(65, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(213, 31)
        Label2.TabIndex = 1
        Label2.Text = "Entrer une chaine :"
        ' 
        ' chaineEntrer
        ' 
        chaineEntrer.BackColor = SystemColors.Info
        chaineEntrer.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chaineEntrer.Location = New Point(284, 106)
        chaineEntrer.Multiline = True
        chaineEntrer.Name = "chaineEntrer"
        chaineEntrer.Size = New Size(400, 40)
        chaineEntrer.TabIndex = 2
        ' 
        ' maj
        ' 
        maj.BackColor = SystemColors.Info
        maj.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        maj.Location = New Point(65, 196)
        maj.Name = "maj"
        maj.Size = New Size(200, 50)
        maj.TabIndex = 3
        maj.Text = "Majuscules"
        maj.UseVisualStyleBackColor = False
        ' 
        ' min
        ' 
        min.BackColor = SystemColors.Info
        min.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        min.Location = New Point(286, 196)
        min.Name = "min"
        min.Size = New Size(200, 50)
        min.TabIndex = 4
        min.Text = "Minuscules"
        min.UseVisualStyleBackColor = False
        ' 
        ' longu
        ' 
        longu.BackColor = SystemColors.Info
        longu.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        longu.Location = New Point(511, 196)
        longu.Name = "longu"
        longu.Size = New Size(200, 50)
        longu.TabIndex = 5
        longu.Text = "Longueur"
        longu.UseVisualStyleBackColor = False
        ' 
        ' remp
        ' 
        remp.BackColor = SystemColors.Info
        remp.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        remp.Location = New Point(65, 279)
        remp.Name = "remp"
        remp.Size = New Size(200, 50)
        remp.TabIndex = 6
        remp.Text = "Remplacer"
        remp.UseVisualStyleBackColor = False
        ' 
        ' decop
        ' 
        decop.BackColor = SystemColors.Info
        decop.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        decop.Location = New Point(286, 279)
        decop.Name = "decop"
        decop.Size = New Size(200, 50)
        decop.TabIndex = 7
        decop.Text = "Decouper"
        decop.UseVisualStyleBackColor = False
        ' 
        ' chaineReturne
        ' 
        chaineReturne.BackColor = SystemColors.Info
        chaineReturne.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chaineReturne.Location = New Point(286, 352)
        chaineReturne.Multiline = True
        chaineReturne.Name = "chaineReturne"
        chaineReturne.Size = New Size(400, 86)
        chaineReturne.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Info
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(131, 383)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 31)
        Label3.TabIndex = 9
        Label3.Text = "Resultas :"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(chaineReturne)
        Controls.Add(decop)
        Controls.Add(remp)
        Controls.Add(longu)
        Controls.Add(min)
        Controls.Add(maj)
        Controls.Add(chaineEntrer)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Analyse D'une Chaine"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chaineEntrer As TextBox
    Friend WithEvents maj As Button
    Friend WithEvents min As Button
    Friend WithEvents longu As Button
    Friend WithEvents remp As Button
    Friend WithEvents decop As Button
    Friend WithEvents chaineReturne As TextBox
    Friend WithEvents Label3 As Label

End Class
