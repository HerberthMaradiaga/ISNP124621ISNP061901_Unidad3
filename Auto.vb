Public Class Auto
    'declaracion de propiedades
    Private codigo As String
    Private marca As String
    Private modelo As String
    Private año As String
    Private capacidad As String
    Private tipo As String
    Private clase As String
    Private color As String

    'indica si los datos ingresados estan completos
    Public datosCompletos As Boolean

    'metodos de prioridad
    'metodo para marca de auto
    Public Property marcaAuto() As String
        Get
            Return marca
        End Get
        Set(value As String)
            marca = value
        End Set
    End Property

    'metodo para modelo del auto
    Public Property modeloAuto() As String
        Get
            Return modelo
        End Get
        Set(value As String)
            modelo = value
        End Set
    End Property

    'metodo para año del auto
    Public Property añoAuto() As String
        Get
            Return año
        End Get
        Set(value As String)
            año = value
        End Set
    End Property

    'metodo para capacida del auto
    Public Property capacidadAuto() As String
        Get
            Return capacidad
        End Get
        Set(value As String)
            capacidad = value
        End Set
    End Property

    'metodo para tipo de auto
    Public Property tipoAuto() As String
        Get
            Return tipo
        End Get
        Set(value As String)
            tipo = value
        End Set
    End Property

    'metodo para clase del auto
    Public Property claseAuto() As String
        Get
            Return clase
        End Get
        Set(value As String)
            clase = value
        End Set
    End Property

    'metodo para color del auto
    Public Property colorAuto() As String
        Get
            Return color
        End Get
        Set(value As String)
            color = value
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
    Public Sub datosAuto(ByVal codigoA As String,
                           ByVal marcaA As String,
                           ByVal modeloA As String,
                           ByVal añoA As String,
                           ByVal capacidadA As String,
                           ByVal tipoA As String,
                           ByVal claseA As String,
                           ByVal colorA As String
                           )
        'asume que los datos ingresados son incorrectos
        datosCompletos = False

        If codigoA.Length = 0 Then
            MsgBox("Debe generar el codigo del auto")
            Exit Sub
        Else
            codigo = codigoA
        End If
        If marcaA.Length = 0 Then
            MsgBox("Debe escribir la marca del auto")
            Exit Sub
        Else
            marca = marcaA
        End If
        If modeloA.Length = 0 Then
            MsgBox("Debe escribir el modelo del auto")
            Exit Sub
        Else
            modelo = modeloA
        End If
        If añoA.Length = 0 Then
            MsgBox("Debe escribir el año del auto")
            Exit Sub
        Else
            año = añoA
        End If
        If capacidadA = 0 Then
            MsgBox("debe escribir la capacidad del auto")
            Exit Sub
        Else
            capacidad = capacidadA
        End If
        If tipoA.Length = 0 Then
            MsgBox("Debe escribir el tipo del auto")
            Exit Sub
        Else
            tipo = tipoA
        End If

        If claseA.Length = 0 Then
            MsgBox("Debe escribir la clase del auto")
            Exit Sub
        Else
            clase = claseA
        End If

        If colorA.Length = 0 Then
            MsgBox("Debe escribir el color del auto")
            Exit Sub
        Else
            color = colorA
            datosCompletos = True
        End If
    End Sub

    Public Function generarCodigo(ByVal marca As String)
        Dim valor1 As String
        Dim valor2 As String
        Dim numero As Single

        valor1 = UCase(Left(marca, 1))
        'del nombre se tomara la primera letra de la derecha y ademas se pasara a mayuscula
        valor2 = Right(marca, 2)
        'en este paramtro se le indica que tome las dos primeras letras de la izquierda
        numero = Int(Rnd() * 1000) + 65
        'numero sera igual a un numero entero aleatorio, y se le suma 65 para que no se repita
        'la funcion retorna el valor del procedimiento anterior
        Return valor1 & numero & valor2
    End Function
End Class
