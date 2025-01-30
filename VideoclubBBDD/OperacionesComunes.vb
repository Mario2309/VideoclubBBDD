Module OperacionesComunes
    Public Sub cargarIdsEnCombobox(lista As ListView, comboBox As ComboBox)
        comboBox.Items.Clear()

        For Each item As ListViewItem In lista.Items
            If item.SubItems.Count > 1 Then
                comboBox.Items.Add(item.SubItems(0).Text)
            End If
        Next
    End Sub

End Module
