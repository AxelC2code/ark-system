# Ark System: Sistema de Gestión de Inventario

Ark System es una aplicación de escritorio desarrollada en **C\# con Windows Forms**, diseñada para la gestión eficiente de inventarios. Permite a los usuarios registrar productos, clasificarlos por categorías, realizar búsquedas, aplicar ordenamientos avanzados y calcular el stock total de manera organizada.

## ✨ Características Principales

  * **Registro de Productos**: Añade nuevos productos al inventario especificando nombre, categoría, precio y cantidad. [cite\_start]El sistema valida los datos de entrada para evitar inconsistencias, como campos vacíos o precios negativos[cite: 41, 44, 45].
  * [cite\_start]**Búsqueda Avanzada**: Realiza una búsqueda lineal para encontrar productos por su nombre, mostrando los resultados que coincidan con el término de búsqueda[cite: 50].
  * [cite\_start]**Ordenamiento de Productos**: Organiza la lista de productos por precio, permitiendo un ordenamiento tanto **ascendente** como **descendente** mediante el algoritmo de *Insertion Sort*[cite: 52, 53].
  * [cite\_start]**Cálculo de Stock por Categoría**: Calcula automáticamente el stock total de productos para cada categoría utilizando un método **recursivo**, ofreciendo una vista rápida y consolidada de las existencias[cite: 59, 216].
  * [cite\_start]**Manejo de Excepciones**: El sistema está preparado para gestionar errores comunes de usuario (como ingresar texto en campos numéricos) y del sistema (como la lectura de archivos), garantizando su estabilidad[cite: 179, 180, 181].
  * **Interfaz Gráfica Intuitiva**: Diseñada para ser fácil de usar, con todos los módulos accesibles desde una única ventana principal.

## 🚀 Tecnologías Utilizadas

  * **Lenguaje**: C\#
  * **Framework**: .NET Framework
  * **Plataforma**: Windows Forms
  * **Entorno de Desarrollo**: Microsoft Visual Studio

## 💡 Conceptos Clave Implementados

Este proyecto no solo es una herramienta funcional, sino también una demostración práctica de varios conceptos fundamentales de la programación y la ingeniería de software:

  * [cite\_start]**Programación Orientada a Objetos (POO)**: La estructura del sistema se basa en clases como `G7_Producto` [cite: 95, 96] [cite\_start]y `G7_Categoria` [cite: 211, 212] que modelan entidades del mundo real, encapsulando sus datos y comportamientos.
  * [cite\_start]**Estructuras de Datos**: Se utiliza `List<T>` para gestionar la colección de productos de forma dinámica y `Dictionary<TKey, TValue>` para organizar y acceder a las categorías de manera eficiente[cite: 41, 42].
  * [cite\_start]**Algoritmos de Ordenamiento**: Se implementó el algoritmo **Insertion Sort** para ordenar los productos por precio, una solución eficiente para listas de tamaño moderado[cite: 52].
  * [cite\_start]**Recursividad**: El cálculo del stock por categoría se realiza mediante una función recursiva, lo que demuestra un enfoque elegante para resolver problemas que pueden dividirse en subtareas más pequeñas[cite: 216, 217].
  * [cite\_start]**Manejo de Errores**: Se utiliza el bloque `try-catch` para controlar excepciones y evitar que la aplicación se cierre inesperadamente ante entradas inválidas o errores operativos[cite: 179].

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
