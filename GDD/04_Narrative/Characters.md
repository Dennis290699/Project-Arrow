\subsection{Personaje Principal: Sir Gareth}

\textbf{Código interno:} CHR-001

Sir Gareth es el protagonista principal de \textit{Chronicles of the Cursed Knight}. En el pasado, fue un caballero elfo élite y uno de los guardianes arqueros de Eldergrove en el reino de Valtheria. Tras cometer un grave error durante la Noche de la Ceniza que permitió el destrozo del Corazón del Bosque y el colapso del reino, Gareth fue consumido por la corrupción. Esta le otorgó una maldición gótica de semi-inmortalidad, condenándolo a vagar en constante agonía por las ruinas de su antiguo hogar.

Gareth combate exclusivamente a distancia utilizando un arco mágico que dispara flechas físicas, combinando precisión y gran agilidad (gracias a su capacidad de doble salto y dash rápido) para evadir las amenazas del entorno sin necesidad de entrar en combate cuerpo a cuerpo.

\subsubsection*{Características principales}
\begin{itemize}
    \item \textbf{Especialista en arco:} Ataques a larga distancia de alta precisión.
    \item \textbf{Alta movilidad:} Doble salto y maniobra de Dash evasiva rápida.
    \item \textbf{Estadísticas base:} Salud máxima de $5$ HP (Corazones), velocidad horizontal de $5f$ y fuerza de salto de $7f$.
    \item \textbf{Vulnerabilidad estándar:} Cada impacto de enemigos o trampas le resta $1$ HP.
\end{itemize}

\subsubsection*{Objetivo narrativo}
Redimirse de su fracaso en la Noche de la Ceniza recolectando los fragmentos del Corazón del Bosque y liberando la corrupción de Valtheria, buscando romper su maldición con la guía del Eco de Elara.

\subsubsection*{Diseño visual}
Estética retro medieval basada en \textit{pixel art}. Viste una armadura ligera de arquero con tonos verdosos, una capa distintiva que acentúa su silueta durante el movimiento y lleva su arco de madera reforzado.

\begin{figure}[H]
    \centering
    \includegraphics[width=0.35\textwidth]{assets/images/Principal.png}
    \caption{Diseño conceptual del protagonista Sir Gareth}
\end{figure}

\vspace{0.5cm}

\subsection{El Eco de Elara (Personaje de Soporte / Guía)}

\textbf{Código interno:} NPC-ELA-01

Elara fue la Gran Sacerdotisa del templo del Corazón del Bosque. Durante la Noche de la Ceniza, sacrificó su vida física en un intento desesperado por contener la corrupción y proteger los fragmentos del Corazón. En la actualidad del juego, su espíritu se manifiesta como una proyección etérea brillante en las estatuas sagradas de Valtheria (los puntos de control).

\subsubsection*{Características principales}
\begin{itemize}
    \item \textbf{Guía espiritual:} Ofrece diálogos que desvelan el pasado de Gareth y el lore del mundo.
    \item \textbf{Estatua del Eco:} Actúa como zona de descanso (Checkpoint) y alberga la interfaz de mejoras gastando Diamantes de Almas.
\end{itemize}

\subsubsection*{Objetivo narrativo}
Guiar a Sir Gareth en su camino de redención, purificar su cuerpo de la maldición de forma gradual y ayudarle a reconstruir el Corazón del Bosque para que ambos puedan encontrar la paz.

\subsubsection*{Diseño visual}
Silueta etérea de tonos celestes y dorados translúcidos. Viste túnicas ceremoniales ligeras de sacerdotisa elfa y emite un suave brillo mágico circular a su alrededor.

\vspace{0.5cm}

\subsection{Archimago Lord Malakor (Antagonista Principal)}

\textbf{Código interno:} BOSS-MAL-01

