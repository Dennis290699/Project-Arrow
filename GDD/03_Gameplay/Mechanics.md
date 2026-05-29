\subsection{Mecánicas principales}

\subsubsection*{Movimiento horizontal}

El personaje principal se desplaza de forma lateral a una velocidad constante de $5f$ unidades de Unity por segundo. Este comportamiento se calcula directamente manipulando la posición del \texttt{Transform} a través del ciclo de físicas con \texttt{fixedDeltaTime}, garantizando una respuesta consistente que prescinde de inercias complejas en el suelo.

\subsubsection*{Sistema de salto y doble salto}

El salto básico utiliza un impulso vertical ascendente con una fuerza de $7f$ unidades de fuerza aplicadas al componente \texttt{Rigidbody2D}. Para expandir la agilidad y las opciones de plataformeo, Sir Gareth cuenta con un sistema de \textbf{doble salto} (capacidad máxima de saltos consecutivos: $2$). El contador de saltos se reinicia automáticamente cuando los sensores de contacto ubicados en el extremo inferior del personaje detectan la superficie del suelo (\texttt{isGrounded == true}).

\subsubsection*{Mecánica de evasión (Dash)}

El jugador cuenta con una maniobra evasiva rápida (\emph{Dash}) que se activa mediante el \textbf{Clic Derecho} del mouse. Al iniciarse el dash, el script de control realiza las siguientes acciones de forma secuencial:
\begin{itemize}
    \item Desactiva temporalmente la gravedad sobre el personaje (\texttt{gravityScale = 0f}).
    \item Aplica una fuerza de velocidad horizontal extrema de $15f$ unidades en la dirección del movimiento actual.
    \item Mantiene esta propulsión horizontal constante durante un intervalo máximo de $0.2f$ segundos.
    \item Al finalizar el temporizador de $0.2f$ segundos, se restaura la gravedad original y el personaje recupera su estado estándar.
\end{itemize}

\subsubsection*{Combate a distancia (Arco y flecha)}

El arco y la flecha constituyen la única herramienta ofensiva de Sir Gareth.
\begin{itemize}
    \item \textbf{Ataque base:} El jugador dispara un proyectil con física activa (Flecha) en la dirección horizontal hacia la que apunta.
    \item \textbf{Velocidad del proyectil:} La flecha se desplaza a una velocidad constante de $7f$ unidades por segundo.
    \item \textbf{Recursos y costos:} El ataque no requiere de maná, estamina ni energía mágica, lo que permite al jugador atacar de forma constante.
    \item \textbf{Daño infligido:} Cada flecha que colisiona con un enemigo resta exactamente $1$ punto de salud ($HP$).
    \item \textbf{Tiempo de recuperación (Cooldown):} El intervalo de disparo está limitado de forma natural por la duración de la animación de tensado y disparo del arco del jugador, sin limitadores artificiales adicionales en el código.
\end{itemize}

\subsubsection*{Sistema de salud (HP)}

El sistema de vitalidad del jugador se gestiona mediante unidades enteras representadas visualmente como contenedores de corazones en la interfaz de usuario:
\begin{itemize}
    \item \textbf{Salud inicial del jugador:} Sir Gareth inicia la partida con un máximo de $5$ puntos de salud ($HP$).
    \item \textbf{Salud de enemigos base:} Los enemigos base en la zona inicial cuentan con $3$ puntos de salud ($HP$).
    \item \textbf{Daño recibido:} Cualquier daño provocado por contacto con enemigos, ataques a distancia hostiles o trampas del entorno (pinchos o sierras) reduce el total de vitalidad del jugador en exactamente $1$ punto de salud ($HP$).
\end{itemize}

\subsubsection*{Economía interna}

Los enemigos derrotados y los cofres del tesoro ocultos liberan \textbf{Diamantes de Almas} (\emph{Soul Diamonds}). Estos diamantes actúan como la moneda exclusiva del juego y se almacenan como variables numéricas enteras. Su acumulación permite desbloquear mejoras permanentes de salud máxima y daño de flechas al interactuar con el Eco de Elara.

\subsubsection*{Retroalimentación al jugador}

Para maximizar el \emph{Game Feel}, el juego implementa retroalimentación visual y auditiva inmediata en cada suceso:
\begin{itemize}
    \item \textbf{Daño a enemigos:} Genera un flash de color rojo en el sprite del enemigo, un efecto de partículas destructivas y despliega textos flotantes con el daño.
    \item \textbf{Daño al jugador:} Activa un breve periodo de invulnerabilidad temporal (IFrames) con parpadeo de opacidad en el sprite del caballero para evitar daño por contacto continuo.
    \item \textbf{Recolección:} La obtención de diamantes e ítems de curación genera sonidos e iluminación local transitoria.
\end{itemize}
