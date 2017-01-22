'Imports System.IO

'Public Class TestBLOB
'    Dim imagename As String
'    Dim newimg As Bitmap = New Bitmap(imagename)


'    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
'        Try

'            Dim fldlg As FileDialog = New OpenFileDialog()
'            'specify your own initial directory 
'            fldlg.InitialDirectory = ":D\"
'            'this will allow onlt those file extensions to be added 
'            fldlg.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"
'            If fldlg.ShowDialog() = DialogResult.OK Then

'                imagename = fldlg.FileName
'                Dim newimg As Bitmap = New Bitmap(imagename)
'                pctimg.SizeMode = PictureBoxSizeMode.StretchImage
'                pctimg.Image = newimg
'            End If
'            fldlg = Nothing



'        Catch ae As Exception
'            imagename = " "
'            MessageBox.Show(ae.Message.ToString())

'        End Try




'        Try

'            'proceed only when the image has a valid path 
'            If imagename <> "" Then
'                Dim fls As New FileStream

'                fls = New FileStream(imagename, FileMode.Open, FileAccess.Read)
'                'a byte array to read the image 
'Dim blob As byte[]=new byte[fls.Length]
'fls.Read(blob,0,System.Convert.ToInt32(fls.Length)); 
'fls.Close(); 
'//open the database using odp.net and insert the data 
'connstr="User Id="userid";Password="password";Data Source="datasource";"; 
'conn=new OracleConnection(connstr); 
'conn.Open(); 
'OracleCommand cmnd; 
'string query; 
'query="insert into emp(id,name,photo) values(" + txtid.Text + "," + "'" + txtname.Text + "'," + " :BlobParameter )";

'//insert the byte as oracle parameter of type blob 
'OracleParameter blobParameter = new OracleParameter(); 
'blobParameter.OracleType = OracleType.Blob; 
'blobParameter.ParameterName = "BlobParameter"; 
'blobParameter.Value = blob; 
'cmnd=new OracleCommand(query,conn); 
'cmnd.Parameters.Add(blobParameter); 
'cmnd.ExecuteNonQuery(); 
'MessageBox.Show("added to blob field"); 
'cmnd.Dispose(); 
'conn.Close(); 
'conn.Dispose(); 
'            End If

'catch(Exception ex) 
'{ 
'MessageBox.Show(ex.Message); 
'} 
'}

'    End Sub
'End Class