Malakor fue el sabio consejero real de Valtheria, quien consumido por el deseo de inmortalidad, pactó con las fuerzas oscuras de la Ceniza. Fue el autor intelectual de la catástrofe de la Noche de la Ceniza, manipulando a Sir Gareth para vulnerar el templo del Corazón del Bosque. Gobierna desde lo alto de la Torre Marchita.

\subsubsection*{Características principales}
\begin{itemize}
    \item \textbf{Hechicero corrupto:} Utiliza magia de ceniza y convoca proyectiles oscuros a larga distancia.
    \item \textbf{Control de zona:} Jefe final del juego, posee un alto conteo de vida y múltiples fases de combate.
\end{itemize}

\subsubsection*{Objetivo narrativo}
Mantener al reino de Valtheria bajo el control de la corrupción, consumar su inmortalidad y destruir a Sir Gareth antes de que logre reconstruir el Corazón del Bosque.

\subsubsection*{Diseño visual}
Túnicas oscuras y desgastadas de color púrpura y negro, con detalles de ceniza flotando a su alrededor. Lleva un báculo de madera retorcida rematado por una gema de ceniza incandescente.

\vspace{0.5cm}

\subsection{Fichas Técnicas de Enemigos}

El juego cuenta con tres tipos de enemigos principales, diseñados para desafiar la evasión, reflejos y precisión de salto del jugador.

\subsubsection{Ficha Técnica 1: Ninja de la Sombra}
\textbf{Código interno:} ENM-NIN-02 \\
\textbf{Nombre de archivo (Sprite Sheet):} \texttt{yellowNinja} \\
\textbf{Script Controlador:} \texttt{Enemy.cs} (con adaptaciones para saltos de persecución)
\begin{itemize}
    \item \textbf{Comportamiento (IA):} Emboscada rápida. Permanece patrullando en un área muy pequeña. Al detectar a Sir Gareth dentro de su rango de visión circular (evaluado mediante \texttt{Physics2D.OverlapCircle}), sale de su estado de patrulla y se desplaza rápidamente hacia el jugador usando \texttt{Vector2.MoveTowards}.
    \item \textbf{Salud (HP):} $2$ puntos de vida.
    \item \textbf{Velocidad de persecución:} Alta ($3.5f$ unidades/s).
    \item \textbf{Daño infligido:} $1$ HP (Ataque Melee rápido).
    \item \textbf{Mecánica Especial:} Su ataque requiere que el jugador ejecute un Dash para esquivar su embestida rápida antes de poder contraatacar con flechas.
\end{itemize}

\subsubsection{Ficha Técnica 2: Arquero Corrompido}
\textbf{Código interno:} ENM-ARCH-01 \\
\textbf{Nombre de archivo (Sprite Sheet):} \texttt{GandalfHardcore Archer black sheet.png} o \texttt{GandalfHardcore Archer blue sheet.png} \\
\textbf{Script Controlador:} \texttt{Enemy2.cs}
\begin{itemize}
    \item \textbf{Comportamiento (IA):} Estático / Control de zona. Se ubica en plataformas elevadas o de difícil acceso. Al detectar al jugador, gira sobre su eje Y (\texttt{transform.eulerAngles}) para encararlo y dispara flechas hostiles a intervalos regulares respetando su tiempo de recarga.
    \item \textbf{Salud (HP):} $3$ puntos de vida.
    \item \textbf{Velocidad del proyectil:} $10f$ unidades/s.
    \item \textbf{Daño infligido:} $1$ HP (Ataque a Distancia).
    \item \textbf{Cooldown de ataque:} $1.5$ segundos.
\end{itemize}

