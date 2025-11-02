# My Ball Project

Un pequeño juego creado en **Unity** donde controlas una bola que se mueve por el escenario, recoge objetos ("pickups") y evita caer fuera del mapa. Al recolectar todos los objetos, ganas y la partida se reinicia automáticamente.

---

## Características

- Movimiento de la bola con el teclado (usando el **Nuevo Input System**)
- Salto con la tecla **Espacio**
- Recolección de objetos que desaparecen al tocarlos
- Contador de objetos recogidos en pantalla (UI con TextMeshPro)
- Mensaje de victoria al completar los 10 pickups
- Reinicio automático de la escena al ganar o caer del escenario
- Creador: *[Tu nombre completo]*

---

## Controles

| Acción | Tecla |
|--------|-------|
| Mover la bola | Flechas |
| Saltar | Barra espaciadora |
| Reiniciar (automático) | Al ganar o caer |

---

## Requisitos del sistema

- Unity versión **2022.3 LTS** o superior  
- Nuevo Input System activado  
- Paquete `TextMeshPro` instalado

---

## Estructura del proyecto

Assets/
├── Materials/ # Materiales del escenario y la bola
├── Prefabs/ # Prefabs de pickups
├── Scenes/
│ └── MiniGame.unity
├── Scripts/
│ ├── PlayerController.cs
│ ├── CameraController.cs
│ └── Rotator.cs
└── UI/
└── TextMeshPro objects



---

## Scripts principales

### `PlayerController.cs`
Controla el movimiento, salto, recogida de objetos y reinicio de la escena.

### `CameraController.cs`
Hace que la cámara siga suavemente a la bola.

### `Rotator.cs`
Hace girar los pickups para darles dinamismo visual.

---

## Cómo ejecutar el proyecto

1. Abre Unity Hub.
2. Crea un proyecto nuevo con la plantilla 3D (Core).
3. Copia la carpeta del proyecto o clónala desde GitHub.
4. Abre la escena principal (`MiniGame.unity`).
5. Presiona *Play* para jugar.

---

## Créditos

- Desarrollado por: **Abián Miguel Suárez Castro**
- Hecho con: [Unity](https://unity.com/)
- Basado en tutoriales de Unity Learn y prácticas del curso de GSDAM

---

## Licencia

Este proyecto es de uso educativo. Puedes modificarlo y distribuirlo libremente citando al autor original.
