
Module VARIABLESGLOBALES
    'REFERENTE A TODA LA APLICACION
    Public FORE_COLOR_W As Color = Color.FromArgb(30, 30, 30)
    Public C_NEGRO As Color = Color.FromArgb(64, 64, 64)
    'REFERENTE AL USUARIO
    Public USUARIO As String
    Public NOMBRE As String
    Public APELLIDO As String
    Public FULLNOMBRE As String
    Public SECTOR As String
    Public REMITENTE As String
    Public IDUSUARIO As Integer
    Public ID As Integer
    Public USUARIO_RUS As String
    Public PASSWORD_RUS As String
    Public SELECTOR As String
    Public THEME_BLACK As Boolean
    Public PANTALLA_PRIMARIA As Boolean
    Public PANTALLA_NEGATIVA As Boolean
    'REFERENTE A INTERPOLACION DE FORMULARIOS
    Public INGRESO_AREA As String
    Public ACCESO_DESDE As String
    Public ACCESO_TIPO As String
    Public ACCESO_GESTION As Integer
    Public ACCESO_TRABAJO As Integer
    Public ACCESO_AGENDA As String
    Public BUSCA_CARP As String
    Public BUSCA_PRIM As String
    Public ACCION_ORDEN As String
    Public NROORDENINT As Integer
    Public DIRECCION_MDU As String
    Public NUMERO_MDU As String
    Public NODO_MDU As String
    Public ZONA_MDU As String
    Public TIPOREGISTRO As String
    Public TIPOACCION As String
    Public NROORDINAL As Integer
    Public NROGESTION As Integer
    Public NROTRABAJO As Integer
    Public ORDSTATUS As String

    'VARIABES DE FUENTES DE ALIMENTACION
    Public FUENTE_ID As Integer
    Public FUENTE_NODO As String
    Public FUENTE_ZONA As String
    Public FUENTE_GESTION As String
    Public FUENTE_TRABAJO As String
    Public FUENTE_INSTALACIONRUS As String
    Public FUENTE_INSTALACION As String
    Public FUENTE_CALLE As String
    ' Public FUENTE_CNRO As String
    Public FUENTE_NRO As String
    Public FUENTE_AFECTACION As String

    'DEFINE VARIABLES DE TIEMPO PARA AGENDA
    Public CAPACIDAD_DIA As Integer = 450         'CAPACIDAD DEL DIA LABORABLE EN MINUTOS QUITANDO EL DESCANSO
    Public TIEMPO_AGENDA As Integer = 0          'TIEMPO DE DURACION DEL TRABAJO
    Public ORDEN_TIEMPORESTANTE As Integer = 0
    Public TIEMPO_TRASLADO As Integer = 20
    Public FECHAINI As Date
    Public FECHAFIN As Date
    Public FECHAAGENDA As String
    'DEFINE LAS VARIABLES DE DIAGRAMA DE GANT
    Public GRAF_CLASE(500) As String
    Public GRAF_MOTIVO(500) As String
    Public GRAF_CAUSA(500) As String
    Public GRAF_MANZANA(500) As String
    Public GRAF_CALLE(500) As String
    Public GRAF_NRO(500) As Integer
    Public GRAF_CREARORDINAL(500) As Boolean
    Public GRAF_COORDINAR(500) As Boolean
    Public GRAF_NROGESTION(500) As Integer
    Public GRAF_NROTRABAJO(500) As Integer
    Public GRAF_NROORDEN(500) As Integer
    Public GRAF_NROORDINAL(500) As Integer
    Public GRAF_FECHAINGRESO(500) As Date
    Public GRAF_FECHAINIESTIMADO(500) As Date
    Public GRAF_FECHAINICIO(500) As Date
    Public GRAF_FECHAFINESTIMADO(500) As Date
    Public GRAF_FECHAAGENDADO(500) As Date
    Public GRAF_TIEMPOESTIMADO(500) As Integer
    Public GRAF_FECHAFINALIZADO(500) As Date
    Public GRAF_STATUS(500) As String
    Public GRAF_NODOTRAB(500) As String
    Public GRAF_ZONATRAB(500) As String
    Public GRAF_FECHAINIGRAFICO As Date
    Public GRAF_CANTIDADFILAS As Integer
    Public GRAF_CLASEDEP(500) As String

    'VARIABLES DE LA APLICACION

    Public ESFERA_VERDE As Image = Image.FromFile("G:\OPERACIONES\PROGRAMAS\RECURSOS\EsferaVerde.png")
    Public ESFERA_NEGRA As Image = Image.FromFile("G:\OPERACIONES\PROGRAMAS\RECURSOS\EsferaVerde.png")
    Public CIRCULO_ROJO As Image = Image.FromFile("G:\OPERACIONES\PROGRAMAS\RECURSOS\CirculoRojo.png")
    Public CIRCULO_VERDE As Image = Image.FromFile("G:\OPERACIONES\PROGRAMAS\RECURSOS\CirculoVerde.png")
    Public CIRCULO_NEGRO As Image = Image.FromFile("G:\OPERACIONES\PROGRAMAS\RECURSOS\CirculoNegro.png")
    Public CIRCULO_AMARILLO As Image = Image.FromFile("G:\OPERACIONES\PROGRAMAS\RECURSOS\CirculoAmarillo.png")
    Public CIRCULO_VIOLETA As Image = Image.FromFile("G:\OPERACIONES\PROGRAMAS\RECURSOS\CirculoVioleta.png")


    'GEO
    Public DIRECCION_GEO As String
End Module
