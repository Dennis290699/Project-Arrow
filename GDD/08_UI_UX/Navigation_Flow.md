\subsection{Flujo de navegación}

El flujo de pantallas y estados del juego está estructurado para asegurar transiciones lógicas e impedir la pérdida de datos o bloqueos del hilo principal de la aplicación.

\subsubsection*{Estados principales del sistema}

\begin{enumerate}
    \item \textbf{Menú Principal (Main Menu State):} Estado inicial de arranque. El tiempo transcurre de forma normal (\texttt{Time.timeScale = 1f}). Permite configurar opciones básicas o iniciar la partida.
    \item \textbf{Carga Asíncrona (Loading State):} Pantalla intermedia gestionada por el script \texttt{SceneManagement.cs}. Evita congelamientos de pantalla cargando los assets gráficos y de física en segundo plano mediante subprocesos asíncronos.
    \item \textbf{Juego Activo (Playing State):} Estado principal de simulación. Se ejecutan los ciclos de físicas (\texttt{FixedUpdate()}) y las actualizaciones de cámara, enemigos e inputs.
    \item \textbf{Pausa (Paused State):} Interrumpe los ciclos físicos y temporales del motor (\texttt{Time.timeScale = 0f}). Detiene las corrutinas de los enemigos y el movimiento de las sierras.
    \item \textbf{Mejoras y Descanso (Elara Upgrade State):} Estado especial provocado por la colisión del jugador con el trigger del Eco de Elara al presionar la tecla de interacción. Pausa las físicas (\texttt{Time.timeScale = 0f}) y despliega el Canvas de tienda para comprar corazones o daño.
    \item \textbf{Victoria (Victory State):} Se activa al entrar en contacto con el trigger de salida de los Portones del Castillo. Bloquea el movimiento del jugador, le otorga invulnerabilidad total y muestra las estadísticas del nivel.
    \item \textbf{Derrota (Game Over State):} Se activa cuando la salud del jugador llega a $0$. Detiene la simulación física del Rigidbody2D del personaje y muestra las opciones de reintento.
\end{enumerate}

\subsubsection*{Esquema de Transiciones de Navegación}

\begin{verbatim}
[Menú Principal]
       |
       v (Presionar Iniciar - Carga Asíncrona)
[Cinemática Narrativa / Prólogo]
       |
       v (Carga Automática de Escena)
[Juego Activo: Jardines Marchitos] <-------> [Menú de Pausa] (Esc)
       |                     |
       | (Interacción E)     | (HP = 0)
       v                     v
[Tienda del Eco de Elara]   [Pantalla de Derrota]
                             |
                             +---> (Reintentar) ---> [Reiniciar Escena]
                             +---> (Salir) --------> [Menú Principal]
       | (Alcanzar Portones)
       v
[Pantalla de Victoria]
       |
       +---> (Continuar) ---> [Siguiente Escena / Créditos]
\end{verbatim}
