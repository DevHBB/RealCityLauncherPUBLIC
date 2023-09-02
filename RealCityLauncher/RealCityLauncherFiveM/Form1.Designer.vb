<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Launcher
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Launcher))
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.Michael = New System.Windows.Forms.PictureBox()
        Me.EntrarNaCidade = New System.Windows.Forms.Button()
        Me.Copyright = New System.Windows.Forms.Label()
        Me.Discord = New System.Windows.Forms.PictureBox()
        Me.LimparCache = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Michael, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Discord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Logo
        '
        Me.Logo.BackColor = System.Drawing.Color.Transparent
        Me.Logo.BackgroundImage = CType(resources.GetObject("Logo.BackgroundImage"), System.Drawing.Image)
        Me.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Logo.Location = New System.Drawing.Point(12, 12)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(91, 73)
        Me.Logo.TabIndex = 0
        Me.Logo.TabStop = False
        '
        'Michael
        '
        Me.Michael.BackColor = System.Drawing.Color.Transparent
        Me.Michael.BackgroundImage = CType(resources.GetObject("Michael.BackgroundImage"), System.Drawing.Image)
        Me.Michael.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Michael.Location = New System.Drawing.Point(-108, 181)
        Me.Michael.Name = "Michael"
        Me.Michael.Size = New System.Drawing.Size(520, 456)
        Me.Michael.TabIndex = 1
        Me.Michael.TabStop = False
        '
        'EntrarNaCidade
        '
        Me.EntrarNaCidade.BackColor = System.Drawing.Color.LimeGreen
        Me.EntrarNaCidade.FlatAppearance.BorderSize = 0
        Me.EntrarNaCidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EntrarNaCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.EntrarNaCidade.ForeColor = System.Drawing.Color.White
        Me.EntrarNaCidade.Location = New System.Drawing.Point(493, 312)
        Me.EntrarNaCidade.Name = "EntrarNaCidade"
        Me.EntrarNaCidade.Size = New System.Drawing.Size(384, 68)
        Me.EntrarNaCidade.TabIndex = 2
        Me.EntrarNaCidade.Text = "ENTRER EN VILLE"
        Me.EntrarNaCidade.UseVisualStyleBackColor = False
        '
        'Copyright
        '
        Me.Copyright.AutoSize = True
        Me.Copyright.BackColor = System.Drawing.Color.Transparent
        Me.Copyright.ForeColor = System.Drawing.Color.White
        Me.Copyright.Location = New System.Drawing.Point(832, 589)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(140, 13)
        Me.Copyright.TabIndex = 4
        Me.Copyright.Text = "RealCity Serveur | FRANCE "
        '
        'Discord
        '
        Me.Discord.BackColor = System.Drawing.Color.Transparent
        Me.Discord.BackgroundImage = CType(resources.GetObject("Discord.BackgroundImage"), System.Drawing.Image)
        Me.Discord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Discord.Location = New System.Drawing.Point(915, 542)
        Me.Discord.Name = "Discord"
        Me.Discord.Size = New System.Drawing.Size(57, 39)
        Me.Discord.TabIndex = 5
        Me.Discord.TabStop = False
        '
        'LimparCache
        '
        Me.LimparCache.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.LimparCache.FlatAppearance.BorderSize = 0
        Me.LimparCache.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LimparCache.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LimparCache.ForeColor = System.Drawing.Color.White
        Me.LimparCache.Location = New System.Drawing.Point(545, 386)
        Me.LimparCache.Name = "LimparCache"
        Me.LimparCache.Size = New System.Drawing.Size(287, 41)
        Me.LimparCache.TabIndex = 3
        Me.LimparCache.Text = "VIDER LES CACHES"
        Me.LimparCache.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(590, 146)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(287, 169)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Launcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 611)
        Me.Controls.Add(Me.EntrarNaCidade)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Michael)
        Me.Controls.Add(Me.Discord)
        Me.Controls.Add(Me.Copyright)
        Me.Controls.Add(Me.LimparCache)
        Me.Controls.Add(Me.Logo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Launcher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RealCity Launcher  |  For REAL CITY  France"
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Michael, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Discord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Logo As PictureBox
    Friend WithEvents Michael As PictureBox
    Friend WithEvents EntrarNaCidade As Button
    Friend WithEvents Copyright As Label
    Friend WithEvents Discord As PictureBox
    Friend WithEvents LimparCache As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
