\subsection{NPCs (Non-Playable Characters)}

\subsubsection*{El Eco de Elara}

El único personaje no hostil presente en el prototipo es el \textbf{Eco de Elara}. Se trata de una manifestación espiritual y etérea de Elara, una figura del pasado del reino vinculada a Sir Gareth y a la Orden de los Guardianes. El Eco de Elara cumple un rol triple en el diseño de juego: guía narrativa, punto de restauración física (\emph{Checkpoint}) y centro de mejoras estadísticas del personaje.

\subsubsection*{Flujo de interacción y Menú de Mejoras (User Flow)}

El proceso para interactuar con la estatua espiritual y adquirir mejoras sigue una secuencia de estados estructurada para garantizar la seguridad de las transacciones y pausar la simulación de juego:

\begin{enumerate}
    \item \textbf{Detección y Activación:} El jugador se aproxima físicamente a la estatua. Al entrar en el volumen de detección de su \texttt{BoxCollider2D} (configurado en modo Trigger), se habilita la interacción. El jugador presiona la tecla de interacción \texttt{"E"} para abrir el menú.
    \item \textbf{Pausa del Juego (Pause State):} Al abrirse el menú, el \texttt{GameManager} establece temporalmente la escala de tiempo a cero (\texttt{Time.timeScale = 0f}). Esto congela inmediatamente las físicas, detiene el movimiento de los enemigos y las sierras, y suspende los temporizadores del juego.
    \item \textbf{Despliegue del Canvas de Tienda:} Se activa la interfaz visual de la tienda mediante una transición suave de opacidad. El panel de la interfaz consulta y renderiza en pantalla el valor actual de la variable \texttt{currentDiamonds} del inventario del jugador.
    \item \textbf{Validación de la Transacción:} Al hacer clic en un botón de mejora, el sistema realiza la siguiente verificación lógica:
    \begin{itemize}
        \item \textbf{Saldo Insuficiente:} Si el costo de la mejora es superior a \texttt{currentDiamonds}, se cancela la transacción y se reproduce un efecto de sonido de error (feedback negativo).
        \item \textbf{Saldo Suficiente:} Si es verdadero, se restan los diamantes del total del jugador, se aplica la mejora de forma permanente en el script del personaje, se actualiza el HUD y se reproduce una señal sonora de éxito (feedback positivo).
    \end{itemize}
    \item \textbf{Reanudación del Juego:} Al presionar el botón "Cerrar" o la tecla \texttt{Esc}, el Canvas se desactiva y el motor restablece la escala de tiempo a uno (\texttt{Time.timeScale = 1f}), reanudando la simulación física de la partida.
\end{enumerate}

\subsubsection*{Árbol de mejoras, costos e incrementos matemáticos}

Las mejoras disponibles en el Eco de Elara permiten personalizar las estadísticas de Sir Gareth para afrontar las zonas más difíciles de los niveles:

\begin{itemize}
    \item \textbf{Mejora de Vitalidad (Salud Máxima):}
    \begin{itemize}
        \item \textbf{Efecto:} Añade un contenedor de corazón adicional permanentemente al HUD del jugador.
        \item \textbf{Costo Base:} $100$ Diamantes de Almas.
        \item \textbf{Lógica Matemática:}
        \[
        HP_{max} \leftarrow HP_{max} + 1
        \]
        Al confirmarse la compra, el total de salud actual del jugador se restaura de forma instantánea al $100\%$ del nuevo valor máximo, actuando también como una curación completa.
    \end{itemize}

    \item \textbf{Mejora de Fuerza (Daño de Proyectiles):}
    \begin{itemize}
        \item \textbf{Efecto:} Incrementa el poder de impacto de las flechas mágicas disparadas por el arco de Sir Gareth.
        \item \textbf{Costo Base:} $150$ Diamantes de Almas.
        \item \textbf{Lógica Matemática:} La nueva variable de daño se calcula aplicando un multiplicador flotante acumulativo del $20\%$ sobre la estadística actual:
        \[
        Dmg_{nuevo} \leftarrow Dmg_{actual} \times 1.20
        \]
    \end{itemize}
\end{itemize}
