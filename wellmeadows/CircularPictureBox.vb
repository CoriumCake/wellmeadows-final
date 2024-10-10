Public Class CircularPictureBox
    Inherits PictureBox

    Public Sub New()
        ' Set PictureBox SizeMode to Zoom for better image scaling
        Me.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Protected Overrides Sub OnPaint(ByVal pe As PaintEventArgs)
        ' Enable high-quality anti-aliasing for smoother edges
        pe.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        pe.Graphics.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        pe.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
        pe.Graphics.CompositingQuality = Drawing2D.CompositingQuality.HighQuality

        ' Create a circle using GraphicsPath
        Dim path As New Drawing2D.GraphicsPath()
        path.AddEllipse(0, 0, Me.Width - 1, Me.Height - 1)

        ' Set the region of the PictureBox to be circular
        Me.Region = New Region(path)

        ' Draw the image inside the circular area, fitting it properly
        If Me.Image IsNot Nothing Then
            Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)
            pe.Graphics.DrawImage(Me.Image, rect)
        End If

        ' Optionally draw a smooth border around the circular PictureBox
        Using pen As New Pen(Color.Black, 2) ' Adjust color and thickness as needed
            pe.Graphics.DrawEllipse(pen, 1, 1, Me.Width - 3, Me.Height - 3)
        End Using
    End Sub
End Class
