Imports System
Module almacen_de_suministros
    Sub Main(args As String())
        Dim ids(9) As Integer
        Dim productos(9) As String
        Dim categorias(9) As String
        Dim cantidades(9) As Integer
        Dim unidades(9) As String
        Dim preciosUnitarios(9) As Double
        Dim valoresTotales(9) As Double
        Dim proveedores(9) As String
        Dim estados(9) As String
        Dim fechas(9) As String
        Dim observaciones(9) As String
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '-------------------------------------------'
        '--|menu_principal_almacen_de_suministros|--'
        '-------------------------------------------'
        Do
            Console.WriteLine("menu principal almacen de suministros")
            Console.WriteLine("1) Registrar suministro")
            Console.WriteLine("2) Editar suministro")
            Console.WriteLine("3) Listar suministros")
            Console.WriteLine("4) Buscar suministro")
            Console.WriteLine("5) Eliminar suministro")
            Console.WriteLine("6) Mostrar resumen")
            Console.WriteLine("7) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '--------------------------'
                '--|registrar_suministro|--'
                '--------------------------'
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("No hay espacio para registrar mas suministros.")
                    Else
                        ids(cantidad) = cantidad + 1
                        Console.Write("Producto: ")
                        productos(cantidad) = Console.ReadLine()
                        Console.Write("Categoria: ")
                        categorias(cantidad) = Console.ReadLine()
                        Console.Write("Cantidad: ")
                        cantidades(cantidad) = Convert.ToInt32(Console.ReadLine())
                        Console.Write("Unidad: ")
                        unidades(cantidad) = Console.ReadLine()
                        Console.Write("Precio unitario: ")
                        preciosUnitarios(cantidad) = Convert.ToDouble(Console.ReadLine())
                        valoresTotales(cantidad) = cantidades(cantidad) * preciosUnitarios(cantidad)
                        Console.Write("Proveedor: ")
                        proveedores(cantidad) = Console.ReadLine()
                        Console.Write("Estado: ")
                        estados(cantidad) = Console.ReadLine()
                        Console.Write("Fecha: ")
                        fechas(cantidad) = Console.ReadLine()
                        Console.Write("Observacion: ")
                        observaciones(cantidad) = Console.ReadLine()
                        cantidad += 1
                        Console.WriteLine("Suministro registrado correctamente.")
                    End If
                '-----------------------'
                '--|editar_suministro|--'
                '-----------------------'
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No existen suministros registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Producto: " & productos(i) & " | Categoria: " & categorias(i) & " | Cantidad: " & cantidades(i) & " | Unidad: " & unidades(i) & " | Precio unitario: " & preciosUnitarios(i) & " | Valor total: " & valoresTotales(i) & " | Proveedor: " & proveedores(i) & " | Estado: " & estados(i) & " | Fecha: " & fechas(i) & " | Observacion: " & observaciones(i))
                        Next
                        Console.Write("Ingrese el ID del suministro a editar: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEditar >= 1 And idEditar <= cantidad Then
                            Dim posicion As Integer = idEditar - 1
                            Console.Write("Nuevo producto: ")
                            productos(posicion) = Console.ReadLine()
                            Console.Write("Nueva categoria: ")
                            categorias(posicion) = Console.ReadLine()
                            Console.Write("Nueva cantidad: ")
                            cantidades(posicion) = Convert.ToInt32(Console.ReadLine())
                            Console.Write("Nueva unidad: ")
                            unidades(posicion) = Console.ReadLine()
                            Console.Write("Nuevo precio unitario: ")
                            preciosUnitarios(posicion) = Convert.ToDouble(Console.ReadLine())
                            valoresTotales(posicion) = cantidades(posicion) * preciosUnitarios(posicion)
                            Console.Write("Nuevo proveedor: ")
                            proveedores(posicion) = Console.ReadLine()
                            Console.Write("Nuevo estado: ")
                            estados(posicion) = Console.ReadLine()
                            Console.Write("Nueva fecha: ")
                            fechas(posicion) = Console.ReadLine()
                            Console.Write("Nueva observacion: ")
                            observaciones(posicion) = Console.ReadLine()
                            Console.WriteLine("Suministro actualizado correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '------------------------'
                '--|listar_suministros|--'
                '------------------------'
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No existen suministros registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Producto: " & productos(i) & " | Categoria: " & categorias(i) & " | Cantidad: " & cantidades(i) & " | Unidad: " & unidades(i) & " | Precio unitario: " & preciosUnitarios(i) & " | Valor total: " & valoresTotales(i) & " | Proveedor: " & proveedores(i) & " | Estado: " & estados(i) & " | Fecha: " & fechas(i) & " | Observacion: " & observaciones(i))
                        Next
                    End If
                '-----------------------'
                '--|buscar_suministro|--'
                '-----------------------'
                Case 4
                    If cantidad = 0 Then
                        Console.WriteLine("No existen suministros registrados.")
                    Else
                        Console.Write("Ingrese el ID del suministro a buscar: ")
                        Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idBuscar >= 1 And idBuscar <= cantidad Then
                            Dim posicion As Integer = idBuscar - 1
                            Console.WriteLine("ID: " & ids(posicion) & " | Producto: " & productos(posicion) & " | Categoria: " & categorias(posicion) & " | Cantidad: " & cantidades(posicion) & " | Unidad: " & unidades(posicion) & " | Precio unitario: " & preciosUnitarios(posicion) & " | Valor total: " & valoresTotales(posicion) & " | Proveedor: " & proveedores(posicion) & " | Estado: " & estados(posicion) & " | Fecha: " & fechas(posicion) & " | Observacion: " & observaciones(posicion))
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '-------------------------'
                '--|eliminar_suministro|--'
                '-------------------------'
                Case 5
                    If cantidad = 0 Then
                        Console.WriteLine("No existen suministros registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Producto: " & productos(i) & " | Categoria: " & categorias(i) & " | Cantidad: " & cantidades(i) & " | Unidad: " & unidades(i) & " | Precio unitario: " & preciosUnitarios(i) & " | Valor total: " & valoresTotales(i) & " | Proveedor: " & proveedores(i) & " | Estado: " & estados(i) & " | Fecha: " & fechas(i) & " | Observacion: " & observaciones(i))
                        Next
                        Console.Write("Ingrese el ID del suministro a eliminar: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEliminar >= 1 And idEliminar <= cantidad Then
                            Dim posicion As Integer = idEliminar - 1
                            For i As Integer = posicion To cantidad - 2
                                ids(i) = ids(i + 1)
                                productos(i) = productos(i + 1)
                                categorias(i) = categorias(i + 1)
                                cantidades(i) = cantidades(i + 1)
                                unidades(i) = unidades(i + 1)
                                preciosUnitarios(i) = preciosUnitarios(i + 1)
                                valoresTotales(i) = valoresTotales(i + 1)
                                proveedores(i) = proveedores(i + 1)
                                estados(i) = estados(i + 1)
                                fechas(i) = fechas(i + 1)
                                observaciones(i) = observaciones(i + 1)
                            Next
                            cantidad -= 1
                            Console.WriteLine("Suministro eliminado correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '---------------------'
                '--|mostrar_resumen|--'
                '---------------------'
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No existen suministros registrados.")
                    Else
                        Dim disponibles As Integer = 0
                        Dim stockBajo As Integer = 0
                        Dim agotados As Integer = 0
                        Dim reservados As Integer = 0
                        Dim totalUnidades As Integer = 0
                        Dim valorInventario As Double = 0
                        Dim oficina As Integer = 0
                        Dim limpieza As Integer = 0
                        Dim mantenimiento As Integer = 0
                        Dim tecnologia As Integer = 0
                        Dim seguridad As Integer = 0
                        Dim papeleria As Integer = 0
                        For i As Integer = 0 To cantidad - 1
                            totalUnidades += cantidades(i)
                            valorInventario += valoresTotales(i)
                            If estados(i).ToLower() = "disponible" Then
                                disponibles += 1
                            ElseIf estados(i).ToLower() = "stock bajo" Then
                                stockBajo += 1
                            ElseIf estados(i).ToLower() = "agotado" Then
                                agotados += 1
                            ElseIf estados(i).ToLower() = "reservado" Then
                                reservados += 1
                            End If
                            If categorias(i).ToLower() = "oficina" Then
                                oficina += 1
                            ElseIf categorias(i).ToLower() = "limpieza" Then
                                limpieza += 1
                            ElseIf categorias(i).ToLower() = "mantenimiento" Then
                                mantenimiento += 1
                            ElseIf categorias(i).ToLower() = "tecnologia" Then
                                tecnologia += 1
                            ElseIf categorias(i).ToLower() = "seguridad" Then
                                seguridad += 1
                            ElseIf categorias(i).ToLower() = "papeleria" Then
                                papeleria += 1
                            End If
                        Next
                        Console.WriteLine("Suministros: " & cantidad & " | Unidades: " & totalUnidades & " | Disponibles: " & disponibles & " | Stock bajo: " & stockBajo & " | Agotados: " & agotados & " | Reservados: " & reservados & " | Oficina: " & oficina & " | Limpieza: " & limpieza & " | Mantenimiento: " & mantenimiento & " | Tecnologia: " & tecnologia & " | Seguridad: " & seguridad & " | Papeleria: " & papeleria & " | Valor inventario: " & valorInventario)
                    End If
                '------------------------------'
                '--|salir_del_menu_principal|--'
                '------------------------------'
                Case 7
                    Console.WriteLine("Gracias por utilizar Almacen de Suministros.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 7
    End Sub
End Module