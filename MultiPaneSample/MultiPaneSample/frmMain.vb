Imports System.IO
Public Class frmMain
    Private strFileName As String
    Private WithEvents Welcome As subfrmWelcome
    Private WithEvents Customer As subfrmCust
    Private WithEvents Orders As subfrmOrder
    Private arrSubForms As ArrayList

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        arrSubForms = New ArrayList
        Welcome = New subfrmWelcome
        Customer = New subfrmCust
        Orders = New subfrmOrder
        'add all subforms to the arraylist
        arrSubForms.Add(Welcome)
        arrSubForms.Add(Customer)
        arrSubForms.Add(Orders)
        'add each subform to the workarea groupbox
        grpWorkArea.Controls.Add(Welcome)
        grpWorkArea.Controls.Add(Customer)
        grpWorkArea.Controls.Add(Orders)
        'create and assign the point location for each subform relative within the groupbox
        Welcome.Location = CalcLocation(grpWorkArea, Welcome)
        Customer.Location = CalcLocation(grpWorkArea, Customer)
        Orders.Location = CalcLocation(grpWorkArea, Orders)
        HideAllSubForms()
        Welcome.Visible = True
    End Sub
    Private Function CalcLocation(grpBox As GroupBox, subForm As UserControl) As Point
        Return New Point((grpBox.Width - subForm.Width) / 2, (grpBox.Height - subForm.Height) / 2)
    End Function
    Private Sub HideAllSubForms()
        For Each obj As UserControl In arrSubForms
            obj.Visible = False
        Next
    End Sub
    Private Sub OpenFile(strType As String)
        Dim intResult As Integer
        ofdData.InitialDirectory = Application.StartupPath
        ofdData.Filter = "Text Files (*.txt)|*.txt"
        Select Case strType
            Case "CustomerData"
                ofdData.Title = "Select Customer Data File"
            Case "OrderData"
                ofdData.Title = "Select Order Data File"
            Case Else
                MessageBox.Show("Unexpected data type in Openfile", "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
        intResult = ofdData.ShowDialog
        If intResult = DialogResult.Cancel Then
            Exit Sub
        End If
        strFileName = ofdData.FileName
        Try
            ReadInputFile(strFileName, strType)
        Catch ex As Exception
            'TODO build out all error handling here
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub ReadInputFile(strFileIn As String, strType As String)
        Dim fileIn As StreamReader
        Dim strLineIn As String
        Dim strFields() As String
        Dim i As Integer
        fileIn = New StreamReader(strFileIn)
        fileIn.ReadLine() 'throw away first record in file that has field names
        Select Case strType
            Case "CustomerData"
                tvwCust.Nodes.Clear()
                'build letter top nodes
                For i = 65 To 90 'ASCII codes for uppercase A-Z
                    tvwCust.Nodes.Add(Chr(i), Chr(i))
                Next
                Try
                    While Not fileIn.EndOfStream
                        strLineIn = fileIn.ReadLine
                        strFields = strLineIn.Split(","c)
                        'Dim newNode As New TreeNode
                        'newNode.Text = strFields(1) & ", " & strFields(2)
                        'newNode.Tag = strFields(0) 'hide the customer ID in the tag property
                        'tvwCust.Nodes.Add(newNode)
                        'load each name into the appropriate letter node
                        Dim parentNode() As TreeNode
                        parentNode = tvwCust.Nodes.Find(strFields(1).Substring(0, 1),  True) 'find the correct parent letter node
                        parentNode(0).Nodes.Add(strFields(0), strFields(1) & ", " & strFields(2))
                    End While
                    tvwCust.ExpandAll()
                    tvwCust.Refresh()
                Catch ex As Exception
                    Throw ex
                End Try
            Case "OrderData"
                Try
                    While Not fileIn.EndOfStream
                        strLineIn = fileIn.ReadLine
                        strFields = strLineIn.Split(Chr(9)) 'split on the tab character
                        'Dim newNode As New TreeNode
                        'newNode.Text = strFields(0)
                        'newNode.Tag = strFields(1) 'hide the customer ID in the tag property
                        'tvwOrders.Nodes.Add(newNode)
                        tvwOrders.Nodes.Add(strFields(1), strFields(0)) 'add customer ID as the key for the node
                    End While
                    tvwOrders.ExpandAll()
                    tvwOrders.Refresh()
                Catch ex As Exception
                    Throw ex
                End Try
            Case Else
                MessageBox.Show("Unexpected data type in ReadInputFile", "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        OpenFile("CustomerData")
        OpenFile("OrderData")
    End Sub

    Private Sub tvwCust_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tvwCust.NodeMouseClick
        'this event occurs when the user clicks on a node in the treeview
        'sender is the treeview itself, so we will use e to determine which node was clicked
        Dim theNode As TreeNode = DirectCast(e.Node, TreeNode)
        HideAllSubForms()
        Customer.txtID.Text = theNode.Name 'name property is the key value of the node
        Customer.txtName.Text = theNode.Text
        Customer.Visible = True
    End Sub

    Private Sub tvwOrders_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tvwOrders.NodeMouseClick
        Dim theNode As TreeNode = DirectCast(e.Node, TreeNode)
        HideAllSubForms()
        Orders.txtOrderID.Text = theNode.Text
        Orders.txtCustomerID.Text = theNode.Name
        'now find the customer info in the customer treeview
        Dim CustNode() As TreeNode
        CustNode = tvwCust.Nodes.Find(theNode.Name, True)
        Orders.txtName.Text = CustNode(0).Text
        Orders.Visible = True
        tvwCust.SelectedNode = CustNode(0)

    End Sub
End Class
