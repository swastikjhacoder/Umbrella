﻿Option Strict On

Imports System.ComponentModel
Imports System.Windows.Forms
Imports Umbrella.Appearance

Namespace Strips
    Public Class eToolStrip
        Inherits ToolStrip

        Public Event AppearanceControlChanged As EventHandler

        Public Sub New()
            MyBase.New()
            Me.RoundedEdges = True
        End Sub

        Private _Appearance As eAppearanceControl
        Public Property Appearance() As eAppearanceControl
            Get
                Return _Appearance
            End Get
            Set(ByVal value As eAppearanceControl)
                _Appearance = value
                If value IsNot Nothing Then
                    Me.Renderer = value.Renderer
                End If
                Me.Invalidate()
                Me.OnAppearanceControlChanged(EventArgs.Empty)
            End Set
        End Property

        Private _RoundedEdges As Boolean
        Public Property RoundedEdges() As Boolean
            Get
                Return _RoundedEdges
            End Get
            Set(ByVal value As Boolean)
                _RoundedEdges = value
            End Set
        End Property

        Protected Overridable Sub OnAppearanceControlChanged(ByVal e As EventArgs)
            If Me.Appearance IsNot Nothing Then
                AddHandler Me.Appearance.AppearanceChanged, AddressOf AppearanceControl_AppearanceChanged
                AddHandler Me.Appearance.Disposed, AddressOf AppearanceControl_Disposed
                Me.Renderer = Me.Appearance.Renderer
            Else
                Me.Renderer = New ToolStripProfessionalRenderer()
            End If
            Me.Invalidate()

            RaiseEvent AppearanceControlChanged(Me, e)
        End Sub

        Private Sub AppearanceControl_Disposed(ByVal sender As Object, ByVal e As EventArgs)
            Me.Appearance = Nothing
            Me.OnAppearanceControlChanged(EventArgs.Empty)
        End Sub

        Private Sub AppearanceControl_AppearanceChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.Renderer = Me.Appearance.Renderer
            CType(Me.Renderer, ToolStripProfessionalRenderer).RoundedEdges = _RoundedEdges
            Me.Invalidate()
        End Sub

    End Class
End Namespace