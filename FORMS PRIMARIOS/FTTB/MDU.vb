
Public Class MDU
    Dim FTTBRow As EDIFICIODataSet.FTTBRow
    Private Sub MDU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FTTBTableAdapter.FillByID_EDIFICIO(EDIFICIODataSet.FTTB, EDIFICIODataSet.MDU.Rows(0).Item("ID_MDU"))
        BITACORATableAdapter.FillByID_EDIFICIO(EDIFICIODataSet.BITACORA, CInt(EDIFICIODataSet.MDU.Rows(0).Item("ID_MDU")))
        AGENDATableAdapter.FillByID_EDIFICIO(EDIFICIODataSet.AGENDA, CInt(EDIFICIODataSet.MDU.Rows(0).Item("ID_MDU")))
    End Sub

    Private Sub BtnGuardarFttb_Click(sender As Object, e As EventArgs) Handles btnGuardarFttb.Click
        FTTBRow = EDIFICIODataSet.FTTB.Rows(FTTBBindingSource.Position)
        FTTBRow.CONEXION_DESDE = CONEXION_DESDETextBox.Text
        FTTBRow.TIPO_CONEXION_DESDE = TIPO_CONEXION_DESDETextBox.Text
        If CAJA_DISTRIBUCIONTextBox.Text <> "" Then FTTBRow.CAJA_DISTRIBUCION = CAJA_DISTRIBUCIONTextBox.Text
        FTTBRow.CABLE = CABLETextBox.Text
        FTTBRow.NAP = NAPTextBox.Text
        FTTBRow.NAP_NRO = NAP_NROTextBox.Text
        FTTBRow.TUBO = TUBOTextBox.Text
        FTTBRow.PELO = PELOTextBox.Text
        FTTBRow.OBS_TEC = OBS_TECTextBox.Text
        FTTBRow.ACOMETIDA = ACOMETIDATextBox1.Text
        FTTBRow.SPL_NRO = SPL_NROTextBox.Text
        FTTBTableAdapter.Update(FTTBRow)
        FTTBTableAdapter.FillByID_EDIFICIO(EDIFICIODataSet.FTTB, EDIFICIODataSet.MDU.Rows(0).Item("ID_MDU"))
        NOTIFICACION("SYS", "registro FTTB actualizado")
    End Sub
End Class