# Chronicles of the Cursed Knight

![alt text](./Screens/cover.gif "Chronicles of the Cursed Knight")
**Grupo 5 - Proyecto de Videojuegos**

## Integrantes
- Trujillo Vistin Dennis Adrian
- Bryan Eduardo Loya Cadena
- Jhon Erick Enriquez Cali
- Ninabanda Pambabay Jhonny Eduardo

## Configuración de Git LFS (¡IMPORTANTE!)

Este proyecto utiliza **Git LFS (Large File Storage)** para gestionar de manera eficiente los archivos multimedia pesados (imágenes, audios, videos, modelos 3D y librerías) en la carpeta de Unity.

Para evitar que el motor de Unity se rompa al importar archivos temporales o vacíos, **todos los miembros del equipo deben tener instalado y activo Git LFS en sus equipos**:

### Pasos para configurar Git LFS:

1. **Instalar Git LFS:**
   * **Windows:** Descarga e instala el ejecutable desde [git-lfs.github.com](https://git-lfs.github.com/) o utiliza el administrador de paquetes en la terminal:
     ```bash
     winget install GitHub.GitLFS
     ```
   * **macOS:** Si usas Homebrew:
     ```bash
     brew install git-lfs
     ```
   * **Linux:** Si usas Debian/Ubuntu:
     ```bash
     sudo apt-get install git-lfs
     ```

2. **Activar Git LFS localmente:**
   Abre una terminal en tu computadora y ejecuta el siguiente comando (solo es necesario hacerlo una vez de manera global):
   ```bash
   git lfs install
   ```

3. **Descargar los archivos reales (si es necesario):**
   Si ya tenías clonado el repositorio y tus archivos de audio o imagen se ven corruptos o no cargan en Unity, abre la terminal dentro de la carpeta del proyecto y ejecuta:
   ```bash
   git lfs pull
   ```

Una vez completado esto, el flujo de trabajo para subir imágenes, audios o modelos 3D será automático.

## Licencia
Este proyecto es de código abierto y está licenciado bajo la [Licencia MIT](LICENSE).
