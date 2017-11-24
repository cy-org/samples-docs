﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On



<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"),  _
 System.ServiceModel.ServiceContractAttribute([Namespace]:="http://Microsoft.ServiceModel.Samples", ConfigurationName:="ICalculatorDuplex", CallbackContract:=GetType(ICalculatorDuplexCallback), SessionMode:=System.ServiceModel.SessionMode.Required)>  _
Public Interface ICalculatorDuplex
    
    <System.ServiceModel.OperationContractAttribute(IsOneWay:=true, Action:="http://Microsoft.ServiceModel.Samples/ICalculatorDuplex/Clear")>  _
    Sub Clear()
    
    <System.ServiceModel.OperationContractAttribute(IsOneWay:=true, Action:="http://Microsoft.ServiceModel.Samples/ICalculatorDuplex/AddTo")>  _
    Sub AddTo(ByVal n As Double)
    
    <System.ServiceModel.OperationContractAttribute(IsOneWay:=true, Action:="http://Microsoft.ServiceModel.Samples/ICalculatorDuplex/SubtractFrom")>  _
    Sub SubtractFrom(ByVal n As Double)
    
    <System.ServiceModel.OperationContractAttribute(IsOneWay:=true, Action:="http://Microsoft.ServiceModel.Samples/ICalculatorDuplex/MultiplyBy")>  _
    Sub MultiplyBy(ByVal n As Double)
    
    <System.ServiceModel.OperationContractAttribute(IsOneWay:=true, Action:="http://Microsoft.ServiceModel.Samples/ICalculatorDuplex/DivideBy")>  _
    Sub DivideBy(ByVal n As Double)
End Interface

<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
Public Interface ICalculatorDuplexCallback
    
    <System.ServiceModel.OperationContractAttribute(IsOneWay:=true, Action:="http://Microsoft.ServiceModel.Samples/ICalculatorDuplex/Result")>  _
    Sub Result(ByVal result As Double)
    
    <System.ServiceModel.OperationContractAttribute(IsOneWay:=true, Action:="http://Microsoft.ServiceModel.Samples/ICalculatorDuplex/Equation")>  _
    Sub Equation(ByVal eqn As String)
End Interface

<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
Public Interface ICalculatorDuplexChannel
    Inherits ICalculatorDuplex, System.ServiceModel.IClientChannel
End Interface

<System.Diagnostics.DebuggerStepThroughAttribute(),  _
 System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
Partial Public Class CalculatorDuplexClient
    Inherits System.ServiceModel.DuplexClientBase(Of ICalculatorDuplex)
    Implements ICalculatorDuplex
    
    Public Sub New(ByVal callbackInstance As System.ServiceModel.InstanceContext)
        MyBase.New(callbackInstance)
    End Sub
    
    Public Sub New(ByVal callbackInstance As System.ServiceModel.InstanceContext, ByVal endpointConfigurationName As String)
        MyBase.New(callbackInstance, endpointConfigurationName)
    End Sub
    
    Public Sub New(ByVal callbackInstance As System.ServiceModel.InstanceContext, ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
        MyBase.New(callbackInstance, endpointConfigurationName, remoteAddress)
    End Sub
    
    Public Sub New(ByVal callbackInstance As System.ServiceModel.InstanceContext, ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
        MyBase.New(callbackInstance, endpointConfigurationName, remoteAddress)
    End Sub
    
    Public Sub New(ByVal callbackInstance As System.ServiceModel.InstanceContext, ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
        MyBase.New(callbackInstance, binding, remoteAddress)
    End Sub
    
    Public Sub Clear() Implements ICalculatorDuplex.Clear
        MyBase.Channel.Clear
    End Sub
    
    Public Sub AddTo(ByVal n As Double) Implements ICalculatorDuplex.AddTo
        MyBase.Channel.AddTo(n)
    End Sub
    
    Public Sub SubtractFrom(ByVal n As Double) Implements ICalculatorDuplex.SubtractFrom
        MyBase.Channel.SubtractFrom(n)
    End Sub
    
    Public Sub MultiplyBy(ByVal n As Double) Implements ICalculatorDuplex.MultiplyBy
        MyBase.Channel.MultiplyBy(n)
    End Sub
    
    Public Sub DivideBy(ByVal n As Double) Implements ICalculatorDuplex.DivideBy
        MyBase.Channel.DivideBy(n)
    End Sub
End Class
