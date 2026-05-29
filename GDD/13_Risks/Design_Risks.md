\subsection{Riesgos de diseño}

En esta sección se detallan los riesgos de diseño de juego que podrían afectar la jugabilidad, el balance de dificultad o la entrega a tiempo del proyecto, estableciendo pautas de mitigación.

\subsubsection*{Crecimiento descontrolado del alcance (Scope Creep)}

El riesgo de extender el diseño original agregando demasiados niveles, múltiples enemigos complejos o sistemas narrativos avanzados en un plazo académico limitado. Intentar abarcar todo el castillo de Valtheria puede comprometer la calidad general y dejar el juego incompleto o con errores graves de jugabilidad.

\textbf{Mitigación:}
\begin{itemize}
    \item Adopción estricta de la filosofía de \textbf{Corte Vertical}. El equipo se centrará exclusivamente en pulir el nivel de los \textit{Jardines Marchitos}, garantizando que todas las mecánicas principales (movimiento, doble salto, dash, ataque con arco, IA de tres enemigos, menús de UI, mejoras en el checkpoint e hilo de audio) funcionen de forma estable antes de contemplar la creación de otras escenas.
\end{itemize}

\subsubsection*{Falta de balanceo y frustración del jugador}

Un mal ajuste de las estadísticas (como una velocidad de persecución de enemigos excesiva, una fuerza de salto insuficiente para superar fosos, o una salud de enemigos muy elevada) puede provocar frustración o aburrimiento crónico, perjudicando la percepción del prototipo.

\textbf{Mitigación:}
\begin{itemize}
    \item \textbf{Parametrización por Inspector:} Todas las variables físicas y de estadísticas críticas (velocidad horizontal del jugador, fuerza de salto, duraciones de dash, salud y daño de enemigos) se declaran como campos editables en Unity (\texttt{[SerializeField]}) o mediante \texttt{ScriptableObjects}. Esto permite realizar ajustes finos instantáneos en tiempo de ejecución sin necesidad de reescribir código.
    \item \textbf{Cálculo del Time-to-Kill (TTK):} Se utilizará la matriz de escalado matemático para asegurar que el avance y las mejoras adquiridas en el Eco de Elara reduzcan el tiempo de combate de forma perceptible y justa para el usuario.
    \item \textbf{Sesiones de QA Internas:} Se realizarán pruebas de juego cruzadas entre los integrantes del equipo para recabar opiniones subjetivas de dificultad y ajustar la métrica de saltos y la agresividad de las IAs.
\end{itemize}
