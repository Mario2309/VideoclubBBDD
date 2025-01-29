<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInicial
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        OpcionesToolStripMenuItem = New ToolStripMenuItem()
        AgregarToolStripMenuItem = New ToolStripMenuItem()
        EliminarToolStripMenuItem = New ToolStripMenuItem()
        ModificarToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        txTitulo = New TextBox()
        txDirector = New TextBox()
        txGen = New TextBox()
        txAnio = New TextBox()
        txCalific = New TextBox()
        txDescp = New TextBox()
        LabeliD = New Label()
        LabelMostrId = New Label()
        LabelTitle = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        btn = New Button()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.White
        MenuStrip1.Items.AddRange(New ToolStripItem() {OpcionesToolStripMenuItem, SalirToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(547, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' OpcionesToolStripMenuItem
        ' 
        OpcionesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AgregarToolStripMenuItem, EliminarToolStripMenuItem, ModificarToolStripMenuItem})
        OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        OpcionesToolStripMenuItem.Size = New Size(69, 20)
        OpcionesToolStripMenuItem.Text = "Opciones"
        ' 
        ' AgregarToolStripMenuItem
        ' 
        AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        AgregarToolStripMenuItem.Size = New Size(125, 22)
        AgregarToolStripMenuItem.Text = "Agregar"
        ' 
        ' EliminarToolStripMenuItem
        ' 
        EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        EliminarToolStripMenuItem.Size = New Size(125, 22)
        EliminarToolStripMenuItem.Text = "Eliminar"
        ' 
        ' ModificarToolStripMenuItem
        ' 
        ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        ModificarToolStripMenuItem.Size = New Size(125, 22)
        ModificarToolStripMenuItem.Text = "Modificar"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(41, 20)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' txTitulo
        ' 
        txTitulo.Location = New Point(351, 62)
        txTitulo.Name = "txTitulo"
        txTitulo.Size = New Size(100, 23)
        txTitulo.TabIndex = 2
        ' 
        ' txDirector
        ' 
        txDirector.Location = New Point(123, 132)
        txDirector.Name = "txDirector"
        txDirector.Size = New Size(100, 23)
        txDirector.TabIndex = 3
        ' 
        ' txGen
        ' 
        txGen.Location = New Point(351, 137)
        txGen.Name = "txGen"
        txGen.Size = New Size(100, 23)
        txGen.TabIndex = 4
        ' 
        ' txAnio
        ' 
        txAnio.Location = New Point(123, 208)
        txAnio.Name = "txAnio"
        txAnio.Size = New Size(100, 23)
        txAnio.TabIndex = 7
        ' 
        ' txCalific
        ' 
        txCalific.Location = New Point(351, 205)
        txCalific.Name = "txCalific"
        txCalific.Size = New Size(100, 23)
        txCalific.TabIndex = 8
        ' 
        ' txDescp
        ' 
        txDescp.Location = New Point(123, 272)
        txDescp.Multiline = True
        txDescp.Name = "txDescp"
        txDescp.Size = New Size(328, 48)
        txDescp.TabIndex = 9
        ' 
        ' LabeliD
        ' 
        LabeliD.AutoSize = True
        LabeliD.Location = New Point(64, 70)
        LabeliD.Name = "LabeliD"
        LabeliD.Size = New Size(24, 15)
        LabeliD.TabIndex = 10
        LabeliD.Text = "ID :"
        ' 
        ' LabelMostrId
        ' 
        LabelMostrId.AutoSize = True
        LabelMostrId.Location = New Point(123, 70)
        LabelMostrId.Name = "LabelMostrId"
        LabelMostrId.Size = New Size(0, 15)
        LabelMostrId.TabIndex = 11
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoSize = True
        LabelTitle.Location = New Point(285, 65)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(43, 15)
        LabelTitle.TabIndex = 12
        LabelTitle.Text = "Titulo :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(57, 140)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 15)
        Label1.TabIndex = 13
        Label1.Text = "Director :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(264, 145)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 15)
        Label2.TabIndex = 14
        Label2.Text = "Id Genero :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 208)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 15)
        Label3.TabIndex = 15
        Label3.Text = "Año Publicacion :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(253, 208)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 15)
        Label4.TabIndex = 16
        Label4.Text = "Calificacion :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(45, 272)
        Label6.Name = "Label6"
        Label6.Size = New Size(43, 15)
        Label6.TabIndex = 18
        Label6.Text = "Titulo :"
        ' 
        ' btn
        ' 
        btn.Location = New Point(216, 364)
        btn.Name = "btn"
        btn.Size = New Size(130, 44)
        btn.TabIndex = 19
        btn.Text = "Button1"
        btn.UseVisualStyleBackColor = True
        ' 
        ' FormInicial
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(547, 450)
        ControlBox = False
        Controls.Add(btn)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(LabelTitle)
        Controls.Add(LabelMostrId)
        Controls.Add(LabeliD)
        Controls.Add(txDescp)
        Controls.Add(txCalific)
        Controls.Add(txAnio)
        Controls.Add(txGen)
        Controls.Add(txDirector)
        Controls.Add(txTitulo)
        Controls.Add(MenuStrip1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormInicial"
        Text = "FormInicial"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txTitulo As TextBox
    Friend WithEvents txDirector As TextBox
    Friend WithEvents txGen As TextBox
    Friend WithEvents txAnio As TextBox
    Friend WithEvents txCalific As TextBox
    Friend WithEvents txDescp As TextBox
    Friend WithEvents LabeliD As Label
    Friend WithEvents LabelMostrId As Label
    Friend WithEvents LabelTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn As Button
End Class
