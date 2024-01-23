﻿Public Class NOTASVERS
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub
    Private Sub INICIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim text As String = ""
        text += "___________________________________________________" & vbNewLine
        text += "nueva version (3.5.4):" & vbNewLine
        text += vbNewLine & "- Nueva agenda con opción de seleccionar el sector operativo al momento de asignar la capacidad"
        text += vbNewLine & "- Corrección de capacidad de agenda según sector operativo y tiempo de trabajo de cada técnico"
        text += vbNewLine & "- Correcciones de errores conocidos"
        text += vbNewLine & "- Mejoras en la usabilidad e interfaz de usuario"
        text += vbNewLine & vbNewLine
        text += "___________________________________________________" & vbNewLine
        text += "nueva version (3.1.15):" & vbNewLine
        text += vbNewLine & "- Se corrigen Bugs conocidos"
        text += vbNewLine & "- Mejoras en general."
        text += vbNewLine & "- Mejoras en el los cruces de SECTOR-FALLA-CAUSA para las ordenes internas, dando mejor visibilidad a las fallas segun su SECTOR de origen"
        text += vbNewLine & vbNewLine
        text += "___________________________________________________" & vbNewLine
        text += "nueva version (3.1.14):" & vbNewLine
        text += vbNewLine & "- Se corrigen Bugs conocidos"
        text += vbNewLine & "- Mejoras en general."
        text += vbNewLine & "- Se incorpora BOT para visualizar ordinales desde la aplicación"
        text += vbNewLine & vbNewLine
        text += "___________________________________________________" & vbNewLine
        text += "nueva version (3.1.13):" & vbNewLine
        text += vbNewLine & "- Se corrigen Bugs conocidos"
        text += vbNewLine & "- Mejoras en general."
        text += vbNewLine & "- Se incorpora opción de cargar afectacion de mas de una nodo/zona a orden interna"
        text += vbNewLine & "- Se incorpora INDICES dentro del modulo de PROCESOS"
        text += vbNewLine & vbNewLine
        text += "___________________________________________________" & vbNewLine
        text += "nueva version (3.1.12):" & vbNewLine
        text += vbNewLine & "- Se corrigen Bugs conocidos"
        text += vbNewLine & "- Mejoras en general."
        text += vbNewLine & "- Implementación de generación de TRABAJOS automaticos a partir de una NUEVA GESTION, identificando el tipo(MAN/OBRA-MDU/RED)"
        text += vbNewLine & vbNewLine
        text += "___________________________________________________" & vbNewLine
        text += "nueva version (3.1.11):" & vbNewLine
        text += vbNewLine & "- Se corrigen Bugs conocidos"
        text += vbNewLine & "- Mejoras en general."
        text += vbNewLine & "- Implementación de adjuntar documentación a los TRABAJOS"
        text += vbNewLine & vbNewLine
        text += "___________________________________________________" & vbNewLine
        text += "nueva version (3.1.10):" & vbNewLine
        text += vbNewLine & "- Mejoras en general."
        text += vbNewLine & "- Se simplifica el modo de imprimir, generando un pdf con datos de orden"
        text += vbNewLine & "- Implementacion de REQUERIDOS, son los TRABAJOS y GESTIONES que tienen FINALIZADOS todos sus ORDENES y TRABAJOS, respectivamente, requieren la intervención del usuario"
        text += vbNewLine & vbNewLine
        text += "___________________________________________________" & vbNewLine
        text += "nueva version (3.1.9):" & vbNewLine
        text += vbNewLine & "- Mejoras en modulo de FUENTES"
        text += vbNewLine & "- MejoraS en modulo ADMINISTRACION"
        text += vbNewLine & "- Mejoras en modulo PROCESOS"
        text += vbNewLine & "- Incorporacion de CLIMA, con pronositco a 7 dias e historico de la misma"
        text += vbNewLine & vbNewLine
        text += "___________________________________________________" & vbNewLine
        text += "nueva version (3.1.8):" & vbNewLine
        text += vbNewLine & "- Al generar nuevo trabajo a partir de la gestion, tomara informacion de dicha gestion"
        text += vbNewLine & "- Mejora en la interfaz de usuario"
        text += vbNewLine & "- Correccion de BUGS conocidos"
        text += vbNewLine & vbNewLine
        text += "___________________________________________________" & vbNewLine
        text += "nueva version (3.1.7):" & vbNewLine
        text += vbNewLine & "- Correcciones en modulo MDU"
        text += vbNewLine & "- Mejora en la interfaz de usuario"
        text += vbNewLine & "- Se mejora la inclusion del MENU de ordenes"
        text += vbNewLine & vbNewLine
        text += "___________________________________________________" & vbNewLine
        text += "nueva version (3.1.6):" & vbNewLine
        text += vbNewLine & "- Correccion de GESTIONES/TRABAJOS al ingresar desde FUENTES"
        text += vbNewLine & "- Mejoras en el proceso de ordenes finalizadas"
        text += vbNewLine & "- Mejoras en el rendimiento general"
        text += vbNewLine & vbNewLine
        text += "___________________________________________________" & vbNewLine
        text += "nueva version (3.1.5):" & vbNewLine
        text += vbNewLine & "- Mejoras el sistema de busquea de gestiones"
        text += vbNewLine & "- Se integra la opcion de desagendar en un check cuando hay un ordinal asociado a una orden para se administrado"
        text += vbNewLine & "- Mejoras en el modulo de RED"
        text += vbNewLine & "- Mejoras en el rendimiento general"
        text += vbNewLine & vbNewLine
        text += "___________________________________________________" & vbNewLine
        text += "nueva version (3.1.4):" & vbNewLine
        text += vbNewLine & "- Mejoras el sistema de busquea de gestiones"
        text += vbNewLine & "- Modifica la forma de adjuntar archivos creando una copia en el disco G: relacionado con la GESTION/TRABAJO/ORDEN afectada"
        text += vbNewLine & "- Mejoras en el modulo de FUENTES"
        text += vbNewLine & "- Incluye REINICIAR en combos dependiendo el tipo de gestion-trabajo"
        text += vbNewLine & vbNewLine
        text += "___________________________________________________" & vbNewLine

        text += vbNewLine & "nueva version (3.1.3):"
        text += vbNewLine & "- Al ingresar una calle, al presionar ESCAPE sobre el campo de texto, quita las sugerencias de calle"
        text += vbNewLine & "- Se solicita ingresar calle correcta a TRABAJOS"
        text += vbNewLine & "- Mejoras en el sistema de busqueda, pemite exportar a EXCEL filtro realizado"
        text += vbNewLine & "- Correccion de carga de combos dependiendo el tipo de gestion-trabajo-orden"
        text += vbNewLine & vbNewLine
        text += "___________________________________________________" & vbNewLine
        text += "nueva version (3.1.2):" & vbNewLine
        text += vbNewLine & "- Correccion de menores en combos para generar trabajos, limitando la opcion de generar trabajos dependiendo el tipo de gestion"
        text += vbNewLine & "- Correccion de MIS GESTIONES, al ingresar desde ordenes, se modificaba el listado de MIS ORDENES"
        text += vbNewLine & "- Correcion de MIS GESTIONES, en ordenes se quita los status DUPLICADO"
        text += vbNewLine & "- Correcion de FILTRADO de trabajos en RED o MDU, al colocar zona no cargaba el trabajo asociado"
        text += vbNewLine & "- Nuevas opciones de BUSQUEDA dentro del modulo de Gestion de RED -> BUSQUEDA"
        text += vbNewLine & "     "
        text += "___________________________________________________" & vbNewLine
        text += "nueva version (3.1.1):" & vbNewLine
        text += vbNewLine & "- Correccion al abrir menu de crear trabajo, al salir se volvia a abrir haciendo click en el listado"
        text += vbNewLine & "- Correccion al generar un nuevo trabajo desde sector FUENTES, crea un nuevo trabajo por cada fuente en zona"
        text += vbNewLine & "- se mejora informacion en pantalla, al mover de gestion actualiza informacion de trabajo y de ordenes asociadas"
        text += vbNewLine & vbNewLine
        text += "___________________________________________________" & vbNewLine
        text += "nueva version (3.1.0):" & vbNewLine
        text += "- Se quita el foco al seleccionador de nodos, al seleccionar uno haciendo click, este pasa a el listado de gestiones en nodo" & vbNewLine
        text += "esto evita que se haga scroll en el nodo en vez de hacerlo sobre las gestiones"
        text += vbNewLine & "  - error al generar un trabajo nuevo en gestion nueva, dentro de MDU"
        text += vbNewLine & "     "
        text += vbNewLine & "     "


        TXTTexto.Text = text

    End Sub
End Class