\subsubsection{Ficha Técnica 3: Esqueleto Reanimado}
\textbf{Código interno:} ENM-SKL-03 \\
\textbf{Nombre de archivo (Sprite Sheet):} \texttt{Skeleton\_01\_Yellow\_Idle.png} \\
\textbf{Script Controlador:} \texttt{Enemy.cs}
\begin{itemize}
    \item \textbf{Comportamiento (IA):} Tanque de patrulla. Movimiento pesado de izquierda a derecha en una plataforma. Traza un \texttt{Raycast2D} diagonal hacia abajo desde su frente para detectar el fin de la plataforma o colisiones con paredes en la capa \texttt{Ground}, girando $180^{\circ}$ al no detectar suelo. Si el jugador entra en su rango de ataque corto, realiza un golpe contundente.
    \item \textbf{Salud (HP):} $5$ puntos de vida (requiere múltiples impactos para ser derrotado).
    \item \textbf{Velocidad de patrulla:} Lenta ($1.0f$ unidades/s).
    \item \textbf{Daño infligido:} $2$ HP (Ataque Melee pesado). La función \texttt{TakeDamage} del jugador recibe esta variable de daño dinámico para restar dos corazones de golpe.
\end{itemize}

\begin{figure}[H]
    \centering
    \includegraphics[width=0.8\textwidth]{assets/images/Enemigos.jpg}
    \caption{Diseño de los enemigos principales presentes en el videojuego}
\end{figure}

\subsection{Requisitos de Animación (Animator Controller)}

Para garantizar la fluidez de las mecánicas, los enemigos implementan una Máquina de Animaciones en Unity regida por las siguientes configuraciones de estado y parámetros:

\begin{itemize}
    \item \textbf{Idle (Reposo):} Animación en bucle (\texttt{Loop Time = true}). Pose estática activa mientras el enemigo patrulla lentamente o espera en su tiempo de recarga.
    \item \textbf{Walk / Run (Movimiento):} Animación en bucle. Activada automáticamente por script cuando la velocidad horizontal en el \texttt{Rigidbody2D} es superior a $0.1f$.
    \item \textbf{Jump (Salto):} Exclusiva del Ninja. Se activa con la transición \texttt{isGrounded == false} para reflejar saltos entre plataformas al perseguir al jugador.
    \item \textbf{Attack\_Melee (Cuerpo a cuerpo):} Animación de un solo ciclo (\texttt{Loop Time = false}). Exclusiva de Esqueleto y Ninja. Incorpora un \textbf{Animation Event} en el frame del golpe para aplicar el daño físico exacto al jugador.
    \item \textbf{Attack\_Ranged (Disparo):} Animación de un solo ciclo. Exclusiva del Arquero. Utiliza la bandera \texttt{Has Exit Time = true} en sus transiciones para evitar cortes bruscos en la animación de tensar el arco. Llama a un método \texttt{FireArrow()} mediante un \textbf{Animation Event}.
    \item \textbf{Hurt (Daño recibido):} Transición rápida mediante el Trigger \texttt{Hurt}. Modifica momentáneamente el canal de color del material del sprite para generar un efecto visual de destello blanco.
    \item \textbf{Death (Muerte):} Animación de un solo ciclo activada por el Bool \texttt{Death = true} cuando la salud del enemigo llega a $0$. Al completarse, un evento de animación invoca el método \texttt{Destroy(gameObject)} para limpiar la memoria.
\end{itemize}

\vspace{0.5cm}

\subsection{Trampas y Obstáculos del Entorno}

\subsubsection*{Principales peligros}
\begin{itemize}
    \item \textbf{Sierras circulares móviles:} Desplazamiento cíclico entre nodos mediante el script \texttt{SawMover.cs}. Causan $1$ HP de daño por impacto.
    \item \textbf{Pinchos estáticos:} Colocados en el suelo de fosas de caída. Restan $1$ HP e instancian al jugador de regreso en la última plataforma estable o checkpoint.
    \item \textbf{Plataformas inestables:} Se desmoronan tras $1.0f$ segundo de contacto directo con el jugador, reapareciendo tras $3.0f$ segundos.
\end{itemize}

\begin{figure}[H]
    \centering
    \includegraphics[width=0.75\textwidth]{assets/images/Trampas.jpg}
    \caption{Trampas y obstáculos distribuidos a lo largo de los escenarios del videojuego}
\end{figure}