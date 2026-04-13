# Calculadora Con Delegados (C#)
## Descripción

Este proyecto consiste en una aplicación de consola desarrollada en **C#** que permite realizar operaciones matemáticas básicas: suma, resta, multiplicación y división.

El programa solicita al usuario seleccionar una operación y luego introducir dos números. La operación se ejecuta utilizando delegados, lo que permite asignar dinámicamente el método correspondiente.

# ¿Qué es un delegado?

Un delegado en C# es un tipo que permite referenciar métodos y ejecutarlos dinámicamente.
Funciona como una variable que puede apuntar a diferentes métodos que tengan la misma estructura de parámetros y tipo de retorno.

## Ejemplo:

```csharp
public delegate int Operacion(int a, int b);
```

## Uso de Delegados 
El uso de delegados permite cambiar dinámicamente un metodo durante la ejecución también nor permite
- Ejecutar diferentes métodos con la misma estructura.
- Facilitan agregar nuevas operaciones.
- Hacen el código más organizado y escalable.

## Pasos de su implementación

- Se creo un proyecto de consola en C#.
- Crear el archivo Operaciones.cs con los métodos matemáticos.
- Definimos el delegado Operacion.
- Creamos un menú en Program.cs para que el usuario seleccione la operación.
- Asignar dinámicamente el método correspondiente al delegado.

# Ejemplo de Uso

## Suma

## Entrada:

<img width="1366" height="768" alt="Captura de pantalla (26)" src="https://github.com/user-attachments/assets/585cc93a-5f4f-418f-a002-0bf83675ebb2" />

## Salida:

<img width="1366" height="768" alt="Captura de pantalla (27)" src="https://github.com/user-attachments/assets/9faa2a31-4d09-4531-8beb-a8c3d5893265" />

## División

## Entrada:

<img width="1366" height="768" alt="Captura de pantalla (28)" src="https://github.com/user-attachments/assets/d4d2b174-6a09-4a10-80a4-c89b2158a3d6" />


##bSalida:

<img width="1366" height="768" alt="Captura de pantalla (29)" src="https://github.com/user-attachments/assets/700e8032-32f1-4083-9cfc-309ff09cafcc" />


