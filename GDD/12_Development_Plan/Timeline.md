\subsection{Planificación de Sprints e Hitos}

El cronograma de desarrollo del corte vertical de \textit{Chronicles of the Cursed Knight} se organiza bajo una metodología ágil adaptada, dividiendo un marco temporal de seis semanas en \textbf{tres Sprints de dos semanas cada uno}. Esta planificación preliminar de hitos asegura una integración continua y entregables jugables al término de cada ciclo.

\subsubsection*{Estructura de Sprints (Cronograma de 6 Semanas)}

A continuación se detalla la planificación de los hitos y los objetivos específicos asignados a cada Sprint de desarrollo:

\begin{center}
\begin{tabular}{|p{2.5cm}|p{3.8cm}|p{4.8cm}|p{3.1cm}|}
\hline
\textbf{Sprint y Semanas} & \textbf{Objetivo Principal} & \textbf{Entregables / Backlog} & \textbf{Hito Verificable} \\
\hline
\textbf{Sprint 1} \newline (Semanas 1--2) & \textbf{Cimientos Técnicos y Físicas:} Establecer el control responsivo de Sir Gareth y la geometría base del mundo. &
- Configuración Git LFS. \newline
- Movimiento horizontal ($5f$). \newline
- Salto y doble salto ($7f$). \newline
- Importación y slicing de sprites. \newline
- Construcción de Grid con Tilemaps. &
\textbf{Hito 1 (v0.1):} \newline
Jugador navegando en una sala gris de pruebas físicas con colisionadores activos. \\
\hline
\textbf{Sprint 2} \newline (Semanas 3--4) & \textbf{Combate, IA y Cámara:} Implementar la jugabilidad básica de ataque y los tres arquetipos de enemigos. &
- Flecha física y Object Pooling. \newline
- Mecánica de Dash ($15f$). \newline
- IA FSM (Ninja, Arquero, Esqueleto). \newline
- Colisión y Daño Mutuo (IFrames). \newline
- Cámara Cinemachine y Parallax 2.5D. &
\textbf{Hito 2 (v0.2):} \newline
Combate funcional y enemigos reactivos en el escenario final de los Jardines Marchitos. \\
\hline
\textbf{Sprint 3} \newline (Semanas 5--6) & \textbf{Sistemas, Audio y Pulido:} Integrar la economía, efectos sonoros, menús y depuración final. &
- Tienda del Eco de Elara e interactividad. \newline
- HUD dinámico de corazones y diamantes. \newline
- AudioManager (Música y catálogo de SFX). \newline
- Transiciones suaves con LeanTween. \newline
- Pruebas de QA y optimización de FPS. &
\textbf{Hito 3 (v1.0):} \newline
Corte vertical completo jugable y compilado en una build ejecutable para Windows. \\
\hline
\end{tabular}
\end{center}

\subsubsection*{Control de Hitos y Criterios de Aceptación}

Para que un entregable al final del Sprint se considere aprobado, debe cumplir con los siguientes criterios mínimos de aceptación:
\begin{itemize}
    \item \textbf{Criterio de Código:} Todo script implementado debe compilar en Unity 6 sin advertencias críticas y estar documentado internamente en español.
    \item \textbf{Criterio de Rendimiento:} La tasa de refresco en la build final ejecutable debe mantenerse a un mínimo estable de $60$ FPS a resolución $1920 \times 1080$.
    \item \textbf{Criterio de Control de Versiones:} Cada entrega debe estar vinculada a un tag de versión (\texttt{v0.1}, \texttt{v0.2}, \texttt{v1.0}) en la rama \texttt{main} del repositorio oficial de GitHub.
\end{itemize}

\subsubsection*{Roles del Equipo y Responsabilidades}

Para asegurar la ejecución fluida del proyecto bajo la estructura ágil de tres Sprints, se definen los siguientes roles del equipo académico y sus respectivas áreas de responsabilidad:

\begin{itemize}
    \item \textbf{Programador Principal (Lead Programmer):}
    \begin{itemize}
        \item \emph{Responsabilidad General:} Codificación de la lógica e interacciones del juego en C\#.
        \item \emph{Tareas por Sprint:} Implementación del `PlayerController.cs` y físicas básicas en el Sprint 1; desarrollo del sistema de proyectiles (`Arrow.cs`), daño físico, e IA FSM para los tres enemigos en el Sprint 2; programación del `AudioManager.cs` e integración de transiciones en el Sprint 3.
    \end{itemize}
    \item \textbf{Diseñador de Niveles y Sistemas (Systems \& Level Designer):}
    \begin{itemize}
        \item \emph{Responsabilidad General:} Diseño de la arquitectura de niveles, balance y flujo de progreso.
        \item \emph{Tareas por Sprint:} Setup de la escena en Unity y diseño de la geometría gris de plataformas (Greybox) en el Sprint 1; colocación de enemigos, triggers de salida y trampas en el nivel final de los Jardines en el Sprint 2; testeo y balance final de la dificultad y recolección de almas en el Sprint 3.
    \end{itemize}
    \item \textbf{Artista Técnico y UI (Technical Artist \& UI Designer):}
    \begin{itemize}
        \item \emph{Responsabilidad General:} Gestión e integración de assets artísticos, interfaces y animaciones.
        \item \emph{Tareas por Sprint:} Slicing e importación de sprites, creación de spritesheets y setups de Animator Controllers (Idle, Run, Jump) en el Sprint 1; configuración de capas de Parallax y partículas en el Sprint 2; desarrollo e integración de los Canvas HUD, menús de Victoria, Derrota y tienda con LeanTween en el Sprint 3.
    \end{itemize}
    \item \textbf{Diseñador de Sonido y QA (Sound Designer \& QA Tester):}
    \begin{itemize}
        \item \emph{Responsabilidad General:} Creación de la atmósfera sonora y control de calidad del software.
        \item \emph{Tareas por Sprint:} Búsqueda y adaptación de referencias de audio y efectos en el Sprint 1; pruebas de colisiones, bugs de salto y optimización de FPS en el Sprint 2; implementación del catálogo de SFX y música en el mezclador de Unity, pruebas generales del corte vertical y generación del ejecutable Windows final en el Sprint 3.
    \end{itemize}
\end{itemize}
