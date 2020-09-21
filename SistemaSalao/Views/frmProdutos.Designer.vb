<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdutos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProdutos))
        Me.txtTamanhoFrasco = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.dtGridClientes = New System.Windows.Forms.DataGridView()
        Me.lblId = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.cbxUnidadeFrasco = New System.Windows.Forms.ComboBox()
        Me.cbxUnidRef = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPesoUnidRef = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.cbxFornecedor = New System.Windows.Forms.ComboBox()
        Me.img = New System.Windows.Forms.PictureBox()
        Me.btnAdicionarImagem = New System.Windows.Forms.Button()
        Me.txtPrecoUnidade = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.dtGridClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTamanhoFrasco
        '
        Me.txtTamanhoFrasco.Location = New System.Drawing.Point(411, 17)
        Me.txtTamanhoFrasco.Name = "txtTamanhoFrasco"
        Me.txtTamanhoFrasco.Size = New System.Drawing.Size(100, 20)
        Me.txtTamanhoFrasco.TabIndex = 66
        Me.txtTamanhoFrasco.Tag = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(315, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 13)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "Tamanho Frasco:"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.ForeColor = System.Drawing.Color.Transparent
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(390, 358)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 65)
        Me.btnCancelar.TabIndex = 64
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.Transparent
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream
        Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.ForeColor = System.Drawing.Color.Transparent
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.Location = New System.Drawing.Point(499, 358)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 65)
        Me.btnExcluir.TabIndex = 63
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Transparent
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.ForeColor = System.Drawing.Color.Transparent
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(287, 358)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 65)
        Me.btnEditar.TabIndex = 62
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalvar.FlatAppearance.BorderSize = 0
        Me.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream
        Me.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.ForeColor = System.Drawing.Color.Transparent
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.Location = New System.Drawing.Point(180, 358)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 65)
        Me.btnSalvar.TabIndex = 61
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.Transparent
        Me.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNovo.FlatAppearance.BorderSize = 0
        Me.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream
        Me.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.ForeColor = System.Drawing.Color.Transparent
        Me.btnNovo.Image = Global.SistemaSalao.My.Resources.Resources.btnNovo
        Me.btnNovo.Location = New System.Drawing.Point(84, 358)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(75, 65)
        Me.btnNovo.TabIndex = 60
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'dtGridClientes
        '
        Me.dtGridClientes.AllowUserToAddRows = False
        Me.dtGridClientes.AllowUserToDeleteRows = False
        Me.dtGridClientes.BackgroundColor = System.Drawing.Color.MintCream
        Me.dtGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGridClientes.Location = New System.Drawing.Point(13, 162)
        Me.dtGridClientes.Name = "dtGridClientes"
        Me.dtGridClientes.ReadOnly = True
        Me.dtGridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtGridClientes.Size = New System.Drawing.Size(661, 190)
        Me.dtGridClientes.TabIndex = 59
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.Location = New System.Drawing.Point(23, 15)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(0, 13)
        Me.lblId.TabIndex = 54
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(360, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Unidade Frasco:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(398, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(18, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Fornecedor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(43, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Nome:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(84, 17)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(220, 20)
        Me.txtNome.TabIndex = 37
        Me.txtNome.Tag = "*Obr"
        '
        'cbxUnidadeFrasco
        '
        Me.cbxUnidadeFrasco.FormattingEnabled = True
        Me.cbxUnidadeFrasco.Items.AddRange(New Object() {"ml", "g", "unid."})
        Me.cbxUnidadeFrasco.Location = New System.Drawing.Point(446, 70)
        Me.cbxUnidadeFrasco.Name = "cbxUnidadeFrasco"
        Me.cbxUnidadeFrasco.Size = New System.Drawing.Size(79, 21)
        Me.cbxUnidadeFrasco.TabIndex = 69
        '
        'cbxUnidRef
        '
        Me.cbxUnidRef.FormattingEnabled = True
        Me.cbxUnidRef.Items.AddRange(New Object() {"gotas", "ml", "Espátula", "Peso copo 7,5 ml"})
        Me.cbxUnidRef.Location = New System.Drawing.Point(125, 96)
        Me.cbxUnidRef.Name = "cbxUnidRef"
        Me.cbxUnidRef.Size = New System.Drawing.Size(130, 21)
        Me.cbxUnidRef.TabIndex = 70
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(14, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Unidade Referência:"
        '
        'txtPesoUnidRef
        '
        Me.txtPesoUnidRef.Location = New System.Drawing.Point(439, 100)
        Me.txtPesoUnidRef.Name = "txtPesoUnidRef"
        Me.txtPesoUnidRef.Size = New System.Drawing.Size(71, 20)
        Me.txtPesoUnidRef.TabIndex = 73
        Me.txtPesoUnidRef.Tag = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(261, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 13)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Quant. de Uma uidade Referência:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(18, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(599, 13)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Obs: Informe a quantidade de produtos utilizados na unidade de referência. Inform" &
    "e o peso do copo de 7,5 ml  com o produto "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(46, 146)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(209, 13)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "Informe o peso da espatula com o produto."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(13, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Quantidade:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(84, 70)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(75, 20)
        Me.txtQuantidade.TabIndex = 77
        Me.txtQuantidade.Tag = "*"
        '
        'cbxFornecedor
        '
        Me.cbxFornecedor.FormattingEnabled = True
        Me.cbxFornecedor.Items.AddRange(New Object() {"gotas", "ml", "Espátula", "Peso copo 7,5 ml"})
        Me.cbxFornecedor.Location = New System.Drawing.Point(84, 43)
        Me.cbxFornecedor.Name = "cbxFornecedor"
        Me.cbxFornecedor.Size = New System.Drawing.Size(220, 21)
        Me.cbxFornecedor.TabIndex = 78
        '
        'img
        '
        Me.img.BackColor = System.Drawing.Color.Transparent
        Me.img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.img.Location = New System.Drawing.Point(554, 15)
        Me.img.Name = "img"
        Me.img.Size = New System.Drawing.Size(120, 120)
        Me.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img.TabIndex = 79
        Me.img.TabStop = False
        '
        'btnAdicionarImagem
        '
        Me.btnAdicionarImagem.BackColor = System.Drawing.Color.Honeydew
        Me.btnAdicionarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionarImagem.ForeColor = System.Drawing.Color.Black
        Me.btnAdicionarImagem.Location = New System.Drawing.Point(519, 107)
        Me.btnAdicionarImagem.Name = "btnAdicionarImagem"
        Me.btnAdicionarImagem.Size = New System.Drawing.Size(29, 23)
        Me.btnAdicionarImagem.TabIndex = 80
        Me.btnAdicionarImagem.Text = "+"
        Me.btnAdicionarImagem.UseVisualStyleBackColor = False
        '
        'txtPrecoUnidade
        '
        Me.txtPrecoUnidade.Location = New System.Drawing.Point(245, 70)
        Me.txtPrecoUnidade.Name = "txtPrecoUnidade"
        Me.txtPrecoUnidade.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecoUnidade.TabIndex = 82
        Me.txtPrecoUnidade.Tag = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(166, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "Preço Frasco:"
        '
        'frmProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(686, 435)
        Me.Controls.Add(Me.txtPrecoUnidade)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnAdicionarImagem)
        Me.Controls.Add(Me.img)
        Me.Controls.Add(Me.cbxFornecedor)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPesoUnidRef)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbxUnidRef)
        Me.Controls.Add(Me.cbxUnidadeFrasco)
        Me.Controls.Add(Me.txtTamanhoFrasco)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.dtGridClientes)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Produtos"
        CType(Me.dtGridClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTamanhoFrasco As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents dtGridClientes As DataGridView
    Friend WithEvents lblId As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents cbxUnidadeFrasco As ComboBox
    Friend WithEvents cbxUnidRef As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPesoUnidRef As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents cbxFornecedor As ComboBox
    Friend WithEvents img As PictureBox
    Friend WithEvents btnAdicionarImagem As Button
    Friend WithEvents txtPrecoUnidade As TextBox
    Friend WithEvents Label10 As Label
End Class
