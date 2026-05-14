# Guia de contribucion

Este documento define las reglas minimas para contribuir al repositorio de **Project Arrow / Chronicles of the Cursed Knight**. El objetivo es mantener un historial claro, revisable y consistente entre todos los integrantes del equipo.

## Flujo general

1. Actualizar la rama local antes de comenzar a trabajar.
2. Crear una rama para cada cambio o grupo de cambios relacionados.
3. Realizar commits pequenos, descriptivos y con un formato uniforme.
4. Abrir un Pull Request con una descripcion clara del cambio realizado.
5. Esperar revision antes de fusionar cambios importantes.

## Formato de commits

Todos los commits deben seguir este formato:

```text
tipo(alcance): descripcion breve
```

Ejemplo:

```text
docs(gdd): actualizar plan de desarrollo
```

La descripcion debe escribirse en infinitivo o presente, en minusculas y sin punto final.

### Tipos permitidos

- `docs`: cambios en documentacion, GDD, README o archivos academicos.
- `feat`: nueva funcionalidad del juego o del proyecto.
- `fix`: correccion de errores.
- `refactor`: reorganizacion interna sin cambiar comportamiento.
- `style`: cambios visuales, formato o presentacion sin alterar logica.
- `assets`: incorporacion, reemplazo o eliminacion de imagenes, audio, sprites u otros recursos.
- `chore`: tareas de mantenimiento, configuracion o limpieza general.
- `test`: pruebas, validaciones o archivos relacionados con QA.

### Alcances recomendados

Usar el alcance para indicar la zona afectada:

- `gdd`
- `portada`
- `gameplay`
- `ui`
- `audio`
- `ai`
- `technical`
- `assets`
- `repo`

Ejemplos validos:

```text
docs(gdd): corregir seccion de riesgos
docs(portada): actualizar integrantes del grupo
assets(gdd): reemplazar imagen de portada
feat(gameplay): agregar movimiento base del jugador
fix(ui): corregir contador de vida en HUD
chore(repo): actualizar configuracion de gitignore
```

## Reglas para escribir commits

- Evitar mensajes genericos como `Cambios`, `Actualizacion`, `Subida de archivo` o `Arreglos varios`.
- Cada commit debe representar una intencion clara.
- No mezclar cambios de codigo, documentacion y assets en un mismo commit si no dependen entre si.
- Si un cambio modifica la portada y ademas reemplaza una imagen usada por la portada, se recomienda separar en dos commits:
  - `assets(gdd): reemplazar imagen de portada`
  - `docs(portada): actualizar contenido de portada`
- No incluir archivos temporales, builds generados o archivos personales.

## Pull Requests

Cada Pull Request debe incluir:

- Resumen breve de lo realizado.
- Archivos o secciones afectadas.
- Motivo del cambio.
- Capturas o evidencia si el cambio es visual.
- Confirmacion de que el proyecto o documento fue revisado cuando aplique.

Formato recomendado:

```markdown
## Resumen
- Describe los cambios principales.

## Archivos afectados
- Lista las carpetas o archivos mas importantes.

## Verificacion
- Indica como se reviso el cambio.
```

## Convenciones para ramas

Usar nombres breves y descriptivos:

```text
docs/gdd-riesgos
docs/portada-cover
feat/player-movement
fix/hud-health
assets/menu-screens
```

## Antes de abrir un PR

- Revisar que el historial de commits sea claro.
- Confirmar que no existan archivos innecesarios en el commit.
- Verificar ortografia en documentos del GDD.
- Comprobar que las imagenes y referencias usadas existan en el repositorio.
- Mantener la rama actualizada con `master`.
