<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTelaPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTelaPrincipal))
        Me.menuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.CadastraoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FornecedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiçosToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiçosToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EspecialidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiçosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroProdudosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiçosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgendamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuadroDeHoráriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimentaçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovaVendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GastosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolhaPagamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatóriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnQuadroHorario = New System.Windows.Forms.Button()
        Me.btnAgendamento = New System.Windows.Forms.Button()
        Me.btnVenda = New System.Windows.Forms.Button()
        Me.menuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuPrincipal
        '
        Me.menuPrincipal.BackColor = System.Drawing.Color.Transparent
        Me.menuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastraoToolStripMenuItem, Me.ServiçosToolStripMenuItem, Me.ServiçosToolStripMenuItem1, Me.MovimentaçõesToolStripMenuItem, Me.RelatóriosToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.menuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.menuPrincipal.Name = "menuPrincipal"
        Me.menuPrincipal.Size = New System.Drawing.Size(800, 24)
        Me.menuPrincipal.TabIndex = 0
        Me.menuPrincipal.Text = "MenuStrip1"
        '
        'CadastraoToolStripMenuItem
        '
        Me.CadastraoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.FornecedoresToolStripMenuItem, Me.ServiçosToolStripMenuItem2, Me.ServiçosToolStripMenuItem3, Me.EspecialidadesToolStripMenuItem})
        Me.CadastraoToolStripMenuItem.Image = Global.SistemaSalao.My.Resources.Resources.add
        Me.CadastraoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CadastraoToolStripMenuItem.Name = "CadastraoToolStripMenuItem"
        Me.CadastraoToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.CadastraoToolStripMenuItem.Text = "Cadastros"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'FornecedoresToolStripMenuItem
        '
        Me.FornecedoresToolStripMenuItem.Name = "FornecedoresToolStripMenuItem"
        Me.FornecedoresToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FornecedoresToolStripMenuItem.Text = "Fornecedores"
        '
        'ServiçosToolStripMenuItem2
        '
        Me.ServiçosToolStripMenuItem2.Name = "ServiçosToolStripMenuItem2"
        Me.ServiçosToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.ServiçosToolStripMenuItem2.Text = "Funcionários"
        '
        'ServiçosToolStripMenuItem3
        '
        Me.ServiçosToolStripMenuItem3.Name = "ServiçosToolStripMenuItem3"
        Me.ServiçosToolStripMenuItem3.Size = New System.Drawing.Size(180, 22)
        Me.ServiçosToolStripMenuItem3.Text = "Serviços"
        '
        'EspecialidadesToolStripMenuItem
        '
        Me.EspecialidadesToolStripMenuItem.Name = "EspecialidadesToolStripMenuItem"
        Me.EspecialidadesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EspecialidadesToolStripMenuItem.Text = "Especialidades"
        '
        'ServiçosToolStripMenuItem
        '
        Me.ServiçosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroProdudosToolStripMenuItem, Me.EntradasToolStripMenuItem})
        Me.ServiçosToolStripMenuItem.Image = CType(resources.GetObject("ServiçosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ServiçosToolStripMenuItem.Name = "ServiçosToolStripMenuItem"
        Me.ServiçosToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.ServiçosToolStripMenuItem.Text = "Produtos"
        '
        'CadastroProdudosToolStripMenuItem
        '
        Me.CadastroProdudosToolStripMenuItem.Name = "CadastroProdudosToolStripMenuItem"
        Me.CadastroProdudosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CadastroProdudosToolStripMenuItem.Text = "Cadastro Produdos"
        '
        'EntradasToolStripMenuItem
        '
        Me.EntradasToolStripMenuItem.Name = "EntradasToolStripMenuItem"
        Me.EntradasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EntradasToolStripMenuItem.Text = "Entradas"
        '
        'ServiçosToolStripMenuItem1
        '
        Me.ServiçosToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgendamentoToolStripMenuItem, Me.QuadroDeHoráriosToolStripMenuItem})
        Me.ServiçosToolStripMenuItem1.Image = CType(resources.GetObject("ServiçosToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ServiçosToolStripMenuItem1.Name = "ServiçosToolStripMenuItem1"
        Me.ServiçosToolStripMenuItem1.Size = New System.Drawing.Size(78, 20)
        Me.ServiçosToolStripMenuItem1.Text = "Serviços"
        '
        'AgendamentoToolStripMenuItem
        '
        Me.AgendamentoToolStripMenuItem.Name = "AgendamentoToolStripMenuItem"
        Me.AgendamentoToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.AgendamentoToolStripMenuItem.Text = "Agendamento"
        '
        'QuadroDeHoráriosToolStripMenuItem
        '
        Me.QuadroDeHoráriosToolStripMenuItem.Name = "QuadroDeHoráriosToolStripMenuItem"
        Me.QuadroDeHoráriosToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.QuadroDeHoráriosToolStripMenuItem.Text = "Quadro de Horários"
        '
        'MovimentaçõesToolStripMenuItem
        '
        Me.MovimentaçõesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovaVendaToolStripMenuItem, Me.GastosToolStripMenuItem, Me.FolhaPagamentoToolStripMenuItem})
        Me.MovimentaçõesToolStripMenuItem.Image = CType(resources.GetObject("MovimentaçõesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MovimentaçõesToolStripMenuItem.Name = "MovimentaçõesToolStripMenuItem"
        Me.MovimentaçõesToolStripMenuItem.Size = New System.Drawing.Size(120, 20)
        Me.MovimentaçõesToolStripMenuItem.Text = "Movimentações"
        '
        'NovaVendaToolStripMenuItem
        '
        Me.NovaVendaToolStripMenuItem.Name = "NovaVendaToolStripMenuItem"
        Me.NovaVendaToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.NovaVendaToolStripMenuItem.Text = "Nova venda"
        '
        'GastosToolStripMenuItem
        '
        Me.GastosToolStripMenuItem.Name = "GastosToolStripMenuItem"
        Me.GastosToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.GastosToolStripMenuItem.Text = "Gastos"
        '
        'FolhaPagamentoToolStripMenuItem
        '
        Me.FolhaPagamentoToolStripMenuItem.Name = "FolhaPagamentoToolStripMenuItem"
        Me.FolhaPagamentoToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.FolhaPagamentoToolStripMenuItem.Text = "Folha Pagamento"
        '
        'RelatóriosToolStripMenuItem
        '
        Me.RelatóriosToolStripMenuItem.Image = CType(resources.GetObject("RelatóriosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RelatóriosToolStripMenuItem.Name = "RelatóriosToolStripMenuItem"
        Me.RelatóriosToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.RelatóriosToolStripMenuItem.Text = "Relatórios"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.SairToolStripMenuItem.Image = CType(resources.GetObject("SairToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.Color.Transparent
        Me.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnClientes.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Image = CType(resources.GetObject("btnClientes.Image"), System.Drawing.Image)
        Me.btnClientes.Location = New System.Drawing.Point(12, 27)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(60, 60)
        Me.btnClientes.TabIndex = 1
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'btnQuadroHorario
        '
        Me.btnQuadroHorario.BackColor = System.Drawing.Color.Transparent
        Me.btnQuadroHorario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnQuadroHorario.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.btnQuadroHorario.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnQuadroHorario.FlatAppearance.BorderSize = 0
        Me.btnQuadroHorario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan
        Me.btnQuadroHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuadroHorario.Image = CType(resources.GetObject("btnQuadroHorario.Image"), System.Drawing.Image)
        Me.btnQuadroHorario.Location = New System.Drawing.Point(144, 27)
        Me.btnQuadroHorario.Name = "btnQuadroHorario"
        Me.btnQuadroHorario.Size = New System.Drawing.Size(60, 60)
        Me.btnQuadroHorario.TabIndex = 2
        Me.btnQuadroHorario.UseVisualStyleBackColor = False
        '
        'btnAgendamento
        '
        Me.btnAgendamento.BackColor = System.Drawing.Color.Transparent
        Me.btnAgendamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAgendamento.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.btnAgendamento.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnAgendamento.FlatAppearance.BorderSize = 0
        Me.btnAgendamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan
        Me.btnAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgendamento.Image = CType(resources.GetObject("btnAgendamento.Image"), System.Drawing.Image)
        Me.btnAgendamento.Location = New System.Drawing.Point(78, 27)
        Me.btnAgendamento.Name = "btnAgendamento"
        Me.btnAgendamento.Size = New System.Drawing.Size(60, 60)
        Me.btnAgendamento.TabIndex = 3
        Me.btnAgendamento.UseVisualStyleBackColor = False
        '
        'btnVenda
        '
        Me.btnVenda.BackColor = System.Drawing.Color.Transparent
        Me.btnVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnVenda.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.btnVenda.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnVenda.FlatAppearance.BorderSize = 0
        Me.btnVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan
        Me.btnVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVenda.Image = CType(resources.GetObject("btnVenda.Image"), System.Drawing.Image)
        Me.btnVenda.Location = New System.Drawing.Point(210, 27)
        Me.btnVenda.Name = "btnVenda"
        Me.btnVenda.Size = New System.Drawing.Size(60, 60)
        Me.btnVenda.TabIndex = 4
        Me.btnVenda.UseVisualStyleBackColor = False
        '
        'FrmTelaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SistemaSalao.My.Resources.Resources.menu_system
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnVenda)
        Me.Controls.Add(Me.btnAgendamento)
        Me.Controls.Add(Me.btnQuadroHorario)
        Me.Controls.Add(Me.btnClientes)
        Me.Controls.Add(Me.menuPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.menuPrincipal
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTelaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Salão"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.menuPrincipal.ResumeLayout(False)
        Me.menuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuPrincipal As MenuStrip
    Friend WithEvents CadastraoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiçosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiçosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MovimentaçõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatóriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FornecedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiçosToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ServiçosToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents EspecialidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroProdudosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgendamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuadroDeHoráriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovaVendaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GastosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FolhaPagamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnQuadroHorario As Button
    Friend WithEvents btnAgendamento As Button
    Friend WithEvents btnVenda As Button
End Class
