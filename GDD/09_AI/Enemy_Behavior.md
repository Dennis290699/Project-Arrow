\subsection{Comportamiento de los Enemigos}

El comportamiento de los agentes no jugables (Enemigos) se modela de manera determinista mediante una Máquina de Estados Finitos (FSM). Esto asegura un comportamiento predecible y optimiza el rendimiento del motor de juego Unity 6.

\subsubsection*{Formalización matemática de la FSM}

Cada enemigo se define formalmente como la tupla matemática:
\[
M = \langle S, \Sigma, \delta, S_0, F \rangle
\]

Donde:
\begin{itemize}
    \item $S$ (Conjunto de Estados): $S = \{S_{Patrol}, S_{Chase}, S_{Attack}, S_{Dead}\}$
    \item $S_0$ (Estado Inicial): $S_0 = S_{Patrol}$
    \item $F$ (Estado Final / Sumidero): $F = \{S_{Dead}\}$
    \item $\Sigma$ (Alfabeto de Entrada / Condiciones del entorno): Conjunto de variables de distancia $d$, detección de bordes, puntos de salud ($HP$) y temporizadores ($t$).
    \item $\delta$ (Función de Transición): $S \times \Sigma \rightarrow S$
\end{itemize}

\subsubsection*{Parámetros técnicos y métricas del sistema}

Las transiciones de estado dependen de la evaluación continua (en el método \texttt{Update()} o \texttt{FixedUpdate()} del motor, dependiente de $\Delta t$) de las siguientes variables espaciales y temporales:
\begin{itemize}
    \item \textbf{Radio de Detección de Persecución ($R_{detect}$):} $6.0$ unidades de Unity (metros). Calculado mediante \texttt{Physics2D.OverlapCircle}.
    \item \textbf{Distancia Límite de Acercamiento ($R_{retrieve}$):} $3.0$ unidades de Unity. Define el punto muerto donde el enemigo cuerpo a cuerpo detiene su persecución para iniciar el ataque.
    \item \textbf{Radio de Impacto Melee ($R_{attack}$):} $1.0$ unidad de Unity.
    \item \textbf{Vector de Detección de Suelo ($V_{ray}$):} Empleado para evitar caídas al vacío. Se traza un \texttt{Raycast2D} desde el origen del frente del enemigo $\vec{p}$ hacia el vector gravedad $\vec{u}_{down}$, con una magnitud $d = 0.3$ unidades.
    \item \textbf{Capa de Colisión Geométrica:} Las detecciones de entorno operan mediante filtrado binario (\texttt{LayerMask}) exclusivamente sobre la capa \texttt{Ground}.
    \item \textbf{Tiempo de Reacción / Cooldown ($t_{cd}$):} $1.5$ segundos. Tiempo de espera computado como $t \geq t_{next}$, donde $t_{next}$ se actualiza tras cada ejecución de un ataque.
\end{itemize}

\subsubsection*{Funciones de transición ($\delta$) y lógica de estados}

El comportamiento algorítmico se divide según el arquetipo del enemigo, evaluando las variables en cada frame:

\paragraph{1. Evaluación de Muerte (Transición Global Absoluta)}
Independientemente del estado actual $S_i$, si los puntos de vida caen a cero o menos, la máquina transiciona al estado final (sumidero):
\[
\delta(S_i, HP \leq 0) \rightarrow S_{Dead}
\]
En $S_{Dead}$, las fuerzas de gravedad se anulan (\texttt{gravityScale = 0f}) y las colisiones geométricas se desactivan (\texttt{BoxCollider2D.enabled = false}) para prevenir interferencias físicas con el jugador u otros elementos del escenario mientras se reproduce la animación de muerte.

\paragraph{2. Enemigos Cuerpo a Cuerpo (Esqueleto / Ninja)}
Sea $d$ la distancia euclidiana escalar entre el centro del enemigo y el transform del jugador $d = || \vec{p}_{jugador} - \vec{p}_{enemigo} ||$:
\begin{itemize}
    \item \textbf{Patrulla a Persecución:}
    \[
    \delta(S_{Patrol}, d \leq R_{detect}) \rightarrow S_{Chase}
    \]
    El enemigo interrumpe el movimiento de patrulla base (a velocidad de $1.0$ m/s) e inicia la interpolación hacia el jugador (\texttt{Vector2.MoveTowards}) a velocidad de persecución ($2.0$ - $3.5$ m/s).
    \item \textbf{Persecución a Ataque:}
    \[
    \delta(S_{Chase}, d \leq R_{retrieve}) \rightarrow S_{Attack}
    \]
    El enemigo detiene el desplazamiento horizontal y activa el Trigger de animación de daño.
    \item \textbf{Control de Bordes en Patrulla:}
    Definimos la función booleana de colisión del rayo $C(\vec{p} + \vec{u}_{down} \cdot 0.3, Layer_{Ground}) \rightarrow \{0, 1\}$. Si $C = 0$ (no hay suelo delante de la plataforma) mientras el enemigo está en $S_{Patrol}$, este invierte su rotación en el eje Y ($180^{\circ}$) para mantenerse patrullando dentro de la superficie sólida.
\end{itemize}

\paragraph{3. Enemigos a Distancia (Arquero Corrompido)}
Al ser un enemigo estacionario, su FSM prescinde del estado de persecución ($S_{Chase}$):
\begin{itemize}
    \item \textbf{Patrulla/Reposo a Ataque:}
    \[
    \delta(S_{Patrol}, (d \leq R_{detect}) \land (t \geq t_{next})) \rightarrow S_{Attack}
    \]
    Si el jugador cruza el umbral de detección de $6.0$ metros y el tiempo de recarga se ha cumplido, el arquero gira para encarar al jugador e instancia un proyectil con velocidad constante de $10.0$ m/s.
    \item \textbf{Retorno a Reposo:}
    \[
    \delta(S_{Attack}, t < t_{next}) \rightarrow S_{Patrol}
    \]
    Tras disparar, el estado se revierte a reposo, forzando la evaluación temporal antes del siguiente ciclo de ataque.
\end{itemize}