# 🎢 Sistema de Gestión de Parque de Diversiones

## 📋 Descripción

Este proyecto implementa un sistema de gestión completo para un parque de diversiones, permitiendo la administración de atracciones, venta de manillas (pulseras), control de puntos y registro de actividades de los visitantes.

## 🏗️ Arquitectura del Sistema

El sistema está diseñado siguiendo principios de programación orientada a objetos y consta de las siguientes clases principales:

### Clases Principales

- **`Parque`**: Clase central que gestiona todo el parque
- **`Atraccion`**: Representa cada atracción del parque
- **`Manilla`**: Pulsera electrónica que contiene puntos del visitante
- **`Taquilla`**: Punto de venta de manillas y recarga de puntos
- **`Registro`**: Registro de uso de atracciones por parte de los visitantes

## 🚀 Características Principales

### Gestión de Atracciones
- ✅ Configuración de atracciones con nombre, puntos requeridos y duración
- ✅ Validación de duración (entre 1 y 5 minutos)
- ✅ Sistema de descuento de puntos automático
- ✅ Registro de uso de atracciones

### Sistema de Manillas
- ✅ Generación automática de 1000 manillas únicas
- ✅ ID único aleatorio para cada manilla
- ✅ Control de saldo de puntos
- ✅ Validación de saldo antes de usar atracciones

### Taquillas
- ✅ 3 taquillas operativas
- ✅ 100 manillas por taquilla
- ✅ Sistema de venta con validaciones
- ✅ Control de ingresos por ventas

### Configuración de Precios
- 💰 **Entrada**: $4,000
- 💰 **Carga mínima**: $20,000
- 💰 **Valor por punto**: $500

## 🛠️ Tecnologías Utilizadas

- **Lenguaje**: C# (.NET 6.0)
- **Paradigma**: Programación Orientada a Objetos
- **IDE**: Visual Studio / Visual Studio Code
- **Sistema Operativo**: Windows (compatible con otros)

## 🎯 Uso del Sistema

### Configuración Inicial
El sistema se inicializa con las siguientes atracciones predefinidas:

| Atracción | Puntos | Duración |
|-----------|--------|----------|
| HULK | 30 | 1:50 min |
| CAPITAN AMERICA | 30 | 1:20 min |
| KARTS sencillos | 20 | 5:00 min |
| Montaña Acuática | 25 | 3:00 min |
| Ciclón | 15 | 2:00 min |

### Flujo de Operación

1. **Venta de Manillas**: Los visitantes compran manillas en las taquillas
2. **Carga de Puntos**: Se cargan puntos según el monto pagado
3. **Uso de Atracciones**: Los visitantes usan las atracciones descontando puntos
4. **Registro**: Se mantiene un registro de todas las actividades

## 📊 Estructura del Proyecto

```
p_parque/
├── Clases/
│   ├── Atraccion.cs      # Gestión de atracciones
│   ├── Manilla.cs        # Sistema de pulseras
│   ├── Parque.cs         # Clase principal del parque
│   ├── Registro.cs       # Registro de actividades
│   └── Taquilla.cs       # Gestión de taquillas
├── Program.cs            # Punto de entrada
├── p_parque.csproj       # Configuración del proyecto
└── README.md            # Este archivo
```

## 🔧 Configuración y Personalización

### Modificar Atracciones
Para agregar o modificar atracciones, edita el archivo `Program.cs`:

```csharp
l_atracciones.Add(new Atraccion("NUEVA_ATRACCION", 25, new TimeSpan(0, 2, 30)));
```

### Ajustar Precios
Los precios se configuran en la clase `Parque`:

```csharp
internal static uint vlr_entada = 4000;        // Precio de entrada
internal static uint vlr_min_carga = 20000;    // Carga mínima
internal static uint vlr_punto = 500;          // Valor por punto
```

## 🧪 Funcionalidades Implementadas

### ✅ Completadas
- [x] Sistema de atracciones con validaciones
- [x] Gestión de manillas con ID único
- [x] Sistema de taquillas con inventario
- [x] Control de puntos y saldos
- [x] Registro de actividades
- [x] Validaciones de negocio
- [x] Manejo de excepciones

## 🐛 Solución de Problemas

### Errores Comunes

1. **"La duración debe ser entre 1 y 5 minutos"**
   - Verificar que la duración de las atracciones esté en el rango permitido

2. **"Saldo insuficiente"**
   - Asegurar que la manilla tenga suficientes puntos antes de usar una atracción

3. **"Dinero insuficiente, o no hay manillas"**
   - Verificar que el monto sea mayor a $20,000 y que la taquilla tenga manillas disponibles


---

**Desarrollado con ❤️ para la gestión eficiente de parques de diversiones**
