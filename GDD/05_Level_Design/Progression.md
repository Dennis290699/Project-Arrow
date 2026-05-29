\subsection{Progresión}

\subsubsection*{Curva de dificultad}

La progresión de dificultad en el prototipo está estructurada para permitir la familiarización con las mecánicas del juego antes de introducir retos combinados:
\begin{itemize}
    \item \textbf{Fase 1: Aprendizaje Seguro.} El jugador se familiariza con el movimiento horizontal y los saltos básicos sin riesgos de muerte inmediata.
    \item \textbf{Fase 2: Reto de Precisión.} Se introducen los saltos sobre fosos y las primeras trampas de pinchos fijas, que exigen coordinar el salto y el doble salto.
    \item \textbf{Fase 3: Introducción al Combate.} Se introducen enemigos estáticos (Arqueros) y lentos (Esqueletos) en plataformas anchas para practicar el disparo con arco.
    \item \textbf{Fase 4: Reto Combinado.} Enemigos rápidos (Ninjas) aparecen junto con trampas móviles (sierras), exigiendo el uso del Dash y reflejos ágiles.
\end{itemize}

\subsubsection*{Estructura del tutorial orgánico (Jardines Marchitos)}

El diseño del nivel \textit{Jardines Marchitos} actúa como un tutorial interactivo directo, donde el entorno enseña las mecánicas al jugador de manera no intrusiva:

\begin{enumerate}
    \item \textbf{Movimiento básico (W/D):} El juego inicia en una plataforma plana y cerrada. No hay amenazas. El jugador experimenta con las teclas \texttt{W} (desplazarse a la izquierda) y \texttt{D} (desplazarse a la derecha) para poder avanzar.
    \item \textbf{Salto y Doble Salto (Espacio):} El camino se interrumpe por una pared de $2$ unidades de altura. El jugador debe presionar \texttt{Espacio} para saltar. Inmediatamente después, encuentra un foso de $4$ unidades de ancho que requiere presionar \texttt{Espacio} dos veces seguidas en el aire para ejecutar el doble salto.
    \item \textbf{Ataque a distancia (Clic Izquierdo):} Una barrera destructiva o un enemigo lento (Esqueleto Reanimado) bloquea el camino en una zona segura de desniveles. Un indicador visual sutil sugiere presionar el \textbf{Clic Izquierdo} del mouse para apuntar y disparar una flecha física, destruyendo la barrera o eliminando al enemigo de forma segura a distancia.
    \item \textbf{Evasión y Dash (Clic Derecho):} El jugador ingresa a un pasillo donde se activa un péndulo de sierra o un Ninja de la Sombra realiza una embestida rápida. Para progresar sin recibir daño, debe presionar el \textbf{Clic Derecho} del mouse en la dirección del movimiento, ejecutando el Dash horizontal rápido para pasar bajo la trampa o esquivar el ataque hostil.
\end{enumerate}
