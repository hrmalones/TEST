Public Class Form4

    Private Sub PersonalInformationBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PersonalInformationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet1)

    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet1.VCT' table. You can move, or remove it, as needed.
        Me.VCTTableAdapter.Fill(Me.Database1DataSet1.VCT)
        'TODO: This line of code loads data into the 'Database1DataSet1.HealthCertificate' table. You can move, or remove it, as needed.
        Me.HealthCertificateTableAdapter.Fill(Me.Database1DataSet1.HealthCertificate)
        'TODO: This line of code loads data into the 'Database1DataSet1.HealthCertificate' table. You can move, or remove it, as needed.
        Me.HealthCertificateTableAdapter.Fill(Me.Database1DataSet1.HealthCertificate)
        'TODO: This line of code loads data into the 'Database1DataSet1.Consultation' table. You can move, or remove it, as needed.
        Me.ConsultationTableAdapter.Fill(Me.Database1DataSet1.Consultation)
        'TODO: This line of code loads data into the 'Database1DataSet1.HealthCertificate' table. You can move, or remove it, as needed.
        Me.HealthCertificateTableAdapter.Fill(Me.Database1DataSet1.HealthCertificate)
        'TODO: This line of code loads data into the 'Database1DataSet1.PersonalInformation' table. You can move, or remove it, as needed.
        Me.PersonalInformationTableAdapter.Fill(Me.Database1DataSet1.PersonalInformation)

    End Sub

    Private Sub Anti_retroviral_TreatmentLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub VDRL_RPR__HC_ComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Try
            Me.Validate()
            Me.PersonalInformationBindingSource.EndEdit()
            Me.PersonalInformationTableAdapter.Update(Me.Database1DataSet1)
            MessageBox.Show("Data in Personal Information has been saved!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.VCTBindingSource.AddNew()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.VCTBindingSource.EndEdit()
        Me.VCTTableAdapter.Update(Me.Database1DataSet1)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ConsultationBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ConsultationBindingSource.EndEdit()
        Me.ConsultationTableAdapter.Update(Me.Database1DataSet1)

    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.HealthCertificateBindingSource.AddNew()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.HealthCertificateBindingSource.EndEdit()
        Me.HealthCertificateTableAdapter.Update(Me.Database1DataSet1)
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        Me.PersonalInformationBindingSource.AddNew()
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Me.PersonalInformationBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Me.PersonalInformationBindingSource.MoveFirst()
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Me.PersonalInformationBindingSource.MoveNext()
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Me.PersonalInformationBindingSource.MovePrevious()
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        Me.PersonalInformationBindingSource.MoveLast()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ConsultationBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ConsultationBindingSource.MoveFirst()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ConsultationBindingSource.MoveNext()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ConsultationBindingSource.MovePrevious()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ConsultationBindingSource.MoveLast()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.HealthCertificateBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.HealthCertificateBindingSource.MoveFirst()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.HealthCertificateBindingSource.MoveNext()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.HealthCertificateBindingSource.MovePrevious()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.HealthCertificateBindingSource.MoveLast()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.VCTBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.VCTBindingSource.MoveFirst()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.VCTBindingSource.MoveNext()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.VCTBindingSource.MovePrevious()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.VCTBindingSource.MoveLast()
    End Sub

    Private Sub Date_of_BirthDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Date_of_BirthDateTimePicker.ValueChanged

    End Sub

    Private Sub Type_of_Client__C_ComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Type_of_Client__C_ComboBox.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.ConsultationBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Me.Validate()
            Me.ConsultationBindingSource.EndEdit()
            Me.ConsultationTableAdapter.Update(Me.Database1DataSet1)
            MessageBox.Show("Data in STI Consultation has been saved!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.HealthCertificateBindingSource.AddNew()
    End Sub

    Private Sub Button8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try
            Me.Validate()
            Me.HealthCertificateBindingSource.EndEdit()
            Me.HealthCertificateTableAdapter.Update(Me.Database1DataSet1)
            MessageBox.Show("Data in Health Certificate Application and Renewal has been saved!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Me.VCTBindingSource.AddNew()
    End Sub

    Private Sub Button14_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Try
            Me.Validate()
            Me.VCTBindingSource.EndEdit()
            Me.VCTTableAdapter.Update(Me.Database1DataSet1)
            MessageBox.Show("Data in HIV VCT has been saved!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click

    End Sub

    Private Sub FillByFirstnameToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.PersonalInformationTableAdapter.FillByFirstname(Me.Database1DataSet1.PersonalInformation, TextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByLastnameToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.PersonalInformationTableAdapter.FillByLastname(Me.Database1DataSet1.PersonalInformation, TextBox2.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub FillByNameofEstablishmentToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.PersonalInformationTableAdapter.FillByNameofEstablishment(Me.Database1DataSet1.PersonalInformation, TextBox3.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click

    End Sub

    Private Sub IDLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class