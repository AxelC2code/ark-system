# Ark System: Sistema de Gestión de Inventario

Ark System es una aplicación de escritorio desarrollada en **C\# con Windows Forms**, diseñada para la gestión eficiente de inventarios. Permite a los usuarios registrar productos, clasificarlos por categorías, realizar búsquedas, aplicar ordenamientos avanzados y calcular el stock total de manera organizada.

## ✨ Características Principales

  * **Registro de Productos**: Añade nuevos productos al inventario especificando nombre, categoría, precio y cantidad. El sistema valida los datos de entrada para evitar inconsistencias, como campos vacíos o precios negativos.
  * **Búsqueda Avanzada**: Realiza una búsqueda lineal para encontrar productos por su nombre, mostrando los resultados que coincidan con el término de búsqueda.
  * **Ordenamiento de Productos**: Organiza la lista de productos por precio, permitiendo un ordenamiento tanto **ascendente** como **descendente** mediante el algoritmo de *Insertion Sort*.
  * **Cálculo de Stock por Categoría**: Calcula automáticamente el stock total de productos para cada categoría utilizando un método **recursivo**, ofreciendo una vista rápida y consolidada de las existencias.
  * **Manejo de Excepciones**: El sistema está preparado para gestionar errores comunes de usuario (como ingresar texto en campos numéricos) y del sistema (como la lectura de archivos), garantizando su estabilidad.
  * **Interfaz Gráfica Intuitiva**: Diseñada para ser fácil de usar, con todos los módulos accesibles desde una única ventana principal.

![Interfaz de Ark System](https://github.com/AxelC2code/ark-system/blob/main/G7_GestionInventario/Recursos/interfaz.png)

## 🚀 Tecnologías Utilizadas

  * **Lenguaje**: C\#
  * **Framework**: .NET Framework
  * **Plataforma**: Windows Forms
  * **Entorno de Desarrollo**: Microsoft Visual Studio

## 💡 Conceptos Clave Implementados

Este proyecto no solo es una herramienta funcional, sino también una demostración práctica de varios conceptos fundamentales de la programación y la ingeniería de software:

  * **Programación Orientada a Objetos (POO)**: La estructura del sistema se basa en clases como `G7_Producto` y `G7_Categoria` que modelan entidades del mundo real, encapsulando sus datos y comportamientos.
  * **Estructuras de Datos**: Se utiliza `List<T>` para gestionar la colección de productos de forma dinámica y `Dictionary<TKey, TValue>` para organizar y acceder a las categorías de manera eficiente.
  * **Algoritmos de Ordenamiento**: Se implementó el algoritmo **Insertion Sort** para ordenar los productos por precio, una solución eficiente para listas de tamaño moderado.
  * **Recursividad**: El cálculo del stock por categoría se realiza mediante una función recursiva, lo que demuestra un enfoque elegante para resolver problemas que pueden dividirse en subtareas más pequeñas.
  * **Manejo de Errores**: Se utiliza el bloque `try-catch` para controlar excepciones y evitar que la aplicación se cierre inesperadamente ante entradas inválidas o errores operativos.

## ⚙️ Cómo Ejecutar el Proyecto

1.  **Clonar el repositorio**:
    ```bash
    git clone https://github.com/AxelC2code/ark-system.git
    ```
2.  **Abrir en Visual Studio**:
      * Abre el archivo de la solución `T2_FP_G7.sln` con Visual Studio.
3.  **Restaurar dependencias**:
      * Visual Studio debería restaurar automáticamente los paquetes y dependencias del proyecto.
4.  **Ejecutar**:
      * Inicia la depuración (presionando `F5` o el botón "Start") para compilar y ejecutar la aplicación.

El programa cargará automáticamente un conjunto de datos de ejemplo desde un archivo `data.txt` para que puedas probar las funcionalidades de inmediato.

## 📄 Licencia

Este proyecto está bajo la Licencia MIT. Consulta el archivo `LICENSE` para más detalles.
