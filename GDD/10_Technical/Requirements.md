\subsection{Requisitos}

\subsubsection*{Requerimientos de desarrollo}

El equipo de desarrollo requiere Unity 6 LTS, un editor de código compatible con C\#, Git, Git LFS y acceso al repositorio de GitHub. Se recomienda utilizar una versión común del motor para evitar incompatibilidades en escenas, prefabs y paquetes.

\subsubsection*{Requerimientos funcionales}

El prototipo debe incluir de forma obligatoria las siguientes funcionalidades integradas:
\begin{itemize}
    \item Movimiento lateral y sistema de doble salto responsivo.
    \item Mecánica de evasión (Dash) en el Clic Derecho.
    \item Ataque a distancia con arco y flechas físicas en el Clic Izquierdo (sin combate cuerpo a cuerpo para el jugador).
    \item Tres arquetipos de enemigos con IA estructurada (Ninja, Arquero, Esqueleto) y sus respectivos Animator Controllers.
    \item Sistema de salud basado en corazones (5 HP máximos) y matriz de colisiones optimizada en 2D.
    \item Sistema de economía con recolección de Diamantes de Almas y tienda de mejoras en el Checkpoint (Eco de Elara).
    \item Interfaz gráfica (HUD) con contadores y textos flotantes de daño dinámicos.
    \item Pantallas de Menú Principal, Pausa, Derrota (con rebote animado) y Victoria (con deslizamiento animado).
    \item Hito geográfico con trigger físico como condición de finalización del nivel.
\end{itemize}

\subsubsection*{Requerimientos no funcionales}

El juego debe mantener una tasa de cuadros estable en equipos de gama media, ofrecer controles responsivos sin retardo de entrada, presentar una interfaz legible y escalable en resoluciones comunes mediante Canvas Scaler a 1920x1080, y conservar una organización de proyecto comprensible para el equipo.

\subsubsection*{Requisitos de Hardware del Sistema (PC - Windows)}

Para asegurar una reproducción de físicas estable y una tasa mínima de refresco de $60$ FPS, se establecen los siguientes requisitos de hardware para los usuarios finales:

\begin{center}
\begin{tabular}{|p{3cm}|p{5.5cm}|p{5.5cm}|}
\hline
\textbf{Componente} & \textbf{Especificación Mínima} & \textbf{Especificación Recomendada} \\
\hline
\textbf{Sistema Operativo} & Windows 10 (64-bit) & Windows 10 / 11 (64-bit) \\
\hline
\textbf{Procesador (CPU)} & Intel Core i3-4160 / AMD A8-7600 & Intel Core i5-4670K / AMD FX-8350 o superior \\
\hline
\textbf{Memoria RAM} & $4$ GB de RAM & $8$ GB de RAM \\
\hline
\textbf{Tarjeta Gráfica (GPU)} & Intel HD Graphics 4400 / NVIDIA GeForce GT 730 (DirectX 11) & NVIDIA GeForce GTX 750 Ti / AMD Radeon R7 260X ($2$ GB VRAM) \\
\hline
\textbf{Almacenamiento} & $200$ MB de espacio libre & $200$ MB de espacio libre \\
\hline
\textbf{Resolución de Pantalla} & $1280 \times 720$ píxeles & $1920 \times 1080$ píxeles (relación de aspecto 16:9) \\
\hline
\end{tabular}
\end{center}

\subsubsection*{Configuración de repositorio}

El archivo \texttt{.gitignore} debe estar configurado para Unity, ignorando carpetas de caché local como \texttt{Library}, \texttt{Temp}, \texttt{Obj}, \texttt{Builds} y otros archivos generados localmente por el motor o el entorno de desarrollo. Los activos binarios pesados (sprites, fuentes, audios) deben rastrearse mediante Git LFS.

\subsubsection*{Criterios mínimos de entrega}

La entrega académica debe incluir un archivo ejecutable funcional para Windows, el repositorio Git organizado, documentación completa del GDD en formato LaTeX, evidencia de control de versiones con commits descriptivos, capturas o video de demostración y descripción de riesgos y mitigaciones.
