<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        MenuStrip1 = New MenuStrip()
        OpcionesToolStripMenuItem = New ToolStripMenuItem()
        AgregarToolStripMenuItem = New ToolStripMenuItem()
        EliminarToolStripMenuItem = New ToolStripMenuItem()
        ModificarToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        ListaPeliculas = New ListView()
        CH_NUM = New ColumnHeader()
        titulo = New ColumnHeader()
        director = New ColumnHeader()
        id_genero = New ColumnHeader()
        publicacion = New ColumnHeader()
        calificacion = New ColumnHeader()
        Descripcion = New ColumnHeader()
        btnConSQLite = New Button()
        btnConAccess = New Button()
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
        MenuStrip1.TabIndex = 0
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
        AgregarToolStripMenuItem.Size = New Size(180, 22)
        AgregarToolStripMenuItem.Text = "Agregar"
        ' 
        ' EliminarToolStripMenuItem
        ' 
        EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        EliminarToolStripMenuItem.Size = New Size(180, 22)
        EliminarToolStripMenuItem.Text = "Eliminar"
        ' 
        ' ModificarToolStripMenuItem
        ' 
        ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        ModificarToolStripMenuItem.Size = New Size(180, 22)
        ModificarToolStripMenuItem.Text = "Modificar"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(41, 20)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' ListaPeliculas
        ' 
        ListaPeliculas.Columns.AddRange(New ColumnHeader() {CH_NUM, titulo, director, id_genero, publicacion, calificacion, Descripcion})
        ListaPeliculas.GridLines = True
        ListaPeliculas.Location = New Point(57, 84)
        ListaPeliculas.Name = "ListaPeliculas"
        ListaPeliculas.Size = New Size(426, 308)
        ListaPeliculas.TabIndex = 1
        ListaPeliculas.UseCompatibleStateImageBehavior = False
        ListaPeliculas.View = View.Details
        ' 
        ' CH_NUM
        ' 
        CH_NUM.Text = "ID"
        ' 
        ' titulo
        ' 
        titulo.Text = "Titulo"
        ' 
        ' director
        ' 
        director.Text = "Director"
        ' 
        ' id_genero
        ' 
        id_genero.Text = "Id Genero"
        ' 
        ' publicacion
        ' 
        publicacion.Text = "Año Publicacion"
        ' 
        ' calificacion
        ' 
        calificacion.Text = "Calificaion"
        ' 
        ' Descripcion
        ' 
        Descripcion.Text = "Descipcion"
        ' 
        ' btnConSQLite
        ' 
        btnConSQLite.Location = New Point(83, 36)
        btnConSQLite.Name = "btnConSQLite"
        btnConSQLite.Size = New Size(138, 33)
        btnConSQLite.TabIndex = 2
        btnConSQLite.Text = "Conectar SQLite"
        btnConSQLite.UseVisualStyleBackColor = True
        ' 
        ' btnConAccess
        ' 
        btnConAccess.Location = New Point(304, 36)
        btnConAccess.Name = "btnConAccess"
        btnConAccess.Size = New Size(138, 33)
        btnConAccess.TabIndex = 3
        btnConAccess.Text = "Conectar Access"
        btnConAccess.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(547, 450)
        ControlBox = False
        Controls.Add(btnConAccess)
        Controls.Add(btnConSQLite)
        Controls.Add(ListaPeliculas)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "Form1"
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
    Friend WithEvents ListaPeliculas As ListView
    Friend WithEvents CH_NUM As ColumnHeader
    Friend WithEvents titulo As ColumnHeader
    Friend WithEvents director As ColumnHeader
    Friend WithEvents id_genero As ColumnHeader
    Friend WithEvents Descripcion As ColumnHeader
    Friend WithEvents publicacion As ColumnHeader
    Friend WithEvents calificacion As ColumnHeader
    Friend WithEvents btnConSQLite As Button
    Friend WithEvents btnConAccess As Button
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem

End Class
