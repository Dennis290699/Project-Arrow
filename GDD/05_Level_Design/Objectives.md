\subsection{Objetivos}

\subsubsection*{Objetivo principal}

El objetivo principal de Sir Gareth es adentrarse en los territorios corrompidos de Valtheria, recuperar los fragmentos dispersos del \textit{Corazón del Bosque} y purificar la tierra para liberarse de su maldición física de decadencia. La progresión jugable requiere que el jugador atraviese cada zona, superando a los guardianes no muertos y las trampas del entorno para asegurar el avance hacia la Torre del Hechicero.

\subsubsection*{Objetivos secundarios}

Los objetivos secundarios están diseñados para fomentar la exploración minuciosa y recompensar la habilidad del jugador:
\begin{itemize}
    \item \textbf{Recolección de almas:} Acumular la mayor cantidad de Diamantes de Almas para gastar en el checkpoint.
    \item \textbf{Recuperar salud:} Buscar corazones ocultos en cofres para rellenar los contenedores perdidos.
    \item \textbf{Descubrir rutas secretas:} Acceder a plataformas elevadas (requiriendo doble salto preciso) que contienen grandes cantidades de almas.
\end{itemize}

\subsubsection*{Condiciones de Victoria y Derrota (Fin del Juego)}

El prototipo establece flujos lógicos claros ante los dos estados finales posibles de la partida: la victoria (superación del nivel) y la derrota (muerte del protagonista).

\paragraph{A. Condición de Victoria (Extracción)}
La culminación de los \textit{Jardines Marchitos} (y de cualquier nivel del juego) está vinculada a un hito geográfico y a un evento físico específico:

\begin{itemize}
    \item \textbf{Zona de transición física:} Al final de los Jardines Marchitos se ubican los Portones del Castillo. Este elemento del entorno contiene un componente \texttt{BoxCollider2D} configurado como \texttt{Is Trigger} y etiquetado con el Tag \texttt{"Exit"}.
    \item \textbf{Activación técnica:} La transición se desencadena en el frame exacto en que el volumen de colisión del jugador entra en contacto con el trigger, ejecutándose el método \texttt{OnTriggerEnter2D(Collider2D other)} del script de control.
    \item \textbf{Flujo de transición y Game Feel:}
    \begin{enumerate}
        \item \textbf{Bloqueo de controles:} La bandera de estado \texttt{isVictory} se establece en \texttt{true}. Esto desactiva el Input de teclado y ratón (\texttt{W}, \texttt{D}, \texttt{Espacio}, clics), detiene las fuerzas del Rigidbody2D y fuerza la animación a \texttt{Idle}, impidiendo que el jugador se mueva.
        \item \textbf{Inmunidad final:} Se desactiva la colisión del jugador con las capas de enemigos y proyectiles hostiles, garantizando que el personaje no muera a causa de proyectiles residuales durante la secuencia de victoria.
        \item \textbf{Feedback de interfaz (Victory UI):} El \texttt{GameManager} activa el panel de la interfaz de victoria (\texttt{victoryUIBG}), animando su aparición en pantalla mediante la librería LeanTween (desplazando su posición local en el eje Y con un suavizado \texttt{setEaseInOutBack} en $0.8$ segundos). El panel calcula y muestra los Diamantes de Almas totales recolectados y la salud restante del jugador.
        \item \textbf{Carga asíncrona de escena:} Al presionar el botón "Continuar" de la interfaz de victoria, se invoca al componente de \texttt{SceneManagement} para cargar la siguiente escena o cinemática utilizando el índice de compilación de Unity (\texttt{SceneManager.LoadScene(nextBuildIndex)}).
    \end{enumerate}
\end{itemize}

\paragraph{B. Condición de Derrota (Muerte de Sir Gareth)}
El fracaso de la partida se origina por la pérdida completa de la salud del jugador:

\begin{itemize}
    \item \textbf{Activación técnica:} Cuando el total de vitalidad de Sir Gareth llega a exactamente $0$ HP en el script \texttt{PlayerController.cs} debido al daño de enemigos o trampas, se invoca al método de muerte.
    \item \textbf{Flujo de Derrota y Game Feel:}
    \begin{enumerate}
        \item \textbf{Bloqueo de controles:} La bandera de estado \texttt{isDead} se establece en \texttt{true}, bloqueando de inmediato cualquier lectura de inputs de teclado o mouse para evitar movimientos o ataques post-mortem. El Rigidbody2D se configura en modo cinemático (\texttt{isKinematic = true}) para evitar desplazamientos por física.
        \item \textbf{Transición Auditiva:} Se detiene de inmediato la música ambiental del nivel mediante \texttt{AudioManager.Instance.StopMusic()} y se reproduce la melodía de derrota.
        \item \textbf{Feedback de interfaz (Game Over UI):} El \texttt{GameManager} activa el panel de la interfaz de derrota (\texttt{gameOverUIBG}), animando su aparición en pantalla mediante LeanTween, desplazándolo verticalmente desde una posición superior externa hacia el centro ($Y=0f$) en un lapso de $0.8$ segundos con una ecuación de amortiguación elástica (\texttt{setEaseOutBounce()}).
        \item \textbf{Reintento del nivel:} Al presionar el botón "Reintentar", el script \texttt{SceneManagement.cs} recarga la escena activa (\texttt{SceneManager.GetActiveScene().buildIndex}). Esto reestablece los corazones del jugador a $5$ HP, reinicia los Diamantes de Almas a la cantidad guardada en el último checkpoint y resetea las posiciones de los enemigos.
    \end{enumerate}
\end{itemize}
