Public Class Alumno
    'declaracion de propiedades
    Private codigo As String
    Private Nombre As String
    Private Apellido As String
    Private Genero As String
    Private Direccion As String
    Private Dui As String
    Private Edad As String
    Private Correo As String

    'indica si los datos ingresados estan completos
    Private datosCompletos As Boolean

    'metodos de prioridad
    'metodo para nombre del alumno
    Public Property nombreAlumno() As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property

    'metodo para apellido del alumno
    Public Property apellidoAlumno() As String
        Get
            Return Apellido
        End Get
        Set(value As String)
            Apellido = value
        End Set
    End Property

    'metodo para genero del alumno
    Public Property generoAlumno() As String
        Get
            Return Genero
        End Get
        Set(value As String)
            Genero = value
        End Set
    End Property

    'metodo para Direccion del alumno
    Public Property direccionAlumno() As String
        Get
            Return Direccion
        End Get
        Set(value As String)
            Direccion = value
        End Set
    End Property

    'metodo para DUI del alumno
    Public Property duiAlumno() As String
        Get
            Return Dui
        End Get
        Set(value As String)
            Dui = value
        End Set
    End Property

    'metodo para edad del alumno
    Public Property edadAlumno() As String
        Get
            Return Edad
        End Get
        Set(value As String)
            Edad = value
        End Set
    End Property

    'metodo para correo del alumno
    Public Property correoAlumno() As String
        Get
            Return Correo
        End Get
        Set(value As String)
            Correo = value
        End Set
    End Property

    Public ReadOnly Property datosAceptados() As Boolean
        Get
            Return datosCompletos
        End Get
    End Property

    'metodos
    'constructor de la clase
    Public Sub New()
        datosCompletos = False
        'determina si los datos aun no han sido ingresados
    End Sub

    'determina si los datos ingresados son correctos y asigna los atributos de la clase
    Public Sub datosAlumno(ByVal codigoA As String,
                           ByVal nombreA As String,
                           ByVal apellidoA As String,
                           ByVal generoA As String,
                           ByVal direccionA As String,
                           ByVal duiA As String,
                           ByVal edadA As String,
                           ByVal correoA As String
                           )
        'asume que los datos ingresados son incorrectos
        datosCompletos = False

        If codigoA.Length = 0 Then
            MsgBox("Debe generar el codigo del alumno")
            Exit Sub
        Else
            codigo = codigoA
        End If
        If nombreA.Length = 0 Then
            MsgBox("Debe escribir el nombre del alumno")
            Exit Sub
        Else
            Nombre = nombreA
        End If
        If apellidoA.Length = 0 Then
            MsgBox("Debe escribir el apellido del alumno")
            Exit Sub
        Else
            Apellido = apellidoA
        End If
        If generoA.Length = 0 Then
            MsgBox("Debe escribir el genero del alumno")
            Exit Sub
        Else
            Genero = generoA
        End If
        If generoA = "F" Or generoA = "M" Then
        Else
            MsgBox("debe escribir F para femenino y M para masculino")
            Exit Sub
        End If
        If direccionA.Length = 0 Then
            MsgBox("Debe escribir la direccion del alumno")
            Exit Sub
        Else
            Direccion = direccionA
        End If

        If duiA.Length = 0 Then
            MsgBox("Debe escribir el dui del alumno")
            Exit Sub
        Else
            Dui = duiA
        End If

        If edadA.Length = 0 Then
            MsgBox("Debe escribir la edad del alumno")
            Exit Sub
        Else
            Edad = edadA
        End If

        If correoA.Length = 0 Then
            MsgBox("Debe escribir el correo del alumno")
            Exit Sub
        Else
            Correo = correoA
            datosCompletos = True
        End If
    End Sub

    Public Function generarCodigo(ByVal nombre As String)
        Dim valor1 As String
        Dim valor2 As String
        Dim numero As Single

        valor1 = UCase(Left(nombre, 1))
        valor2 = Right(nombre, 2)
        numero = Int(Rnd() * 1000) + 65

        Return valor1 & numero & valor2
    End Function
End Class
