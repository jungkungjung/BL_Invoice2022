Public Class TabControlEx
    Inherits TabControl

    Private ReadOnly unreadColour As Color = Color.Red
    ''' <summary>
    ''' The colour in which to display tabs for pages that are being read.
    ''' </summary>
    Private ReadOnly readingColour As Color = Color.Yellow
    ''' <summary>
    ''' The colour in which to display tabs for pages containing all read data.
    ''' </summary>
    Private ReadOnly readColour As Color = Color.Green

    ''' <summary>
    ''' The colours in which to display the tabs.
    ''' </summary>
    Private tabColours As New List(Of Color?)


    ''' <summary>
    ''' Sets the colour of a tab to the unread colour.
    ''' </summary>
    ''' <param name="index">
    ''' The index of the tab for which to set the colour.
    ''' </param>
    Public Sub SetTabUnread(index As Integer)
        SetTabColour(index, unreadColour)
    End Sub

    ''' <summary>
    ''' Sets the colour of a tab to the read colour.
    ''' </summary>
    ''' <param name="index">
    ''' The index of the tab for which to set the colour.
    ''' </param>
    Public Sub SetTabRead(index As Integer)
        SetTabColour(index, readColour)
    End Sub

    ''' <summary>
    ''' Sets the colour of a tab to the reading colour.
    ''' </summary>
    ''' <param name="index">
    ''' The index of the tab for which to set the colour.
    ''' </param>
    Private Sub SetTabReading(index As Integer)
        SetTabColour(index, readingColour)
    End Sub

    ''' <summary>
    ''' Sets the colour of a tab.
    ''' </summary>
    ''' <param name="index">
    ''' The index of the tab for which to set the colour.
    ''' </param>
    ''' <param name="colour">
    ''' The colour to which to set the tab.
    ''' </param>
    Private Sub SetTabColour(index As Integer, colour As Color)
        'Make sure that there is a colour for each tab.
        If tabColours.Count < TabPages.Count Then
            tabColours.AddRange(Enumerable.Range(1, TabPages.Count - tabColours.Count).
                                           Select(Function(n) DirectCast(Nothing, Color?)))
        End If

        tabColours(index) = colour
    End Sub

    ''' <summary>
    ''' Adds a new tab page to the end of the tab control.
    ''' </summary>
    ''' <param name="text">
    ''' The text to display on the tab.
    ''' </param>
    ''' <remarks>
    ''' The tab is initially displayed using the read colour.
    ''' </remarks>
    Public Sub AddTabPage(text As String)
        TabPages.Add(text)
        SetTabRead(TabPages.Count - 1)
    End Sub

    'TODO: Add an overload of AddTabPage for each overload of TabPages.Add

    ''' <summary>
    ''' Adds a new tab page to the tab control at the specified index.
    ''' </summary>
    ''' <param name="index">
    ''' The index at which to insert the tab.
    ''' </param>
    ''' <param name="text">
    ''' The text to display on the tab.
    ''' </param>
    ''' <remarks>
    ''' The tab is initially displayed using the read colour.
    ''' </remarks>
    Public Sub InsertTabPage(index As Integer, text As String)
        TabPages.Insert(index, text)
        tabColours.Insert(index, Nothing)
        SetTabRead(index)
    End Sub

    'TODO: Add an overload of InsertTabPage for each overload of TabPages.Insert

    ''' <summary>
    ''' Raises the <see cref="TabControl.Selected">Selected</see> event.
    ''' </summary>
    ''' <param name="e">
    ''' The data for the event.
    ''' </param>
    ''' <remarks>
    ''' The selected tab is displayed in the reading colour.
    ''' </remarks>
    Protected Overrides Sub OnSelected(e As TabControlEventArgs)
        'The new selected tab is being read.
        SetTabReading(e.TabPageIndex)

        MyBase.OnSelected(e)
    End Sub

    ''' <summary>
    ''' Raises the <see cref="TabControl.Deselected">Deselected</see> event.
    ''' </summary>
    ''' <param name="e">
    ''' The data for the event.
    ''' </param>
    ''' <remarks>
    ''' The deselected tab is displayed in the read colour.
    ''' </remarks>
    Protected Overrides Sub OnDeselected(e As TabControlEventArgs)
        'The previously selected tab has been read.
        SetTabRead(e.TabPageIndex)

        MyBase.OnDeselected(e)
    End Sub
End Class
