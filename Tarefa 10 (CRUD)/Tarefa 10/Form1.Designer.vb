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
        Me.LblID = New System.Windows.Forms.Label()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.TxtUtilizador = New System.Windows.Forms.TextBox()
        Me.TxtSenha = New System.Windows.Forms.TextBox()
        Me.CbNivel = New System.Windows.Forms.ComboBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.DgLista = New System.Windows.Forms.DataGridView()
        Me.LblNome = New System.Windows.Forms.Label()
        Me.LblUtilizador = New System.Windows.Forms.Label()
        Me.LblSenha = New System.Windows.Forms.Label()
        Me.LblNivel = New System.Windows.Forms.Label()
        CType(Me.DgLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Location = New System.Drawing.Point(421, 117)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(21, 13)
        Me.LblID.TabIndex = 0
        Me.LblID.Text = "ID:"
        '
        'TxtNome
        '
        Me.TxtNome.Location = New System.Drawing.Point(162, 100)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(178, 20)
        Me.TxtNome.TabIndex = 1
        '
        'TxtUtilizador
        '
        Me.TxtUtilizador.Location = New System.Drawing.Point(162, 141)
        Me.TxtUtilizador.Name = "TxtUtilizador"
        Me.TxtUtilizador.Size = New System.Drawing.Size(178, 20)
        Me.TxtUtilizador.TabIndex = 2
        '
        'TxtSenha
        '
        Me.TxtSenha.Location = New System.Drawing.Point(162, 186)
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TxtSenha.Size = New System.Drawing.Size(178, 20)
        Me.TxtSenha.TabIndex = 3
        '
        'CbNivel
        '
        Me.CbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbNivel.FormattingEnabled = True
        Me.CbNivel.Items.AddRange(New Object() {"Equipa", "Administrador"})
        Me.CbNivel.Location = New System.Drawing.Point(162, 231)
        Me.CbNivel.Name = "CbNivel"
        Me.CbNivel.Size = New System.Drawing.Size(178, 21)
        Me.CbNivel.TabIndex = 4
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(462, 12)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(144, 38)
        Me.BtnDelete.TabIndex = 5
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(312, 12)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(144, 38)
        Me.BtnUpdate.TabIndex = 6
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnReload
        '
        Me.BtnReload.Location = New System.Drawing.Point(162, 12)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(144, 38)
        Me.BtnReload.TabIndex = 7
        Me.BtnReload.Text = "Reload"
        Me.BtnReload.UseVisualStyleBackColor = True
        '
        'BtnCreate
        '
        Me.BtnCreate.Location = New System.Drawing.Point(12, 12)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(144, 36)
        Me.BtnCreate.TabIndex = 8
        Me.BtnCreate.Text = "Create"
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'DgLista
        '
        Me.DgLista.AllowUserToAddRows = False
        Me.DgLista.AllowUserToDeleteRows = False
        Me.DgLista.AllowUserToResizeColumns = False
        Me.DgLista.AllowUserToResizeRows = False
        Me.DgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgLista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgLista.Location = New System.Drawing.Point(12, 288)
        Me.DgLista.Name = "DgLista"
        Me.DgLista.RowHeadersVisible = False
        Me.DgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgLista.Size = New System.Drawing.Size(594, 150)
        Me.DgLista.TabIndex = 9
        '
        'LblNome
        '
        Me.LblNome.AutoSize = True
        Me.LblNome.Location = New System.Drawing.Point(104, 103)
        Me.LblNome.Name = "LblNome"
        Me.LblNome.Size = New System.Drawing.Size(38, 13)
        Me.LblNome.TabIndex = 10
        Me.LblNome.Text = "Nome:"
        '
        'LblUtilizador
        '
        Me.LblUtilizador.AutoSize = True
        Me.LblUtilizador.Location = New System.Drawing.Point(92, 144)
        Me.LblUtilizador.Name = "LblUtilizador"
        Me.LblUtilizador.Size = New System.Drawing.Size(50, 13)
        Me.LblUtilizador.TabIndex = 11
        Me.LblUtilizador.Text = "Utilizador"
        '
        'LblSenha
        '
        Me.LblSenha.AutoSize = True
        Me.LblSenha.Location = New System.Drawing.Point(89, 189)
        Me.LblSenha.Name = "LblSenha"
        Me.LblSenha.Size = New System.Drawing.Size(53, 13)
        Me.LblSenha.TabIndex = 12
        Me.LblSenha.Text = "Password"
        '
        'LblNivel
        '
        Me.LblNivel.AutoSize = True
        Me.LblNivel.Location = New System.Drawing.Point(58, 234)
        Me.LblNivel.Name = "LblNivel"
        Me.LblNivel.Size = New System.Drawing.Size(84, 13)
        Me.LblNivel.TabIndex = 13
        Me.LblNivel.Text = "Nivel de Acesso"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 450)
        Me.Controls.Add(Me.LblNivel)
        Me.Controls.Add(Me.LblSenha)
        Me.Controls.Add(Me.LblUtilizador)
        Me.Controls.Add(Me.LblNome)
        Me.Controls.Add(Me.DgLista)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.BtnReload)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.CbNivel)
        Me.Controls.Add(Me.TxtSenha)
        Me.Controls.Add(Me.TxtUtilizador)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.LblID)
        Me.Name = "Form1"
        Me.Text = "CRUD - Utilizadores"
        CType(Me.DgLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblID As Label
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents TxtUtilizador As TextBox
    Friend WithEvents TxtSenha As TextBox
    Friend WithEvents CbNivel As ComboBox
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnReload As Button
    Friend WithEvents BtnCreate As Button
    Friend WithEvents DgLista As DataGridView
    Friend WithEvents LblNome As Label
    Friend WithEvents LblUtilizador As Label
    Friend WithEvents LblSenha As Label
    Friend WithEvents LblNivel As Label
End Class
