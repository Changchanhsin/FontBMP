Public Class Form1
    Dim xold As Integer
    Dim yold As Integer
    Dim linesRow(36 * 2) As PictureBox
    Dim linesCol(38 * 2) As PictureBox

    Private Sub PictureBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick
        If txtFilesCount.Text >= 10 Then
            PictureBox1.Load(txtFilesPrefix.Text & "01.png")
        Else
            PictureBox1.Load(txtFilesPrefix.Text & "1.png")
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Dim iLeft As Double
        Dim iTop As Double
        Dim iWidth As Double
        Dim iHeight As Double
        Dim iCols As Double
        Dim iRows As Double
        Dim iColM As Double
        Dim iRowM As Double

        iLeft = TextBox1.Text
        iTop = TextBox2.Text
        iWidth = TextBox3.Text
        iHeight = TextBox4.Text
        iCols = TextBox5.Text
        iRows = TextBox6.Text
        iColM = TextBox7.Text
        iRowM = TextBox8.Text

        For j = 0 To iCols - 1
            If IsNothing(linesCol(j * 2)) Then
                linesCol(j * 2) = New PictureBox
            End If
            linesCol(j * 2).Left = iLeft + (iWidth + iColM) * (j) - 1
            linesCol(j * 2).Top = 0
            linesCol(j * 2).Width = 1
            linesCol(j * 2).Height = PictureBox1.Height
            linesCol(j * 2).BackColor = Color.Red
            linesCol(j * 2).Parent = PictureBox1
            linesCol(j * 2).BringToFront()
            If IsNothing(linesCol(j * 2 + 1)) Then
                linesCol(j * 2 + 1) = New PictureBox
            End If
            linesCol(j * 2 + 1).Left = iLeft + (iWidth + iColM) * (j) + iWidth
            linesCol(j * 2 + 1).Top = 0
            linesCol(j * 2 + 1).Width = 1
            linesCol(j * 2 + 1).Height = PictureBox1.Height
            linesCol(j * 2 + 1).BackColor = Color.Red
            linesCol(j * 2 + 1).Parent = PictureBox1
            linesCol(j * 2 + 1).BringToFront()
        Next
        For j = 0 To iRows - 1
            If IsNothing(linesRow(j * 2)) Then
                linesRow(j * 2) = New PictureBox
            End If
            linesRow(j * 2).Top = iTop + (iHeight + iRowM) * (j) - 1
            linesRow(j * 2).Left = 0
            linesRow(j * 2).Height = 1
            linesRow(j * 2).Width = PictureBox1.Width
            linesRow(j * 2).BackColor = Color.Red
            linesRow(j * 2).Parent = PictureBox1
            linesRow(j * 2).BringToFront()
            If IsNothing(linesRow(j * 2 + 1)) Then
                linesRow(j * 2 + 1) = New PictureBox
            End If
            linesRow(j * 2 + 1).Top = iTop + (iHeight + iRowM) * (j) + iHeight
            linesRow(j * 2 + 1).Left = 0
            linesRow(j * 2 + 1).Height = 1
            linesRow(j * 2 + 1).Width = PictureBox1.Height
            linesRow(j * 2 + 1).BackColor = Color.Red
            linesRow(j * 2 + 1).Parent = PictureBox1
            linesRow(j * 2 + 1).BringToFront()
        Next
    End Sub

    Private Sub btnCreat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Dim iLeft As Double
        Dim iTop As Double
        Dim iWidth As Double
        Dim iHeight As Double
        Dim iCols As Double
        Dim iRows As Double
        Dim iColM As Double
        Dim iRowM As Double

        iLeft = TextBox1.Text
        iTop = TextBox2.Text
        iWidth = TextBox3.Text
        iHeight = TextBox4.Text
        iCols = TextBox5.Text
        iRows = TextBox6.Text
        iColM = TextBox7.Text
        iRowM = TextBox8.Text

        Dim bmpOutput As New Bitmap(256 * (48 + 1) + 13, 256 * (48 + 1) + 13)
        Dim grpOutput As Graphics = Graphics.FromImage(bmpOutput)
        Dim grpTemp As Graphics

        Dim img As Image

        ' 准备数字
        Dim bmpDigital(16) As Bitmap
        For i = 0 To 15
            bmpDigital(i) = New Bitmap(5, 7)
            grpTemp = Graphics.FromImage(bmpDigital(i))
            grpTemp.DrawImage(ImageList2.Images(0), 0 - i * 5, 0)
        Next

        ' 画网格
        For i = 0 To 255
            grpOutput.DrawLine(Pens.Blue, 0, i * 49 + 12, 256 * (48 + 1) + 12, i * 49 + 12)
            grpOutput.DrawLine(Pens.Blue, i * 49 + 12, 0, i * 49 + 12, 256 * (48 + 1) + 12)
            grpOutput.DrawImage(bmpDigital(Int(i / 16)), 15 + i * 49, 3)
            grpOutput.DrawImage(bmpDigital(i Mod 16), 21 + i * 49, 3)
            grpOutput.DrawImage(bmpDigital(Int(i / 16)), 5, 15 + i * 49)
            grpOutput.DrawImage(bmpDigital(i Mod 16), 5, 23 + i * 49)
        Next
        grpOutput.DrawLine(Pens.Blue, 0, 256 * 49 + 12, 256 * (48 + 1) + 12, 256 * 49 + 12)
        grpOutput.DrawLine(Pens.Blue, 256 * 49 + 12, 0, 256 * 49 + 12, 256 * (48 + 1) + 12)

        Dim countChar As Long
        Dim iT As Double
        Dim iL As Double
        Dim iDT As Integer
        Dim iDL As Integer
        Dim p As Integer

        countChar = Integer.Parse(txtCodeStart.Text, Globalization.NumberStyles.HexNumber) Mod 65536
        ProgressBar1.Maximum = 10 * iRows
        ProgressBar1.Visible = True
        For p = 1 To txtFilesCount.Text
            If p < 10 Then
                If txtFilesCount.Text >= 10 Then
                    PictureBox1.Load(txtFilesPrefix.Text & "0" & p & ".png")
                Else
                    PictureBox1.Load(txtFilesPrefix.Text & p & ".png")
                End If
            Else
                PictureBox1.Load(txtFilesPrefix.Text & p & ".png")
            End If
            img = PictureBox1.Image
            For i = 0 To iRows - 1
                For j = 0 To iCols - 1
                    iT = iTop + (iHeight + iRowM) * (i)
                    iL = iLeft + (iWidth + iColM) * (j)
                    If (p = 1 And i = 8 And j >= 16) Or (p = 10 And i = 32 And j >= 20) Or (p = 10 And i > 32) Then
                    Else
                        iDT = 13 + Int(countChar / 256) * 49
                        iDL = 13 + (countChar Mod 256) * 49
                        grpOutput.DrawImage(img, New Rectangle(iDL, iDT, 48, 48), New Rectangle(iL, iT, 48, 48), GraphicsUnit.Pixel)
                        countChar = countChar + 1
                    End If
                Next
                ProgressBar1.Value = (p - 1) * iRows + i
                System.Windows.Forms.Application.DoEvents()
            Next
        Next

        PictureBox2.Width = 256 * (48 + 1) + 13
        PictureBox2.Height = 256 * (48 + 1) + 13
        PictureBox2.Image = bmpOutput
        PictureBox2.Refresh()
        ProgressBar1.Visible = False
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        PictureBox2.Image.Save(txtBMPFilename.Text)
        Dim img = PictureBox2.Image
        Dim bmp = New Bitmap(48, 48)
        Dim aline(6) As Byte
        Dim i, j, k, m, n As Integer

        Dim strFilePath As String
        strFilePath = txtHZFilename.Text

        Dim FS As New System.IO.FileStream(strFilePath, IO.FileMode.Create)
        Dim Bw As New System.IO.BinaryWriter(FS)
        Dim grpTemp As Graphics

        ProgressBar1.Maximum = 40 * 256
        ProgressBar1.Visible = True
        PictureBox4.Visible = True
        For i = 167 To 206
            For j = 0 To 255
                grpTemp = Graphics.FromImage(bmp)
                grpTemp.DrawImage(PictureBox2.Image, New Rectangle(0, 0, 48, 48), New Rectangle((j * 49 + 13), (i * 49 + 13), 48, 48), GraphicsUnit.Pixel)
                Label10.Text = "2" & Hex(i * 256 + j) & ": " & (i * 49 + 13) & ", " & (j * 49 + 13)
                PictureBox4.Image = bmp
                For k = 0 To 47
                    For m = 0 To 5
                        aline(m) = 0
                        For n = 0 To 7
                            If bmp.GetPixel(m * 8 + n, k).R > 10 Then
                                aline(m) = aline(m) * 2 + 0
                            Else
                                aline(m) = aline(m) * 2 + 1
                            End If
                        Next
                        Bw.Write(aline(m))
                    Next
                Next
                Bw.Flush()
                ProgressBar1.Value = (i - 167) * 256 + j
                System.Windows.Forms.Application.DoEvents()
            Next
        Next
        Bw.Close()
        Bw = Nothing
        ProgressBar1.Visible = False
        PictureBox4.Visible = False
    End Sub

End Class
