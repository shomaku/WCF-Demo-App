' NOTE: If you change the interface name "IService1" here, you must also update the reference to "IService1" in App.config.
<ServiceContract()> _
Public Interface IJsonService

    <OperationContract()> _
    Function UploadJson(ByVal bytes As Byte()) As String

End Interface

